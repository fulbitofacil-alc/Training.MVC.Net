namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class OfficeBooking
    {
        public virtual Booking Booking { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal Price { get; protected internal set; }
        public virtual int OfficeId { get; set; }
        public virtual string OfficeName { get; set; }
        public virtual string OfficeNameAssigned { get; set; }
        public virtual double HoursToCharge { get; protected internal set; }
        public void CalculatePrice(decimal discountSuscription, decimal priceSuscription, double bookingFreeHours)
        {
            HoursToCharge = (Booking.TotalHoursInMinutes() - bookingFreeHours) > 0 ? (Booking.TotalHoursInMinutes() - bookingFreeHours) : 0;

            Price = (priceSuscription / 60) * (1 - discountSuscription / 100) * Quantity * (decimal)HoursToCharge;
        }
    }
}