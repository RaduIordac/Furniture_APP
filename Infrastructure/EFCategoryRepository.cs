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
   public class EfCategoryRepository : ICategoryRepository
    {
        public readonly FurnitureDbContext _dbContext;

        public EfCategoryRepository(FurnitureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _dbContext.Categories.Include(x => x.Products).ToList();
        }

        public Category GetById(int Id)
        {
            return _dbContext.Categories
                //.Include(x => x.Products)
                .FirstOrDefault(x => x.Id == Id);
        }

        public int Create(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category.Id;
        }

        public int Update(Category category)
        {
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
            return category.Id;
        }

        public int Delete(Category category)
        {
            //_dbContext.Categories.ExecuteDelete(category);
            //_dbContext.SaveChanges();
            //return category.Id;
            return 0;
        }
    }
}
