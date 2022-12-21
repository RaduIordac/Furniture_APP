using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetById(int Id);

        Category GetByName(string Name);
        int Create(Category product);

        int Update(Category product);

        int Delete(Category product);

    }
}
