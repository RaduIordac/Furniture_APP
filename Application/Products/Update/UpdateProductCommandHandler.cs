using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _productRepository.GetById(request.Id);

            product.Name = request.Name;
            product.Interest = request.Interest;

            if (request.Parts != null)
            {
                foreach (var part in request.Parts)
                {
                    product.Parts.First(p => p.Id == part.Id).Name = part.Name;
                    product.Parts.First(p => p.Id == part.Id).QuantityInStock = part.QuantityInStock;
                }
            }

            //product.Categories = (ICollection<Category>)request.Categories;

            _productRepository.Update(product);

            return Unit.Task;
        }
    }
}
