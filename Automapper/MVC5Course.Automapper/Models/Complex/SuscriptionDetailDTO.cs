namespace MVC5Course.Automapper.Models.Complex
{
    public abstract class SuscriptionDetailDTO : BaseDTO
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }       
 }
    public abstract class SubscriptionDetailDTO<TDetail> : SuscriptionDetailDTO
    {
        public TDetail ResourceDTO { get; set; }
    }

    public class OfficeSubscriptionDTO : SubscriptionDetailDTO<OfficeDTO>
    {
        
    }

    public class ServiceSubscriptionDTO : SubscriptionDetailDTO<ServiceDTO>
    {

    }

}