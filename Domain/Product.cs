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
        public decimal Price
        {
            get { return this.Price*interest; }
            set
            {
                foreach (Part part in Parts)
                {
                    this.Price += part.Price;
                };
            } 
        }
        public ICollection<Part> ?Parts { get; set; }
        public ICollection<Category> ?Categories { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;

        decimal interest = 1.35m;
    }
}
