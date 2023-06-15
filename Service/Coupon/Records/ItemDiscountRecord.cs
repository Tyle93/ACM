namespace ACM.Coupon.Records;

public class ItemDiscountRecord
{
    public string? saleItemId { get; init; }
    public long beforePrice { get; init; }
    public long afterPrice { get; init; }

    public static ItemDiscountRecord Create(string id, long before, long after)
    {
        return new ItemDiscountRecord()
        {
            saleItemId = id,
            beforePrice = before,
            afterPrice = after
        };
    }

}