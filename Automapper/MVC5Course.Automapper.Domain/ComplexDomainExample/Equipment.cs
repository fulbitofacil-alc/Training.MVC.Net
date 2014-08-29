using System.Collections.Generic;
using System.Linq;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class Equipment : Resource
    {

        public virtual IList<EquipmentByBranch> EquipmentByBranches { get; set; }

        public virtual int Quantity()
        {
            return EquipmentByBranches.Sum(x => x.Quantity);
        }

        public virtual void AddBranch(EquipmentByBranch equipmentByBranch)
        {
            equipmentByBranch.Equipment = this;
            EquipmentByBranches.Add(equipmentByBranch);
        }
    }
}