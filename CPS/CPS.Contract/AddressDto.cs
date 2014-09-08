using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPS.Contract
{
    public class AddressDto
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string StreetAddress { get; set; }
    }
}
