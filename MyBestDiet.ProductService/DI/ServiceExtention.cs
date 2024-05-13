using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBestDiet.ProductService.Repositories;
using MyBestDiet.ProductService.Repositories.Repositories;

namespace MyBestDiet.ProductService.DI;

public static class ServiceExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProductDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}