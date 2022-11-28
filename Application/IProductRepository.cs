using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int Id);
        int Create(Product product);

    }
}
