using ClassLibrary.Models;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary.Interfaces;

namespace DataAccess.Repos
{
    public class CustomerOrderRepo : ICustomerOrderRepository
    {
        private readonly projectZeroContext _projectZeroContext;

        public CustomerOrderRepo(projectZeroContext dbContext)
        {
            _projectZeroContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        }


        public void AddOrder(CustomerOrderModel neworder)
        {

         

            //create new instance of custorder entity and map its values to new order
            var newdbcustomerorder = new CustomerOrder()
            {
             
                CustomerName = neworder.CustomerName,
                AmountPurchased = neworder.AmountPurchased,
                OrderId = neworder.OrderId,
                ProductId = neworder.ProductId
            };

            _projectZeroContext.Add(newdbcustomerorder);
            _projectZeroContext.SaveChanges();

        }

        public List<CustomerOrderModel> getAllOrders()
        {
            var getorders = _projectZeroContext.CustomerOrder.ToList();
            var custorders = new List<CustomerOrderModel>();
            custorders = getorders.ConvertAll(x => new CustomerOrderModel { AmountPurchased = x.AmountPurchased, ProductId = x.ProductId, CustomerName = x.CustomerName });

            return custorders;
        }


        public CustomerOrderModel getOrder(string searchstring)
        {
            //perhaps i could prompt the user to search for the order by the name they put it under
            //CANT COMPLETE THIS UNTIL I ADD A NAME COLUMN TO THE DB TABLE

            var getorderfromdb = _projectZeroContext.CustomerOrder.Where(order => order.CustomerName == searchstring).FirstOrDefault();
            return new CustomerOrderModel()
            {
                AmountPurchased = getorderfromdb.AmountPurchased,
                CustomerName = getorderfromdb.CustomerName,
                OrderId = getorderfromdb.OrderId,
                ProductId = getorderfromdb.ProductId
            };
        }
        public IEnumerable<CustomerOrderModel> GetCustomers(string search)
        {
            IQueryable<Customer> customers = _projectZeroContext.Customer;
            if (!String.IsNullOrEmpty(search))
            {
                customers = customers.Where(x => x.LastName.Contains(search));
            }


            return (IEnumerable<CustomerOrderModel>)customers.ToList();


        }

        public void RemoveOrder(CustomerOrderModel ordertodelete)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _projectZeroContext.SaveChanges();
        }

        public void updateOrder(CustomerOrderModel ordertoupdate)
        {
            //have to remember the order id to update? or should it be by date?

            throw new NotImplementedException();
        }
    }


}
