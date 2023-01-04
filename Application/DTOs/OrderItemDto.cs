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
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public OrderItemType Type { get; set; }

    }
        }
