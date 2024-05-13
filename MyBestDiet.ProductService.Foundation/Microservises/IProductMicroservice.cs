using System.Collections.Generic;
using System.Threading.Tasks;
using MyBestDiet.ProductService.DomainModel;

namespace MyBestDiet.ProductService.Foundation.Microservises;

public interface IProductMicroservice
{
    Task<IReadOnlyCollection<Product>> GetAllProducts();
}