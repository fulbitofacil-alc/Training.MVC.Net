using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5Course.Automapper.Domain.BasicDomainExample;
using MVC5Course.Automapper.Models.Basic;
using UnitTestProject5.Converters;
using UnitTestProject5.Resolvers;

namespace UnitTestProject5
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void YearInCOmpany()
        {
            AutoMapper.Mapper.CreateMap<double,DateTime>().ConvertUsing<UnixDateConverter>();

            AutoMapper.Mapper.CreateMap<Employee, EmployeeServiceViewModel>()
                .ForMember(dest => dest.YearsInCompany, opt => opt.ResolveUsing<YearOfServiceResolver>());
            
            var employee = new Employee
            {
                Name = "Juan",
                HireDate = new DateTime(2000,6,25),
                HireDateLegacy = 86400
            };

            var employeeInfo = AutoMapper.Mapper.Map<Employee, EmployeeServiceViewModel>(employee);
            //var employessInfo = AutoMapper.Mapper.Map<IList<Employee>, IList<EmployeeServiceViewModel>>(listEmployees);
            Assert.AreEqual(14,employeeInfo.YearsInCompany);
            Assert.AreEqual(new DateTime(1970,1,2).ToLocalTime(),employeeInfo.HireDateLegacy);
        }
    }
}