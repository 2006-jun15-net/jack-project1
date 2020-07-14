using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class StoreLocation
    {
        
            public StoreLocation()
            {
                CustomerOrder = new HashSet<CustomerOrder>();
            }

            public string LocationName { get; set; }

            public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
        }
}
