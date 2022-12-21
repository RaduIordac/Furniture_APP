using Application.Categories;
using Application.Parts;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Products.Create
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; }
        
        public List<PartDto>? Parts { get; set; }

        public List<CategoryDto>? Categories { get; set; }


    }
}
