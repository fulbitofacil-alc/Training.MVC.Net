namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class EquipmentByBranch : ResourceDetail
    {
        public virtual Equipment Equipment { get; set; }
        public virtual int Quantity { get; set; }
    }
}
