using System;
using AutoMapper;
using MVC5Course.Automapper.Domain.BasicDomainExample;

namespace UnitTestProject5.Resolvers
{
    public class YearOfServiceResolver : ValueResolver<Employee,int>
    {
        protected override int ResolveCore(Employee source)
        {
            return (int) ((DateTime.Now - source.HireDate).TotalDays/365);
        }
    }
}