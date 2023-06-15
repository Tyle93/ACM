namespace ACM.Coupon.Records;

public class SaleDiscountRecord
{
    public string saleId { get; set; }
    public List<SeatDiscountRecord> seats { get; private set; }
    public SaleDiscountRecord(string saleId)
    {
        this.saleId = saleId;
        seats = new();
    }
    public void Insert(SeatDiscountRecord seat)
    {
        seats.Add(seat);
    }
}
