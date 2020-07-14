using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    class OrderItemModel
    {
        private int _quantity;
        public OrderItemModel()
        {
            CustomerOrder = new HashSet<CustomerOrderModel>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        //public int Quantity
        //{
        //    get => _quantity;

        //    set

        //    {

        //        if (value > Location.Stock)

        //        {

        //            throw new ArgumentException(nameof(value), "not enough stock");

        //        }

        //        _quantity = value;

        //    }
        //}

        public virtual ICollection<CustomerOrderModel> CustomerOrder { get; set; }
    }


}


