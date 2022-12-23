using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderItem  //<T>
    {
        //private T _itemValue;
        //public T ItemValue
        //{
        //    get { return _itemValue; }
        //    set { _itemValue = value; }
        //}

        //private OrderItem(T value)
        //{
        //    this._itemValue = value;
        //}

        public int Id { get; set; }

        public Product? Product { get; set; }

        public Part? Part { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Subtotal => Price * Quantity;

        public Order Order { get; set; } = null!;

        //public static OrderItem<Product> GetItem(Product value)
        //{
        //    return new OrderItem<Product>(value);
        //}

        //public static OrderItem<Part> CreateValue(Part value)
        //{
        //    return new OrderItem<Part>(value);
        }

    }

