using Application.DTOs;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Products.Delete
{
    public class DeleteProductCommand : IRequest
    {
        public int Id { get; set; }

    }
}
