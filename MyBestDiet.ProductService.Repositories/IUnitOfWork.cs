using System;
using MyBestDiet.ProductService.Repositories.Repositories;

namespace MyBestDiet.ProductService.Repositories;

public interface IUnitOfWork : IDisposable
{
    IProductRepository Products { get; }

    int Save();
}