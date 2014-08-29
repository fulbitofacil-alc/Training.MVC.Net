using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public abstract class BookingDetail : Entity
    {
        public virtual Booking Booking { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal Price { get; protected internal set; }
        public abstract void CalculatePrice(decimal discountSuscription, decimal priceSuscription, double bookingFreeHours);
    }

    public abstract class BookingDetail<TResource> : BookingDetail
    {
        public virtual TResource Resource { get; set; }
    }

    //public class OfficeBooking : BookingDetail<Office>
    //{
    //    public virtual string OfficeName { get; set; }
    //    public virtual string OfficeNameAssigned { get; set; }
    //    public virtual double HoursToCharge { get; protected internal set; }
    //    public override void CalculatePrice(decimal discountSuscription, decimal priceSuscription, double bookingFreeHours)
    //    {
    //        HoursToCharge = (Booking.TotalHoursInMinutes() - bookingFreeHours) > 0 ? (Booking.TotalHoursInMinutes() - bookingFreeHours) : 0;

    //        Price = (priceSuscription / 60) * (1 - discountSuscription / 100) * Quantity * (decimal)HoursToCharge;
    //    }
    //}

    public class AdditionalBooking : BookingDetail<Additional>
    {

        public override void CalculatePrice(decimal discountSuscription, decimal priceSuscription, double bookingFreeHours)
        {
            Price = Resource.Price * Quantity;
        }
    }
}
