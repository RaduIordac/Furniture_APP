using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PartDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }
        
        public decimal Price { get; }

        public decimal Discount { get; set; } = 0.99m;

        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        public string? Picture { get; set; }
        public decimal SalesPrice
        {
            get { return (Price * 1.5m) * Discount; }
            set { SalesPrice = value; }
        }
    }
}
