using FullProject.Domain.Entities;

public class Basket : BaseEntity<int> {

    public Guid UserId {get;set;}

    public int BasketItemId {get;set;}

    public decimal TotalPrice {get;set;}
}