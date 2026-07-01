using FullProject.Domain.Entities;

public class Customer : BaseEntity<int> 
{
    public Guid UserId {get;set;}

    public string Address {get;set;} = string.Empty;

    public string City {get;set;} = string.Empty;

    public string State {get;set;} = string.Empty;

    public string Country {get;set;} = string.Empty;

    public string PostalCode {get;set;} = string.Empty;
}