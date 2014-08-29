using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public abstract class ResourceDetail : Entity
    {
        public virtual Branch Branch { get; set; }
    }

}
