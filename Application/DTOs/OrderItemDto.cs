using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class OrderItemDto
    {
        public int Id { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Subtotal => Price * Quantity;

        public OrderItemType Type { get; set; }

        public Order Order { get; set; } = null!;

       
    }

    public enum OrderItemType
    {
        Part,
        Product
    }




    
        }
