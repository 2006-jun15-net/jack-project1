using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class CustomerOrder
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? AmountPurchased { get; set; }
        public string CustomerName { get; set; }

        public virtual OrderItem Product { get; set; }
    }
}
