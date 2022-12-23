using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto?>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        Task<ProductDto?> IRequestHandler<GetProductByIdQuery, ProductDto?>.Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = _unitOfWork.ProductRepository.GetById(request.Id);
            ProductDto productDto = new ProductDto();

            if (product != null)
            {
                productDto.Id = request.Id;
                productDto.Name = product.Name;
                productDto.Interest = product.Interest;
                productDto.Parts = product.Parts.Select(p => new PartDto
                {
                    Id = p.Id,
                    Name = p.Name,
                });


                return Task.FromResult(productDto);
            }
            else
            {
                return null;
            }
        }
    }
}
