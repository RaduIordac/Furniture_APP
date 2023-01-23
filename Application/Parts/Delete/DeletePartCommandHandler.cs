using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Parts.Delete
{
    public class DeletePartCommandHandler : IRequestHandler<DeletePartCommand>
    {
        private readonly IPartRepository _partRepository;
        public DeletePartCommandHandler(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public Task<Unit> Handle(DeletePartCommand request, CancellationToken cancellationToken)
        {
            var part = _partRepository.GetPart(request.Id);

            _partRepository.Delete(part);

            return Unit.Task;
        }

    }
}
