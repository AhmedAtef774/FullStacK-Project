public class Basket : BaseEntity<int> {

    public int UserId {get;set;}

    public IEnumerable<BasketItem> BasketItems {get;set;} = new List<BasketItem>();

    public decimal TotalPrice {get;set;}
}