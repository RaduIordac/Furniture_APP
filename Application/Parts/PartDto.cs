using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Parts
{
    public class PartDto
    {
        public string Name { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}
