using FullProject.Domain.Entities;

namespace FullProject.Domain.Entities.Catalog;

public class Product : BaseEntity<int> {
    
    public string Name { get; set; } = string.Empty;
    
    public double Quantity {get;set;}

    public decimal Price { get; set; }

    public int CategoryId {get;set;}
    
}