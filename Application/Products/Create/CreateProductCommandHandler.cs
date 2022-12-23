using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                //Price = request.Price,
                Parts = (ICollection<Part>)request.Parts,
                Categories = (ICollection<Category>)request.Categories,
                Interest = request.Interest,
            };

            _productRepository.Create(product);

            return Unit.Task;
        }
    }
}
