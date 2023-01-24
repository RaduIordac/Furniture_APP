using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IOrderRepository
    {
       
            IEnumerable<Order> GetAllOrders();

            Order GetOrderById(int Id);

            int Create(Order order);

            int Update(Order order);

            int Delete(Order order);

        }
    }

