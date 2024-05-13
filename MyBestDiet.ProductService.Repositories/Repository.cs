using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyBestDiet.ProductService.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ProductDbContext _dbDbContext;

    protected Repository(ProductDbContext dbContext)
    {
        _dbDbContext = dbContext;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbDbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyCollection<T>> GetAllAsync()
    {
        return await _dbDbContext.Set<T>().ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _dbDbContext.Set<T>().AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _dbDbContext.Set<T>().Remove(entity);
    }

    public void Update(T entity)
    {
        _dbDbContext.Set<T>().Update(entity);
    }
}