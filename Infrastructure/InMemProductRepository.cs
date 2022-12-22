using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemProductRepository : IProductRepository
    {
        private List<Product> _products;
        public InMemProductRepository()
        {
            _products = new List<Product> 
            {
                new Product { Id = 1, Name ="Blue couch", Interest=1.5m },
                new Product { Id = 2, Name ="Black chair", Interest=1.5m },
                new Product { Id = 3, Name ="White coffee table", Interest=1.5m },
                new Product { Id = 4, Name ="Dunkel bed", Interest=1.5m },
                new Product { Id = 5, Name ="Yellow rocking chair", Interest=1.5m },

            };


        }

        public int Create(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);

            return product.Id;
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        int IProductRepository.Create(Product product)
        {
            throw new NotImplementedException();
        }

        int IProductRepository.Delete(Product product)
        {
            throw new NotImplementedException();
        }

        
        Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetById(int Id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        int IProductRepository.Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
