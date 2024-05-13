using MyBestDiet.ProductService.DomainModel;

namespace MyBestDiet.ProductService.Repositories.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ProductDbContext dbContext) : base(dbContext)
    {
    }
}