namespace MVC5Course.Automapper.Models.Complex
{
    public abstract class BookingDetailDTO : BaseDTO
    {
        public BookingDTO Booking { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public abstract class BookingDetailDTO<TResource> : BookingDetailDTO
    {
        public TResource ResourceDTO { get; set; }
    }

    public class OfficeBookingDTO : BookingDetailDTO<OfficeDTO>
    {
        public string OfficeName { get; set; }
        public string OfficeNameAssigned { get; set; }
    }

    public class AdditionalBookingDTO : BookingDetailDTO<AdditionalDTO>
    {
        
    }
}
