using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DowntownDeliWebApp.View_Models
{
    public class CustomerOrderViewModel
    {
        
        public DateTime date;

        [Required]
        [BindProperty]
        public int OrderId { get; set; }

        [Required]
        [BindProperty]
        public int ProductId { get; set; }

        [Required]
        [BindProperty]
        public int? AmountPurchased { get; set; }

        [Required]
        [BindProperty]
        public string CustomerName { get; set; }
    }
}
