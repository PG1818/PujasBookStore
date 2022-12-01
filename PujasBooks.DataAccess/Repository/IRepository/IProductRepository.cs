using System;
using System.Collections.Generic;
using System.Text;
using PujasBooks.DataAccess.Repository.IRepository;
using PujasBooks.Models;

namespace PujasBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}