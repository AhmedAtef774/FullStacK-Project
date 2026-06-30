public class OrderItem : BaseEntity<int> {

    public int OrderId {get;set;}

    public int ProductId {get;set;}

    public double Quantity {get;set;}

    public decimal Price {get;set;}

}