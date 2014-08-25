using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVC5Course.WebApi.Attributes;

namespace MVC5Course.WebApi.Models
{
    public class Employee
    {
        [Range(10000, 99999)]
        public int Id { get; set; }
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MemberRange(0,9)]
        public List<int> Department { get; set; }

        public bool Fired { get; set; }

        public string Office { get; set; }

        public decimal AnnualIncome { get; set; }

        [LimitChecker("AnnualIncome", 45)]
        public decimal Contribution { get; set; }

    }
}