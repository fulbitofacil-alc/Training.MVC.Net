using System.Collections.Generic;

namespace MVC5Course.Automapper.Models.Complex
{
    public class OfficeDTO : ResourceDTO
    {
        public OfficeDTO()
        {
            _bindingType = this.GetType().Name;
        }
      
        public int Quantity { get; set; }

        public IList<OfficeByBranchDTO> OfficeByBranches { get; set; }
    }
}