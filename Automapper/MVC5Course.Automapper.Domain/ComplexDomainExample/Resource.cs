using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public abstract class Resource : Entity
    {
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual bool IsEnabled { get; set; }
    }

  
}