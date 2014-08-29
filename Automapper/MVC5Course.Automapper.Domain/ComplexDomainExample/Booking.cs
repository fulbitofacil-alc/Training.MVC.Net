using System;
using System.Collections.Generic;
using System.Linq;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class Booking :Entity
    {
        public Booking()
        {
            Detail = new List<BookingDetail>();
        }

        public virtual Client Client { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual IList<BookingDetail> Detail { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual bool WasUsed { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual OfficeBooking OfficeBooking { get; set; }


        public virtual void AddDetail(BookingDetail bookingDetail)
        {
            bookingDetail.Booking = this;
            Detail.Add(bookingDetail);
        }

        public virtual decimal Total()
        {
            return Detail.Sum(bookingDetail => bookingDetail.Price);
        }

        public virtual double  TotalHoursInMinutes()
        {
            return (EndDate - StartDate).TotalMinutes;
        }

        public virtual bool IsInInterval(double minutes)
        {

            var queryHour = Date.AddMinutes(minutes);

            return (TimeSpan.Compare(StartDate.TimeOfDay, queryHour.TimeOfDay) <= 0 &&
                    TimeSpan.Compare(EndDate.AddHours(-1).TimeOfDay, queryHour.TimeOfDay) >= 0);

        }

        public virtual string Status()
        {
            if (this.WasUsed) return "Arrendada";
            return this.IsActive ? "Reservada" : "Anulada";
        }


        public virtual bool CouldBeCancelled()
        {
            var today = DateTime.Now;
            return (this.Date - today).TotalDays > 1; // TODO parameter
        }
    }
}