using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DowntownDeliWebApp.Controllers
{
    public class CustomerOrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCustomerOrder()
        {
            return View();
        }

    }
}
