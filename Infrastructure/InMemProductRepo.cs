using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemProductRepo : IProduct
    {
        private List<Product> _products;
        public InMemProductRepo()
        {
            _products = new List<Product> { };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
