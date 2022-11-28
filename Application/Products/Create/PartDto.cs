using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Create
{
    public class PartDto
    {
        public string Name { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
    }
}
