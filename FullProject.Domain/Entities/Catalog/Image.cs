namespace FullProject.Domain.Entities.Catalog;

public class Image : BaseEntity<int> {
    
    public string Url { get; set; } = string.Empty;

    public int ProductId {get;set;}
}