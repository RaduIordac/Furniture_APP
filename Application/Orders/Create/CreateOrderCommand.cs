using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Create
{
    public class CreateOrderCommand
    {
        public ICollection<OrderItem> orderItems { get; set; }
    }
}
