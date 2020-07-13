using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DowntownDeliWebApp.Models
{
    public class CustomerViewModel
    {
        //in this view model i have to map the values of the customer model to here?

        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "First Name")]
        [MaxLength(30)]
        [BindProperty]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "Last Name")]
        [MaxLength(30)]
        [BindProperty]
        public string LastName { get; set; }

        [BindProperty]
        public int CustomerId { get; set; }
        [Display(Name = "Customer's Full Name")]
        [BindProperty]
            public string CustomerName { get; set; }



    }
}

