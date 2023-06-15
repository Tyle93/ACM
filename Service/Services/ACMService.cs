using ACM.Context;
using ACM.Models;
using ACM.Coupon.Records;
using SysTask = System.Threading.Tasks;
using ACM.Coupon.Operations;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ACM.Services;

public class ACMService : BackgroundService
{
    private readonly ILogger<ACMService> _logger;
    private FPOSContext _context;
    private ACMContext _acmContext;
    private RuleValidator _validator;
    private OperationHandler _handler;
    public ACMService(ILogger<ACMService> logger, FPOSContext context, RuleValidator validator,ACMContext acmContext, OperationHandler handler)
    {
        _context = context;
        _logger = logger;
        _validator = validator;
        _acmContext = acmContext;
        _handler = handler;
    }
    protected override async SysTask.Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation(new EventId(201), $"ACM Service Startup.");
        while (!stoppingToken.IsCancellationRequested)
        { 
            var orders = GetOpenOrders();
            foreach(var order in orders){
                //_logger.LogInformation(new EventId(202),$"Scanning Order #{order.CheckNumber}");
                var seats = splitOrderBySeat(order);
                SaleDiscountRecord saleRecord = new SaleDiscountRecord(order.SaleId.ToString());
                bool discountApplied = false;
                foreach(var seat in seats){
                    var rules = _validator.GetApplicableRules(seat);
                    if(rules.Any()){
                        var ruleToApply = _validator.GetHighestPriorityRule(rules,seat);
                        var seatRecord = _handler.ApplyOperation(seat, ruleToApply, _validator.GetRuleItems(ruleToApply));
                        saleRecord.Insert(seatRecord);
                        discountApplied = true;
                        _logger.LogInformation(new EventId(420), $"{ruleToApply.Name} applied to a seat for check #{order.CheckNumber}. {seatRecord.GetDiscountString()}");
                    }
                    else
                    { 
                        SeatDiscountRecord seatRecord = new SeatDiscountRecord(order.SaleId.ToString());
                        foreach(var item in seat)
                        {
                            seatRecord.Insert(ItemDiscountRecord.Create(item.SaleItemId.ToString(), item.BasePrice,item.BasePrice));
                        }
                        saleRecord.Insert(seatRecord);
                    }
                }
                if(discountApplied){
                    _handler.InsertRecord(saleRecord);
                    _context.SaveChanges();
                }
                else
                {
                    _logger.LogInformation(new EventId(301), $"No Discounts applied to seats for check number #{order.CheckNumber}");
                }
            }
            _validator.ReloadRules();
            await SysTask.Task.Delay(100, stoppingToken);
        }
        _handler.ClearActiveDiscounts();
    }
    private List<Sale> GetOpenOrders(){
        
        var val = from sale in _context.Sales
                    where  sale.EndDate == null
                    select sale;
        var retVal = val.ToList();

        return retVal.Where((sale) =>
        {
            if(_handler.appliedDiscounts.ContainsKey(sale.SaleId.ToString())){
                if (SaleHasChanged(sale))
                {
                    _handler.RevertOperation(_handler.appliedDiscounts[sale.SaleId.ToString()]);
                    return true;
                }
                return false;
            }
            return true;
        }).ToList();
                    
    }
    private bool SaleHasChanged(Sale sale)
    {
        var saleRecord = _handler.appliedDiscounts[sale.SaleId.ToString()];
        List<SaleItem> recordItems = new List<SaleItem>();
        foreach(var seat in saleRecord.seats)
        {
            foreach (var item in seat.items)
            {
                var val = _context.SaleItems.Find(Guid.Parse(item.saleItemId!));
                if (val is not null)
                {
                    recordItems.Add(val);
                }
                else
                {
                    return true;
                }
            }
        }        
        var items = _context.SaleItems.Where((s) => s.SaleId == sale.SaleId && s.Flags == 0).ToList();
        var diff = recordItems.Except(items).ToList();
        var diff2 = items.Except(recordItems).ToList();
        if (diff.Any() || diff2.Any())
        {
            return true;
        }
        return false;
    }
    private List<Sale> GetOpenOrders(IEnumerable<Guid> saleIds){
        return new List<Sale>();
    }

    private bool ValidateItems(IEnumerable<Item> SeatItems, IEnumerable<Item> Couponitems){
        return Couponitems.Intersect(SeatItems).ToHashSet().SetEquals(Couponitems);
    }

    private List<List<SaleItem>> splitOrderBySeat(Sale sale){
        List<List<SaleItem>> seats = new List<List<SaleItem>>();
        List<SaleItem> items = getSaleItems(sale);
        int currentSeat = 0;
        List<SaleItem> seat = new List<SaleItem>();
        for(int i = 0; i < items.Count; i++){
            if(items[i].Flags == 4 ){
                if(currentSeat == 0){
                    currentSeat++;
                }else{
                    if (seat.Any())
                    {
                        seats.Add(seat);
                        seat = new List<SaleItem>();
                    }
                }            
            }else if(items[i].Flags == 0){
                seat.Add(items[i]);
            }else{
                continue;
            }
        }
        if(seat.Any() && !seats.Contains(seat))
        {
            seats.Add(seat);
        }
        return seats;
    }
    private List<SaleItem> getSaleItems(Sale sale){
        Guid saleId = sale.SaleId;
        var items = from item in _context.SaleItems
                    where item.SaleId == saleId
                    select item;

        return items.OrderBy(item => item.ItemIndex ).ToList();
    }
    
    private List<SaleItem> getSaleItems(Guid saleId){
        var items = from item in _context.SaleItems
                    where item.SaleId == saleId
                    select item;
        return items.ToList();
    }

    private Sale GetSaleById(Guid id){
        return _context.Sales.Where(sale => sale.SaleId == id).First();
    }

}
