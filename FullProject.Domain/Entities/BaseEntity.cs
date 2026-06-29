namespace FullProject.Domain.Entities;

public abstract class BaseEntity<TKey> {
    
    public TKey Id {get;set;}

    public DateTime CreatedAt {get;set;}

    public DateTime? UpdatedAt {get;set;}
}