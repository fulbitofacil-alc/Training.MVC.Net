using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC5Course.Automapper.Domain.BasicDomainExample;
using MVC5Course.Automapper.Mapper;
using MVC5Course.Automapper.Models.Basic;
using NUnit.Framework;

namespace MVC5Course.Automapper.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void Mapping()
        {
            CustomerMapper.Bootstrap();
            AutoMapper.Mapper.AssertConfigurationIsValid();
            var customer = new Customer
            {
                FirstName = "Juan",
                LastName = "Perez",
                Address1 = "Home 1",
                Address2 = "Belatrix",
                State = "Lima",
                City = "LIma",
                Zip = "0051"
            };

            var customerInfo = AutoMapper.Mapper.Map<Customer, CustomerInfoViewModel>(customer);

            Assert.AreEqual("Home 1",customerInfo.Address1);
        }
    }
}
