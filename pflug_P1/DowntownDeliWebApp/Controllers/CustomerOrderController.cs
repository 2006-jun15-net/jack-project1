using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;
using ClassLibrary.Models;
using DataAccess.Repos;
using DowntownDeliWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DowntownDeliWebApp.Controllers
{
    public class CustomerOrderController : Controller
    {
        private readonly ICustomerOrderRepository _orderRepo;

        public CustomerOrderController(ICustomerOrderRepository orderRepository)
        {
            _orderRepo = orderRepository;
        }






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
        
        [HttpGet]
        public IActionResult DisplayOrders()
        {
            var getorders = _orderRepo.getAllOrders();
            return View(getorders);
        }
    

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCustomerOrder(CustomerOrderViewModel customerorder)
        {
            
            //ViewBag.Locations = new SelectList()
            //if (customerorder is null)
            //{
            //    throw new ArgumentNullException(nameof(customerorder));
            //}

            try
            {
                if (ModelState.IsValid)
                {
                    var addtorepo = new CustomerOrderModel
                    {
                        LocationName = customerorder.LocationName,
                        AmountPurchased = customerorder.AmountPurchased,
                        CustomerName = customerorder.CustomerName,
                        ProductId = customerorder.ProductId,
                  
                        
                    };
                    _orderRepo.AddOrder(addtorepo);
                    _orderRepo.Save();

                    return RedirectToAction(nameof(Index));
                    
                }
                return View(customerorder);
                
            }
            catch
            {
                return View(customerorder);
            }

            


        }

    }
}
