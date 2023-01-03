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
        IEnumerable<Category> GetAllCategories();

        Category GetById(int Id);

        int Create(Category category);

        int Update(Category category);

        int Delete(Category category);

    }
}
