using System;

namespace CPS.WebApi.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Compensation { get; set; }
        public DateTime Hired { get; set; }
    }
}