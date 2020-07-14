using System;

namespace ClassLibrary.Models
{
    public class CustomerOrderModel
    {

        private int _amountPurchased;
        private int _orderId;
        public DateTime date;
        public int OrderId
        {
            get => _orderId; set
            {
                if (_orderId == 0)
                {
                    throw new Exception("Something went wrong");
                }
            }
        }
        public int ProductId { get; set; }
        public int? AmountPurchased { get => _amountPurchased; 
            set 
            {
            if(_amountPurchased < 0)
                {
                    throw new ArgumentOutOfRangeException("The amount purchased must be greater than one");
                }
            }
            
            }
        public string ProductName { get; set; }
        public string CustomerName{ get; set; }
        public string LocationName { get; set; }
        public CustomerModel customer{ get; set; }
    }
}