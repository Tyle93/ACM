using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerCards = new HashSet<CustomerCard>();
            CustomerLastOrders = new HashSet<CustomerLastOrder>();
            CustomerPlans = new HashSet<CustomerPlan>();
        }

        public Guid CustomerId { get; set; }
        public Guid RegionId { get; set; }
        public int CustomerNumber { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string MiddleInitial { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Badge { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Directions { get; set; }
        public string? Comments { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public int AvailableCredit { get; set; }
        public int CreditLimit { get; set; }
        public short YtdYear { get; set; }
        public int YtdTotal { get; set; }
        public int YtxTotal { get; set; }
        public string? Email { get; set; }
        public string? UserData { get; set; }
        public string? Extension { get; set; }
        public string? Company { get; set; }
        public int MealCount { get; set; }
        public byte[] Bcitems { get; set; } = null!;
        public byte DeliveryZone { get; set; }
        public byte PriceLevel { get; set; }
        public byte[]? Fpbuffer { get; set; }
        public int UsedPlansBit { get; set; }
        public int CustomerDiscount { get; set; }
        public int StoreId { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Phone4 { get; set; }
        public string? Phone5 { get; set; }
        public string? Extension2 { get; set; }
        public string? Extension3 { get; set; }
        public string? Extension4 { get; set; }
        public string? Extension5 { get; set; }
        public int WebId { get; set; }
        public string? CustomerCard { get; set; }
        public bool CustomerCardReassign { get; set; }
        public int ParentCustomer { get; set; }

        public virtual ICollection<CustomerCard> CustomerCards { get; set; }
        public virtual ICollection<CustomerLastOrder> CustomerLastOrders { get; set; }
        public virtual ICollection<CustomerPlan> CustomerPlans { get; set; }
    }
}
