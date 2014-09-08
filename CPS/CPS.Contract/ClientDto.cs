using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPS.Contract
{
    public class ClientDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentId { get; set; }
        public AddressDto Address { get; set; }
        public DateTime BecomeAClientOn { get; set; }
    }
}
