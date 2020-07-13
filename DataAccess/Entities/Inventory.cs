using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class Inventory
    {
        public int ProductId { get; set; }
        public string LocationName { get; set; }
        public int? Stock { get; set; }

        public virtual StoreLocation LocationNameNavigation { get; set; }
        public virtual OrderItem Product { get; set; }
    }
}
