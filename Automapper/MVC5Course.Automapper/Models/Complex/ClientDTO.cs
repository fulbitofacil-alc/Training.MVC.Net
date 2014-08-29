using System;
using System.Collections.Generic;

namespace MVC5Course.Automapper.Models.Complex
{
    public class  ClientDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Rating { get; set; }
        public DateTime? JoinDate { get; set; }
        public IList<SuscriptionDTO> Subscriptions { get; set; }
        public string EmailAddress { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public LocationDTO Address { get; set; }
        public bool Enabled { get; set; }
        public string FullName { get; set; }

    }
}
