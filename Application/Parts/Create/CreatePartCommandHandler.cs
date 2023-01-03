using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Parts;

namespace Application.Parts.Create
{
    public class CreatePartCommandHandler : IRequestHandler<CreatePartCommand>
    {
        private readonly IPartRepository _partRepository;
        public CreatePartCommandHandler(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public Task<Unit> Handle(CreatePartCommand request, CancellationToken cancellationToken)
        {
            var part = new Part
            {
                Name = request.Name,
                Price = request.Price,
                QuantityInStock = request.QuantityInStock,
                //Products = request.Products,
                //Categories = (ICollection<Category>)request.Categories,
            };

            _partRepository.Create(part);

            return Unit.Task;
        }
    }
}
