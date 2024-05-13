using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBestDiet.ProductService.Repositories.Repositories;

namespace MyBestDiet.ProductService.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ProductDbContext _productDbContext;
    public IProductRepository Products { get; }

    public UnitOfWork(ProductDbContext productDbContext,
        IProductRepository productRepository)
    {
        _productDbContext = productDbContext;
        Products = productRepository;
    }

    public int Save()
    {
        return _productDbContext.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _productDbContext.Dispose();
        }
    }

}