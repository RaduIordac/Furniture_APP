using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.GetAll
{
    public class GetAllProductsQuery : IRequest<List<ProductDto>>
    {

    }
}
