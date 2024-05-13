using System.Collections.Generic;
using System.Threading.Tasks;
using MyBestDiet.ProductService.DomainModel;
using MyBestDiet.ProductService.Repositories.Repositories;

namespace MyBestDiet.ProductService.Foundation.Services;

public class ProductService : IProductService
{   
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IReadOnlyCollection<Product>> GetAllProducts()
    {
        var products = await _productRepository.GetAllAsync();

        return products;
    }
}