using Application.Categories;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Parts.Create
{
    public class CreatePartCommand : IRequest
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public ICollection<CategoryDto>? Categories { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
