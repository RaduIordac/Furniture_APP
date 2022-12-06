using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EfProductRepository : IProductRepository
    {
        public readonly FurnitureDbContext _dbContext;

        public EfProductRepository (FurnitureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product.Id;
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
