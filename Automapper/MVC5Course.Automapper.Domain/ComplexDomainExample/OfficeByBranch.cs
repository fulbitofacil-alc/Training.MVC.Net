namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class OfficeByBranch : ResourceDetail
    {
        public virtual Office Office { get; set; }
        public virtual string Name { get; set; }
        public virtual int Capacity { get; set; }
    }
}
