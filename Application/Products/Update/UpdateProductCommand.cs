using Application.DTOs;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Products.Update
{
    public class UpdateProductCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<PartDto>? Parts { get; set; }

        public List<CategoryDto>? Categories { get; set; }

        public decimal Interest { get; set; }
    }
}
