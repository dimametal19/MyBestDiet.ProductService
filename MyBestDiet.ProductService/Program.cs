using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyBestDiet.ProductService.Foundation.Services;
using MyBestDiet.ProductService.Repositories;
using MyBestDiet.ProductService.Repositories.Repositories;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateDefaultApp(args).Build();
        InitializeDatabase(host.Services);

        await host.RunAsync();
    }

    private static IHostBuilder CreateDefaultApp(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args);
        builder.ConfigureServices(ConfigureServices);

        return builder;
    }

    private static void ConfigureServices(HostBuilderContext hostBuilderContext, IServiceCollection services)
    {
        var connectionString ="Server=localhost\\sqlexpress,1450;User=admin;Password=admin;Database=MyBestDiet.Products;Encrypt=false;";
        // var connectionString = hostBuilderContext.Configuration.GetConnectionString("DefaultConnection");
        services.AddSingleton(sp => new DbContextOptionsBuilder<ProductDbContext>()
            .UseApplicationServiceProvider(sp)
            .UseSqlServer(connectionString, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
            .Options);

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductService, ProductService>();
    }

    private static void InitializeDatabase(IServiceProvider serviceProvider)
    {
        var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<ProductDbContext>>();
        using (var dbContext = new ProductDbContext(dbContextOptions))
        {
            dbContext.Database.Migrate();
        }
    }
}