using Application.Categories;
using Application.Parts;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Categories.Create
{
    public class CreateCategoryCommand : IRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ICollection<PartDto>? Categories { get; set; }
        public ICollection<Product>? Products { get; internal set; }
    }
}
