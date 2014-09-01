using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5Course.Automapper.Domain.BasicDomainExample;
using MVC5Course.Automapper.Models.Basic;

namespace UnitTestProject5
{
    [TestClass]
    public class CarSetupClass
    {
        [TestMethod]
        public void CarInfoTest()
        {
            AutoMapper.Mapper.CreateMap<CarSetup, CarInfoViewModel>();
            var car = new CarSetup
            {
                Configuration = new EngineConfiguration {ModelNumber = "V8", ModelYear = 2014},
                DefectRate = 5,
                ExportCode = new Guid(),
                Maker = "Ferrari",
                VIN = "KAF8766876"
            };

            var carInfo = AutoMapper.Mapper.Map<CarSetup, CarInfoViewModel>(car);
            Assert.AreEqual("V8",carInfo.ConfigurationModelNumber);

        }
    }
}