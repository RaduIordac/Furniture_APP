using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public DateTime Created { get; }
        
        public IEnumerable<PartDto> Parts { get; set; } = new List<PartDto>();
       // public ICollection<Category> Categories { get; set; } = new List<Category>();
        public DateTime Modified { get; set; } = DateTime.Now;

        public decimal Interest { get; set; }
    }
}
