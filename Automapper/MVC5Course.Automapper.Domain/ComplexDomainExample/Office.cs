using System;
using System.Collections.Generic;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class Office : Resource
    {
       public Office()
        {
            OfficeByBranches = new List<OfficeByBranch>();
        }   
        
        public virtual IList<OfficeByBranch> OfficeByBranches { get; set; }

        public virtual int Quantity()
        {
            throw new NotImplementedException();
        }

        public virtual void AddBranch(OfficeByBranch officeByBranch)
        {
            officeByBranch.Office = this;
            OfficeByBranches.Add(officeByBranch);
        }
    }
}
