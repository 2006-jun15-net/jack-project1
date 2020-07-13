using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces
{
    public interface ICustomerOrderRepository
    {
        CustomerOrderModel getOrder(string searchstring);
        List<CustomerOrderModel> getAllOrdersAtLocation(string locationname);
        void AddOrder(CustomerOrderModel neworder);
        void RemoveOrder(CustomerOrderModel ordertodelete);
        void updateOrder(CustomerOrderModel ordertoupdate);

    }
}
