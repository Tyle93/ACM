using ACM.Models;

namespace ACM.Coupon.Operations;

public class Operation{
    public OperationType type{get;init;}
    public SaleItem item{get;init;}
    public int discountAmount{get;init;}
}
