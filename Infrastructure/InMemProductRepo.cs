using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemProductRepo : IProductRepository
    {
        private List<Product> _products;
        public InMemProductRepo()
        {
            _products = new List<Product> 
            {
                new Product { Id = 1, Name ="Blue couch", Price=999.98M },
                new Product { Id = 2, Name ="Black chair", Price=25.33M },
                new Product { Id = 3, Name ="White coffee table", Price=40.67M },
                new Product { Id = 4, Name ="Dunkel bed", Price=2100.35M },
                new Product { Id = 5, Name ="Yellow rocking chair", Price=423.32M },

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

        Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
