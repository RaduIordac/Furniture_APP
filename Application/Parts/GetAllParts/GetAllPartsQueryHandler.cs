using Application.DTOs;
using Application.Products.GetById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Parts.GetAllParts
{
    public class GetAllPartsQueryHandler : IRequestHandler<GetAllPartsQuery, List<PartDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllPartsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        Task<List<PartDto>> IRequestHandler<GetAllPartsQuery, List<PartDto>>.Handle(GetAllPartsQuery request, CancellationToken cancellationToken)
        {
            var parts = _unitOfWork.PartRepository.GetAllParts();
            var result = new List<PartDto>();
            foreach (var part in parts)
            {
                PartDto partDto = new PartDto();
                partDto.Id = part.Id;
                partDto.Name = part.Name;
                                              

                result.Add(partDto);
            }

            return Task.FromResult(result);
        }
    }
}

