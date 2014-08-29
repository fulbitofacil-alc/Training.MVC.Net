using System;
using System.Collections.Generic;
using System.Globalization;

namespace MVC5Course.Automapper.Models.Complex
{
    public class BillingPeriodDTO : BaseDTO
    {
        public string Period {
            get
            {
                return string.Format("{0}{1}", this.Year,
                    this.Month.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0'));
            }
        }
        public int Month { get; set; }
        public int Year { get; set; }
        public IList<BillingDTO> Billings { get; set; }
        public DateTime CreatedOn { get; set; }
        public Boolean IsSubmitted  { get; set; }
    }

    public class BillingDTO : BaseDTO
    {
        public BillingPeriodDTO BillingPeriod { get; set; }
        public ClientDTO Client { get; set; }
        public DateTime Expiration { get; set; }
        public bool IsCancelled { get; set; }
        public decimal Amount { get; set; }
        public DateTime CancelledOn { get; set; }
        public IList<BookingDTO> Bookings { get; set; }
    }
}