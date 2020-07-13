using ClassLibrary.Models;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ClassLibrary.Interfaces
{
    public class CustomerRepo : ICustomerRepository
    {
        private readonly projectZeroContext _projectZeroContext;

        public CustomerRepo(projectZeroContext dbContext)
        {
            _projectZeroContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        }

        public void AddCustomer(CustomerModel customer)
        {
            //instantiate a customer model instance and map it to db entity?
            //add logic that sets the user input equal to the values of CustomerModel customer
            //var maxid = _projectZeroContext.Customer.Max(c => c.CustomerId);
            var newdbcustomer = new Customer() { FirstName = customer.FirstName, LastName = customer.LastName };
            _projectZeroContext.Add(newdbcustomer);
            _projectZeroContext.SaveChanges();
        }

        public List<CustomerModel> getAllCustomers()
        {
            var customerlist = _projectZeroContext.Customer.ToList();
            var customermodelList = new List<CustomerModel>();
            customermodelList = customerlist.ConvertAll(x => new CustomerModel { CustomerId = x.CustomerId, FirstName = x.FirstName, LastName = x.LastName });

            //foreach (var customer in customerlist)
            //{
            //    //customer.CustomerId =
            //    //I want to convert each list item to the modelCustomertype
            //    customermodelList.Add(customer);
            //}

            return customermodelList;
            //perhaps i could do a foreach loop:
            //foreach customer in customerlist, add that to the CustomerModel list

            //return (List<CustomerModel>)customerlist.Select(c => new Customer {
            //    CustomerId = c.CustomerId,
            //    FirstName = c.FirstName,
            //    LastName = c.LastName



            //Idea from stack overflow: target = orig.ConvertAll(x => new TargetType { SomeValue = x.SomeValue });

        }

        public CustomerModel getCustomer(int Id)
        {
            //change to search by name
            var customerindb = _projectZeroContext.Customer.Where(c => c.CustomerId == Id).FirstOrDefault();

            return new CustomerModel
            {
                CustomerId = customerindb.CustomerId,
                FirstName = customerindb.FirstName,
                LastName = customerindb.LastName,
            };
        }

        public void RemoveCustomer(int Id)
        {
            var findCustToDelete = _projectZeroContext.Customer.Where(c => c.CustomerId == Id);
            _projectZeroContext.Remove(findCustToDelete);
            _projectZeroContext.SaveChanges();

        }

        public void saveChanges()
        {
            _projectZeroContext.SaveChanges();
        }

        public void UpdateCustomer(int Id)
        {
            var findCustToUpdate = _projectZeroContext.Customer.Where(c => c.CustomerId == Id);
            _projectZeroContext.Update(findCustToUpdate);
            _projectZeroContext.SaveChanges();
        }
    }
}

