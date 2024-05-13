using Microsoft.EntityFrameworkCore;
using MyBestDiet.ProductService.DomainModel;

namespace MyBestDiet.ProductService.Repositories;

public class ProductDbContext: DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> contextOptions) : base(contextOptions)
    {

    }

    public DbSet<Product> Products { get; set; }
}