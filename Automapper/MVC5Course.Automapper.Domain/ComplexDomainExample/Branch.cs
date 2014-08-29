using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Components;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class Branch : Entity
    {
        public virtual string Name { get; set; }
        public virtual Location Address { get; set; }
        
    }
}