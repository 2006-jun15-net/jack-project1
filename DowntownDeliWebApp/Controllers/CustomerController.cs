using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;
using ClassLibrary.Models;
using DataAccess.Entities;
using DowntownDeliWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DowntownDeliWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerController(ICustomerRepository custrepo)
        {
            _customerRepo = custrepo;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _customerRepo.getAllCustomers();


            return View(model);
        }

        //only when someone accesses/"gets" the create customer controller from the ui will they see the form
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateCustomer(CustomerViewModel customerview)
        {
            if (customerview is null)
            {
                throw new ArgumentNullException(nameof(customerview));
            }

            try
            {
                if (ModelState.IsValid)
                {
             

                    var addtorepo = new CustomerModel
                    {
                        FirstName = customerview.FirstName,
                        LastName = customerview.LastName
                    };

                    _customerRepo.AddCustomer(addtorepo);
                    _customerRepo.saveChanges();

                    return RedirectToAction(nameof(Index));
                }
                return View(customerview);
            }
            catch
            {
                return View(customerview);
            }
        }

        [HttpGet]
        public IActionResult DeleteCustomer()
        {
            return View();
        }
        //[HttpPost]
        //IActionResult DeleteCustomer()
        //{

        //}

        [HttpGet] 
        IActionResult SearchCustomer()
        {
            return View();
        }


    }
    }

