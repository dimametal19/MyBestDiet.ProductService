using System.Collections.Generic;
using System.Threading.Tasks;
using MyBestDiet.ProductService.DomainModel;

namespace MyBestDiet.ProductService.Foundation.Services;

public interface IProductService
{
    Task<IReadOnlyCollection<Product>> GetAllProducts();
}