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
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<Part> Parts { get; set; } = new List<Part> { new Part() };
        public DateTime Created { get; set; }


    }
}
