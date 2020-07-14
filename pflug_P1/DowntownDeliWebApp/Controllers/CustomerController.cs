using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;
using ClassLibrary.Models;
using DataAccess.Entities;
using DowntownDeliWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DowntownDeliWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly projectZeroContext _context;

        public CustomerController(ICustomerRepository custrepo, projectZeroContext context)
        {
            _customerRepo = custrepo;
            _context = context;

        }
        [HttpGet]
        public IActionResult DisplayCustomers()
        {
            var model = _customerRepo.getAllCustomers();

            return View(model);
           
        }

        [HttpGet]
        public IActionResult Index()
        {
          


            return View();
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

      
        IActionResult SearchCustomer(string search)
        {
            //var searchcustomer = _context.Customer.Where(cust => cust.FirstName + cust.LastName == search || search == null).ToList();
            //var customermodelList = new List<CustomerModel>();
            //var customomermodelList = searchcustomer.ConvertAll(x => new CustomerModel { CustomerId = x.CustomerId, FirstName = x.FirstName, LastName = x.LastName });
            //return View(customermodelList);

            var customer = _customerRepo.GetCustomers(search);
            return View(customer);
        }

        //return View(db.Students.Where(x = > x.Name.StartsWith(search) || search == null).ToList());  
        

    }
    }


