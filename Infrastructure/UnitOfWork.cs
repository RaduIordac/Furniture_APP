using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly FurnitureDbContext _dataContext;
        public UnitOfWork(FurnitureDbContext dataContext,
                            IProductRepository productRepository, 
                            IPartRepository partRepository,
                            ICategoryRepository categoryRepository)
        {
            _dataContext = dataContext;
            ProductRepository = productRepository;
            PartRepository = partRepository;
            CategoryRepository = categoryRepository;
        }

        public IProductRepository ProductRepository { get; private set; }
        public IPartRepository PartRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }


        public async Task Save()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }

    }
}
