using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace p1_tests
{
   public class BuisnessLogicTests
    {
        private readonly CustomerModel customer = new CustomerModel();
        private readonly CustomerOrderModel custorder = new CustomerOrderModel();
        private readonly LocationModel location = new LocationModel();

        [Fact]
        public void QuantityPurchased_LessThanZero_ThrowsException()
        {
            var amountpurchased = -1;
            Assert.ThrowsAny<Exception>(() => custorder.AmountPurchased == amountpurchased);
        }

        [Fact]
        public void IfOrderIdisNull_ThrowException()
        {
            int? myInt = null;
            Assert.ThrowsAny<Exception>(() => custorder.OrderId == myInt);

        }

        [Fact]
        public void Name_withvoidValue_ThrowsException()
        {
            var nullname = "";
            Assert.ThrowsAny<Exception>(() => customer.FirstName == nullname);
        }

        [Fact]

        public void Name_withValidValue()
        {
            var name = "Jack";
            Assert.Equal(customer.FirstName, name);

        }

        [Fact]
        public void FirstAndLastNameEqualsFullName()
        {
            var firstName = "Jack";
            var lastName = "Pflug";

            Assert.Equal(customer.CustomerName, firstName + lastName);
        }

        [Fact]

        public void InvalidLocationName_ThrowsException()
        {
            var locationname = "Buffalo";
            Assert.ThrowsAny<Exception>(() => location.LocationName == locationname);
        }

        [Fact]
        public void ValidLocationName_StoresValue()
        {
            var locationname = "Syracuse";
            Assert.Equal(location.LocationName, locationname);
        }
     
    }
}
