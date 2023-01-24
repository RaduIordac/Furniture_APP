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
    public class EFOrderRepository: IOrderRepository
    {

        public readonly FurnitureDbContext _dbContext;

        public EFOrderRepository(FurnitureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _dbContext.Orders.Include(x => x.OrderItems).ToList();
        }

        public Order GetOrderById(int Id)
        {
            return _dbContext.Orders
                //.Include(x => x.OrderItems)
                .FirstOrDefault(x => x.Id == Id);
        }

        public int Create(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return order.Id;
        }

        public int Update(Order order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();
            return order.Id;
        }

             

        public int Delete(Order order)
        {
            return 0;
        }

                
        
    }
}
