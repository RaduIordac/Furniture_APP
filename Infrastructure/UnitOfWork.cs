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
                            IOrderRepository orderRepository,
                            ICategoryRepository categoryRepository,
                            IUserRepository userRepository)
        {
            _dataContext = dataContext;
            ProductRepository = productRepository;
            PartRepository = partRepository;
            CategoryRepository = categoryRepository;
            OrderRepository = orderRepository;
            UserRepository = userRepository;
        }

        public IProductRepository ProductRepository { get; private set; }
        public IPartRepository PartRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IOrderRepository OrderRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }


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
