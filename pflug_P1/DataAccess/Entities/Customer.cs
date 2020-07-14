using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
