using Application.Products.Create;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
            private readonly IOrderRepository _orderRepository;
            public CreateOrderCommandHandler(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            public Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
            var order = new Order
            {
                Id = request.Id,
                UserName = request.UserName,
                OrderDate= request.OrderDate.Date,   
                OrderItems = request.OrderItems,
                TotalAmount= request.TotalAmount,
                };

                _orderRepository.Create(order);

                return Unit.Task;
            }
        }
    }



