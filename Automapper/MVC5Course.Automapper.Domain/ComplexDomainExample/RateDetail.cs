using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public abstract class RateDetail : Entity
    {
        public virtual RateHeader RateHeader { get; set; }
        public virtual decimal Discount { get; set; }
    }

    public abstract class RateDetail<TResource> : RateDetail
    {
        public virtual TResource Resource { get; set; }
    }

    public class OfficeRate : RateDetail<Office>
    {

    }

    public class ServiceRate : RateDetail<Service>
    {

    }
}