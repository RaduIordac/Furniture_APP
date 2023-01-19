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
        public decimal Price => Parts.Sum(p => p.Price) * Interest; 
                    
        public ICollection<Part> Parts { get; set; } = new List<Part>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;

        public decimal Interest { get; set; } = 1.35m;

        public string? Picture { get; set; }

    }
}
