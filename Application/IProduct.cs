using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        Product GetAllProducts(int ID);

    }
}
