using System;

namespace ClassLibrary.Models
{
    public class CustomerOrderModel
    {

        //private string _locationName;
        //public CustomerOrder()
        //{
        //    OrderId = OrderId;
        //    date = date;
        //    ProductId = ProductId;
        //    customer = customer;
        //    amountPurchased = amountPurchased;
        //}
                        // not sure if this is necessary yet- i wanted to pass these values within the constructor

        public DateTime date;
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? AmountPurchased { get; set; }
        public string CustomerName{ get; set; }

        public CustomerModel customer{ get; set; }
    }
}