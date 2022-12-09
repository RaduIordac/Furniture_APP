using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
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
            return _dbContext.Products.ToList();
         }

        public Product GetById(int Id)
        {
            var getPbyID = _dbContext.Products.Where(x => x.Id == Id);

            return (Product)getPbyID;
            //return (Product)_dbContext.Products.Find(x => x.Id == Id);
            //throw new NotImplementedException();
        }
    }
}
