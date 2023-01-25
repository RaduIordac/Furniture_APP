using Application.DTOs;
using Application.Products.GetAll;
using Application.Products.GetById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.List
{
    public class GetAllPartsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllPartsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        Task<List<ProductDto>> IRequestHandler<GetAllProductsQuery, List<ProductDto>>.Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            var result = new List<ProductDto>();
            foreach (var product in products)
            {
                ProductDto productDto = new ProductDto();
                productDto.Id = product.Id;
                productDto.Name = product.Name;
                //productDto.Price = product.Price;
                //productDto.Interest = product.Interest;
                ////productDto.Picture= product.Picture;
                //productDto.Parts = product.Parts.Select(p => new PartDto
                //{
                //    Id = p.Id,
                //    Name = p.Name,
                //    //SalesPrice = p.SalesPrice,
                //    //Picture= p.Picture,
                //    //Discount= p.Discount,
                //    //QuantityInStock= p.QuantityInStock,
                    
                //});

                result.Add(productDto);
            }

            return Task.FromResult(result);
        }
    }
}

