using FullProject.Domain.Entities;

public class OrderItem : BaseEntity<int> {

    public int ProductId {get;set;}

    public double Quantity {get;set;}

    public decimal Price {get;set;}

    public int OrderId {get;set;}

    public decimal TotalPrice => Price * (decimal)Quantity;


}