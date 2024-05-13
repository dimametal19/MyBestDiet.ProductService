using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBestDiet.ProductService.Repositories;

public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    
    Task<IReadOnlyCollection<T>> GetAllAsync();
    
    Task AddAsync(T entity);
    
    void Delete(T entity);
    
    void Update(T entity);
}