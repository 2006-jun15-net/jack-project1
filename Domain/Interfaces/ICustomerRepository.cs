using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces
{
    public interface ICustomerRepository
    {
        CustomerModel getCustomer(int Id);
        List<CustomerModel> getAllCustomers();
        void AddCustomer(CustomerModel customer);
        void RemoveCustomer(int Id);
        void UpdateCustomer(int Id);
        void saveChanges();

    }
}
