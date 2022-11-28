using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
