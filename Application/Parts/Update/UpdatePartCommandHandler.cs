using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Update
{
    public class UpdatePartCommandHandler : IRequestHandler<UpdatePartCommand>
    {
        private readonly IPartRepository _partRepository;
        public UpdatePartCommandHandler(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public Task<Unit> Handle(UpdatePartCommand request, CancellationToken cancellationToken)
        {
            var part = _partRepository.GetPart(request.Id);

            part.Name = request.Name;
            part.QuantityInStock = request.QuantityInStock;
            part.Price = request.Price;

            if (request.Categories != null)
            {
                foreach (var categ in request.Categories)
                {
                    part.Categories.First(p => p.Id == part.Id).Name = part.Name;
                }
            }            

            _partRepository.Update(part);

            return Unit.Task;
        }
    }
}
