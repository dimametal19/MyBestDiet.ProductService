using System.Collections.Generic;
using System.Threading.Tasks;
using MyBestDiet.ProductService.DomainModel;
using MyBestDiet.ProductService.Foundation.Services;

namespace MyBestDiet.ProductService.Foundation.Microservises;

public class ProductMicroservice : IProductMicroservice
{
    private readonly IProductService _productService;

    
    public ProductMicroservice(IProductService productService)
    {
        _productService = productService;
    }
    

    public async Task<IReadOnlyCollection<Product>> GetAllProducts()
    {
        var products = await _productService.GetAllProducts();

        return products;
    }
}