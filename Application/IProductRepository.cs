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

        Product GetByName(string Name);
        int Create(Product product);

        int Update(Product product);

        int Delete(Product product);

    }
}
