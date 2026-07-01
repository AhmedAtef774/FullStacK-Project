using FullProject.Domain.Entities;

public class Order : BaseEntity<string> {

    public int OrderItemId {get;set;}

    public decimal TotalPrice {get;set;}

    public OrderStatus Status {get;set;}

    public int CustomerId {get;set;}

}