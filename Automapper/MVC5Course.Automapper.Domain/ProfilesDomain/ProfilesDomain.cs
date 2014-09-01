using System.Collections.Generic;

namespace MVC5Course.Automapper.Domain.ProfilesDomain
{
    public class Person
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public Address Address { get; set; }

        public List<Note> Notes { get; set; }
    }

    public class Address
    {
        public string FirstLine { get; set; }

        public string Country { get; set; }

        public string PostCode { get; set; }
    }

    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}