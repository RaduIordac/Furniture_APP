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

        public EfProductRepository(FurnitureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product.Id;
        }
        public int Update(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return product.Id;
        }

        public int Delete(Product product)
        {
            //_dbContext.Products.ExecuteDelete(product);
            //_dbContext.SaveChanges();
            //return product.Id;
            throw NotImplementedException("No delete yet");
        }

        private Exception NotImplementedException(string v)
        {
            throw new NotImplementedException();
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
        public Product GetByName(string Name)
        {
            var getPbyName = _dbContext.Products.Where(x => x.Name == Name);

            return (Product)getPbyName;
        }
    }
}
