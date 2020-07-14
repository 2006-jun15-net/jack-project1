using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DowntownDeliWebApp.Models;
using ClassLibrary.Interfaces;

namespace DowntownDeliWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerRepository _custrepo;


        public HomeController(ILogger<HomeController> logger, ICustomerRepository custrepo)
        {
            _logger = logger;
            _custrepo = custrepo;

        }



        public IActionResult Index()
        {
            //create a variable that maps the modelview or entity customer to the domain customer 
            //var customer = loadcustomer();
            //var mapper = _mapper.Map<Customer>(loadcustomer);

            //var mapper = DataAccess.Profiles.CustomerProfile();
            //var modelmap = _mapper.Map<DataAccess.Entities.Customer>(loadcustomer);

            return View();
        }

        public ViewResult DisplayCustomers()
        {
            var model = _custrepo.getAllCustomers();


            return View(model);
        }


        //loading dummy data for the purposes of testing the automapper

      
            //}

        

            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }


