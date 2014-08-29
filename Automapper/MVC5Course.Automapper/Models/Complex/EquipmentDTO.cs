using System.Collections.Generic;

namespace MVC5Course.Automapper.Models.Complex
{
    public class EquipmentDTO : ResourceDTO
    {
        public IList<EquipmentByBranchDTO> EquipmentByBranches { get; set; }
        public int Quantity { get; set; } 
    }
}