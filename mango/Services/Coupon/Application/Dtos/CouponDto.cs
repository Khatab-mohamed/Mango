namespace Application.DTOs;

public class CouponDto
{
    public DefaultIdType Id { get; set; }
    public string? Code { get; set; }
    public double Discount { get; set; }
    public int MinAmount { get; set; }
}
