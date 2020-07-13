using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibrary.Models
{
    public class CustomerModel 
    {
        //private List<CustomerModel> customermodels;
        private string _firstname;
        private string _lastname;
        

        public string FirstName
        {
            get => _firstname; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name must not be empty.", nameof(value));
                }
                _firstname = value;
            }

        }

        public string LastName
        {
            get => _lastname;
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name must not be empty.", nameof(value));
                }
                _lastname = value;
            }
        }

        
        public string CustomerName { get => FirstName + " " + LastName; }
        
        public int CustomerId { get; set; }
        public IEnumerable<CustomerModel> CustomerModels;
     
        public List<CustomerOrderModel> Orders { get; set; }

        //public IEnumerator<CustomerModel> GetEnumerator()
        //{
        //    return customermodels.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return customermodels.GetEnumerator();
        //}
    }
}
