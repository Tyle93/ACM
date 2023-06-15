using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Models;

namespace ACM.Coupon.Records
{
    public class SeatDiscountRecord
    {
        public string ruleId { get; private set; }
        public List<ItemDiscountRecord> items { get; private set; }

        public SeatDiscountRecord(string ruleId)
        {
            this.ruleId = ruleId;
            items = new();
        }

        public SeatDiscountRecord(List<ItemDiscountRecord> items, string ruleId)
        {
            this.items = items;
            this.ruleId = ruleId;
        }

        public void Insert(ItemDiscountRecord item)
        {
            items.Add(item);
        }

        public string GetDiscountString()
        {
            string ret = "\n";
            foreach (ItemDiscountRecord item in items)
            {
                ret += $"Sale Item ID: {item.saleItemId},Rule Id: {ruleId},Discount Amount: {((item.beforePrice - item.afterPrice) / 100m).ToString("C2")}\n";
            }
            return ret;
        }
    }
}
