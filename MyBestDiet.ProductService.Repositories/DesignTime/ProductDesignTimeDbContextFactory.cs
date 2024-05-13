using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyBestDiet.ProductService.Repositories.DesignTime;

public class ProductDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProductDbContext>
{
    public const string ConnectionString =
        "Server=localhost\\sqlexpress;Port=1450;Username=admin;Password=admin;Database=Identity;";
    
    public ProductDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<ProductDbContext>().UseSqlServer();

        return new ProductDbContext(options.Options);
    }
}