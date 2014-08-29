using System.Collections.Generic;

namespace MVC5Course.Automapper.Models.Complex
{
    public class SuscriptionServicesDTO
    {
        public IList<OfficeDTO> Offices { get; set; }
        public IList<ServiceDTO> Services { get; set; } 
    }
}