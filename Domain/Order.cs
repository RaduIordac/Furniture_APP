using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int Id { get; set; }

        public User UserName { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public decimal TotalAmount => OrderItems.Sum(p => p.Price);
    }
}
