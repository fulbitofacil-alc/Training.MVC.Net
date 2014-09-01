using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5Course.Automapper.Domain.BasicDomainExample;
using MVC5Course.Automapper.Mapper;
using MVC5Course.Automapper.Models.Basic;

namespace UnitTestProject5
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CanaryTest()
        {
            CustomerMapper.Bootstrap();
            AutoMapper.Mapper.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void Mapping()
        {
            CustomerMapper.Bootstrap();
            
            var customer = new Customer
            {
                FirstName = "Juan",
                LastName = "Perez",
                Address1 = "Home 1",
                Address2 = "Belatrix",
                State = "Lima",
                City = "LIma",
                Zip = "5151"
            };

            var customerInfo = AutoMapper.Mapper.Map<Customer, CustomerInfoViewModel>(customer);

            Assert.AreEqual("Home 1", customerInfo.Address1);
            Assert.AreEqual("5151",customerInfo.Zip);
        }
    }
}
