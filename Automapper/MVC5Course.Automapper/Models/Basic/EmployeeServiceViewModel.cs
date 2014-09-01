using System;

namespace MVC5Course.Automapper.Models.Basic
{
    public class EmployeeServiceViewModel
    {
        public string Name { get; set; }
        public int YearsInCompany { get; set; }

        public DateTime HireDateLegacy { get; set; }
    }
}