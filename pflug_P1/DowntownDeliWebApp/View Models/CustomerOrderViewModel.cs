using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DowntownDeliWebApp.Models
{
    public class CustomerOrderViewModel
    {
        
        public DateTime date;
        
        [Required]
        [BindProperty]
        public int OrderId { get; set; }

        [Display(Name = "Product Id number")]
        [Required]
        [BindProperty]
        public int ProductId { get; set; }

        [Display(Name = "How much do you want?")]
        [Required]
        [BindProperty]
        public int? AmountPurchased { get; set; }

        [Display(Name ="Your Name")]
        [Required]
        [BindProperty]
        public string CustomerName { get; set; }

        [Display(Name = "Location")]
       [BindProperty]
        [Required]
        public string LocationName { get; set; }



        //public List<SelectListItem> Locations { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "1", Text = "Auburn" },
        //    new SelectListItem { Value = "2", Text = "Syracuse" },
        //    new SelectListItem { Value = "3", Text = "Rochester" },


        //};
    }
}
