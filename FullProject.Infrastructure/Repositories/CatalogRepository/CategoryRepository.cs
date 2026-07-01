using FullProject.Domain.Entities.Catalog;

public class CategoryRepository : Repository<Category, int>, ICategoryRepository
{
    private readonly IDbConnectionFactory connectionFactory;
    public CategoryRepository(IDbConnectionFactory factory) : base(factory)
    {
        this.connectionFactory = factory;
    }
}