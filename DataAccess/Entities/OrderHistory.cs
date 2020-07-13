using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class OrderHistory
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public TimeSpan? OrderTime { get; set; }
        public string LocationName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual StoreLocation LocationNameNavigation { get; set; }
        public virtual OrderItem ProductNameNavigation { get; set; }
    }
}
