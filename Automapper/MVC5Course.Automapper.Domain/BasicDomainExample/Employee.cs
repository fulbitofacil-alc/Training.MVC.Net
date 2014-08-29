using System;

namespace MVC5Course.Automapper.Domain.BasicDomainExample
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Position { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DateOfBirth { get; set; }

        
    }
}