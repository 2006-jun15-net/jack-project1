using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
    }
}
