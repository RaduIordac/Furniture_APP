using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public virtual ICollection<Part>? Parts { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
