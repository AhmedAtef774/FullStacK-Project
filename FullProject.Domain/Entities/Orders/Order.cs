public class Order : BaseEntity<string> {

    public GUid UserId {get;set;}

    public IEnumerable<OrderItem> OrderItems {get;set;} = new List<OrderItem>();

    public decimal TotalPrice {get;set;}

    public OrderStatus Status {get;set;}

    public string ShipAddress {get;set;} = string.Empty;

    public string ShipCity {get;set;} = string.Empty;

    public string ShipState {get;set;} = string.Empty;

    public string ShipCountry {get;set;} = string.Empty;

    public string ShipPostalCode {get;set;} = string.Empty;

}