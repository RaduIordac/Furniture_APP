using Application.DTOs;
using Application.Products.GetById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Parts.GetById
{
    public class GetPartsByIdQueryHandler : IRequestHandler<GetPartsByIdQuery, PartDto?>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetPartsByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        Task<PartDto?> IRequestHandler<GetPartsByIdQuery, PartDto?>.Handle(GetPartsByIdQuery request, CancellationToken cancellationToken)
        {
            var part = _unitOfWork.PartRepository.GetPart(request.Id);
            PartDto partDto = new PartDto();

            if (part != null)
            {
                partDto.Id = request.Id;
                partDto.Name = part.Name;
               partDto.QuantityInStock = part.QuantityInStock;

                return Task.FromResult(partDto);
            }
            else
            {
                return null;
            }
        }
    }
}
