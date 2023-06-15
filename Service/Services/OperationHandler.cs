using ACM.Context;
using ACM.Models;
using ACM.Coupon.Records;
using ACM.Coupon.Operations;
using ACM.ACM_Models;
using Microsoft.EntityFrameworkCore;

namespace ACM.Services;

public class OperationHandler{
    private Dictionary<OperationType, Func<SaleItem,int,long>> operations;
    private Dictionary<string,OperationType> operationTypeNames{get; set;}
    public  Dictionary<string,SaleDiscountRecord> appliedDiscounts{get;private set;}
    private ACMContext _acmContext;
    private FPOSContext _context;
    ILogger<OperationHandler> _logger;

    public OperationHandler(ILogger<OperationHandler> logger, ACMContext acmContext,FPOSContext context){
        _logger = logger;
        _acmContext = acmContext;
        _context = context;
        appliedDiscounts = new Dictionary<string, SaleDiscountRecord>();
        configureOperations();
        configureOperationTypeNames();
    }

    private List<Operation> buildOperations(List<SaleItem> seat, CouponRule rule){
        List<Operation> seatOperations = new List<Operation>();
        var ruleItems = rule.CouponItems.ToList();
        foreach(var item in seat){
            Operation op;
            var valid = ruleItems.Where((ruleItem) => ruleItem.ItemName == item.ItemName).First();
            if(valid is null){
                op = new Operation(){
                    item = item,
                    discountAmount = 0,
                    type = OperationType.None
                };
            }else{
                op = new Operation(){
                    item = item,
                    discountAmount = (int)valid.Amount,
                    type = GetOperationType(valid.Operation),
                };
            }
        }
        return new List<Operation>();
    }
    public void ClearActiveDiscounts()
    {
        foreach(var discount in appliedDiscounts)
        {
            RevertOperation(discount.Value);
        }
    }
    public SeatDiscountRecord ApplyOperation(List<SaleItem> seat, CouponRule rule, List<ACM.ACM_Models.CouponItem> items){
        SeatDiscountRecord seatRecord = new (rule.Id);
        foreach(var item in seat){
            int originalPrice = item.BasePrice;
            var coupon = items.Find((c) => c.ItemName == item.ItemName);
            var op = GetOperationType(coupon?.Operation ?? " ");
            long afterPrice;
            if(op != OperationType.None){
                afterPrice = operations[op](item, (int)coupon!.Amount);
            }else{
                afterPrice = originalPrice;
            }      
            seatRecord.Insert(new ItemDiscountRecord(){
                saleItemId = item.SaleItemId.ToString(),
                beforePrice = originalPrice,
                afterPrice = afterPrice
            });
            _context.SaveChanges();
        }
        return seatRecord;
    }

    public void RevertOperation(SaleDiscountRecord record)
    {
        foreach(var seat in record.seats)
        {
            foreach (var item in seat.items)
            {
                var val = _context.SaleItems.Find(Guid.Parse(item.saleItemId!));
                _context.Entry(val!).Reload();
                if (val is not null || _context.Entry(val!).State != EntityState.Detached)
                {
                    val.BasePrice = (int)item.beforePrice;
                    val.TaxablePrice = (int)item.beforePrice;
                }
            }
        }
        try
        {
            _context.SaveChanges();
        }
        catch (Exception e) {
            Console.Write(e.Message);
        }
        appliedDiscounts.Remove(record.saleId);
    }

    private void configureOperationTypeNames(){
        operationTypeNames = new Dictionary<string,OperationType>();
        operationTypeNames["discount-flat"] = OperationType.FlatDiscount;
        operationTypeNames["discount-percent"] = OperationType.PercentDiscount;
        operationTypeNames["price-change"] = OperationType.PriceChange;
        operationTypeNames["price-increase"] = OperationType.PriceIncrease;
        operationTypeNames[""] = OperationType.None; 
    }
    private void configureOperations(){
        operations = new Dictionary<OperationType, Func<SaleItem, int, long>>();
        operations[OperationType.FlatDiscount] = FlatDiscount;
        operations[OperationType.PercentDiscount] = PercentDiscount;
        operations[OperationType.PriceChange] = PriceChange;
        operations[OperationType.PriceIncrease] = PriceIncrease;
        operations[OperationType.None] = NoDiscount;
    }

    private long NoDiscount(SaleItem item, int amount){
        return 0;
    }

    private long FlatDiscount(SaleItem item, int discountAmount){
        item.BasePrice -= discountAmount;
        item.TaxablePrice -= discountAmount;
        if(item.BasePrice < 0){
            item.BasePrice = 0;
        }
        if(item.TaxablePrice < 0){
            item.TaxablePrice = 0;
        }
        return item.BasePrice;
    }

    private long PercentDiscount(SaleItem item, int discountAmount){
        item.BasePrice = (int)((float)item.BasePrice * ((100 - discountAmount)/100f));
        item.TaxablePrice = (int)((float)item.TaxablePrice * ((100 - discountAmount)/100f));
        if (item.BasePrice < 0)
        {
            item.BasePrice = 0;
        }
        if (item.TaxablePrice < 0)
        {
            item.TaxablePrice = 0;
        }
        return item.BasePrice;
    }

    private long PriceChange(SaleItem item, int discountAmount){
        item.BasePrice = discountAmount;
        item.TaxablePrice = discountAmount;
        if (item.BasePrice < 0)
        {
            item.BasePrice = 0;
        }
        if (item.TaxablePrice < 0)
        {
            item.TaxablePrice = 0;
        }
        return item.BasePrice;
    }

    private  long PriceIncrease(SaleItem item, int discountAmount){
        item.BasePrice += discountAmount;
        item.TaxablePrice += discountAmount;
        if (item.BasePrice < 0)
        {
            item.BasePrice = 0;
        }
        if (item.TaxablePrice < 0)
        {
            item.TaxablePrice = 0;
        }
        return item.BasePrice;
    }

    public OperationType GetOperationType(string opString)
    {
        operationTypeNames.TryGetValue(opString, out var op);
        return op;
    }

    public long TryOperation(OperationType op, SaleItem item, int discount)
    {
        var value = (item.BasePrice - operations[op](item,discount));
        _context.Entry(item).Reload();
        return value;
    }

    public void InsertRecord(SaleDiscountRecord record){
        appliedDiscounts.Add(record.saleId, record);
    }
    
}