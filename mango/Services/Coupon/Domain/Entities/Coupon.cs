namespace Domain.Entities;

public class GlobalUsings : BaseEntity
{
    public string? Code { get; set; }
    public double Discount { get; set; }
    public int MinAmount { get; set; }
}