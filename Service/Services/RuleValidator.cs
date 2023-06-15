using ACM.Coupon;
using ACM.Models;
using ACM.Context;
using ACM.ACM_Models;
using System.Runtime;
using System.Net.WebSockets;
using System.Diagnostics;
using System.Data.Entity.Core.Common.CommandTrees;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

namespace ACM.Services;

public class RuleValidator{
    
    private ACMContext _context;
    private Dictionary<string,List<ACM_Models.CouponRule>> ruleBuckets { get;  set; }
    public List<ACM.ACM_Models.CouponItem> items {  get; private set;}
    private readonly ILogger<RuleValidator> _logger;
    private OperationHandler _handler;

    public RuleValidator(ACMContext context, ILogger<RuleValidator> logger, OperationHandler handler){
        _logger = logger;
        _context = context;
        _handler = handler;
        ruleBuckets = new Dictionary<string, List<ACM_Models.CouponRule>>();
        items = _context.CouponItems.ToList();
        LoadRules();
    }
    
    public void ReloadRules(){
        string? connectionString = _context.GetConnectionString();
        DbContextOptionsBuilder<ACMContext> options = new DbContextOptionsBuilder<ACMContext>();
        options.UseSqlite(connectionString!);
        _context = new ACMContext(options.Options);
        ruleBuckets = new Dictionary<string, List<CouponRule>>();
        items = _context.CouponItems.ToList();
        LoadRules();
    }

    private void LoadRules(){
        // Get a List of all current rules.
        //RefreshEntities();
        var rules = _context.CouponRules.ToList();
        // Iterate through list of rules.
        foreach(CouponRule rule in rules){
            // Get list off applicable items for rule.
            //var items = getRuleItems(rule.Id);
            var items = rule.CouponItems.ToList();
            // Iterate through the Rules items.
            foreach(var item in items){
                // Check if a Bucket has been created for a given item type.
                if(ruleBuckets.TryGetValue(item.ItemName, out var ruleBucket)){
                    // Check if Rule is already in bucket and add to bucket if it doesn't.
                    if (!ruleBucket.Contains(rule))
                    {
                        ruleBucket.Add(rule);
                    } 
                }else{
                    // Create bucket if it does not.
                    ruleBuckets[item.ItemName] = new List<CouponRule> {rule};
                }
            }
        }
        _logger.LogInformation(new EventId(205), "Rules Loaded Successfully");
    }

    private void RefreshEntities()
    {
        foreach(var bucket in ruleBuckets)
        {
            foreach(var rule in bucket.Value)
            {
                _context.Entry(rule).Reload();
            }
        }
    }
    // Gets all items of a Rule for a given ID.
    private List<ACM_Models.CouponItem> getRuleItems(string ruleID){
            var items = from item in _context.CouponItems
                    where item.CouponRuleId == ruleID
                    select item;
            
            return items.ToList();
    }
    
    public List<CouponRule> GetApplicableRules(List<SaleItem> items){
        // Set of items that have already had rules retreived.
        HashSet<string> previousItems = new HashSet<string>();
        // List of Rules that can be applied to the items in the current order.
        List<CouponRule> itemRules = new List<CouponRule>(); 
        foreach(var item in items){
            //Check if Rule list has any items in it currently.
            if(!itemRules.Any()){
                // Filter out any rules that are currently inactive, or out of the date and time ranges associated with the rule.
                if(ruleBuckets.ContainsKey(item.ItemName)){
                    itemRules = ruleBuckets[item.ItemName!].Where( coupon =>  (BitConverter.ToBoolean(coupon.IsActive,0) && CheckRuleSchedules(coupon)) ).ToList();
                    previousItems.Add(item.ItemName!);
                }
            }else if(!previousItems.Contains(item.ItemName!)){
                if(ruleBuckets.ContainsKey(item.ItemName)){
                    itemRules.AddRange(ruleBuckets[item.ItemName!].Where( coupon =>  (BitConverter.ToBoolean(coupon.IsActive,0) && CheckRuleSchedules(coupon)) ).ToList());
                }
            }
        }
        List<CouponRule> validRules = new List<CouponRule>();
        foreach(var rule in itemRules)
        {
            var couponItems = rule.CouponItems.ToList();
            bool isValid = false;
            foreach (var item in couponItems) { 
                if(!items.Exists((e) => e.ItemName == item.ItemName))
                {
                    isValid = false;
                    break;
                }
                isValid = true;
            }
            if (isValid)
            {
                validRules.Add(rule);
            }
        }
        return validRules;
    }
    private bool CheckRuleSchedules(CouponRule rule){
        if(DateTime.Parse(rule.StartDate) < DateTime.Now && DateTime.Parse(rule.EndDate) > DateTime.Now){
            List<CouponDailyAvailability> schedule = GetTodaysRuleSchedule(rule);
            foreach(var sched in schedule){
                if(IsDailyScheduleValid(sched)){
                    return true;
                }
            }
            return false;
        }else{
            return false;
        }
    }

    private List<CouponDailyAvailability> GetTodaysRuleSchedule(CouponRule rule){
        var schedule =  GetCouponSchedule(rule);
        DayOfWeek today = DateTime.Now.DayOfWeek;
        return schedule.Where( item => (item.DayIndex == (long)today || item.DayIndex == (long)(today-1))).ToList(); 
    }

    private List<CouponDailyAvailability> GetCouponSchedule(CouponRule rule){
            var schedule =  from sched in _context.CouponDailyAvailabilities
                where sched.CouponRuleId == rule.Id
                select sched;
        return schedule.ToList();
    }

    private bool IsDailyScheduleValid(CouponDailyAvailability schedule){
        var times = ConvertCouponSchedule(schedule);
        if(TimeOnly.FromDateTime(DateTime.Now) > times.Item1 && TimeOnly.FromDateTime(DateTime.Now) < times.Item2){
            return true;
        }
        return false;
    }

    public CouponRule GetHighestPriorityRule(List<CouponRule> rules, List<SaleItem> seat){
        CouponRule? hightestPriorityRule = null;
        long largestDiscount = 0;
        foreach(var rule in rules)
        {
            long discount = TestRule(rule, seat);
            if (discount > largestDiscount)
            {
                hightestPriorityRule = rule;
                largestDiscount = discount;

            }
        }
        return hightestPriorityRule ?? rules.First();
    }

    private (TimeOnly, TimeOnly) ConvertCouponSchedule(CouponDailyAvailability sched)
    {
        return (TimeOnly.Parse($"{sched.StartHour}:{sched.StartMinute}"), TimeOnly.Parse($"{sched.EndHour}:{sched.EndMinute}"));
    }

    private long TestRule(CouponRule rule, List<SaleItem> seat)
    {
        long runningDiscountTotal = 0;
        foreach(var item in seat)
        {
            var ruleItem = GetRuleItem(rule, item.ItemName);
            if(ruleItem is null)
            {
                continue;
            }
            var op = _handler.GetOperationType(ruleItem.Operation);
            runningDiscountTotal += _handler.TryOperation(op, item, (int)ruleItem.Amount);        
        }
        return runningDiscountTotal;
    }

    public ACM.ACM_Models.CouponItem GetRuleItem(CouponRule rule, string itemName)
    {
        var item = items.Where((i) => (i.CouponRuleId == rule.Id && i.ItemName == itemName)).FirstOrDefault();
        return item;
    }

    public List<ACM.ACM_Models.CouponItem> GetRuleItems(CouponRule rule)
    {
        var couponItems = items.Where((item) => item.CouponRuleId == rule.Id).ToList();
        return couponItems;
    }


}

