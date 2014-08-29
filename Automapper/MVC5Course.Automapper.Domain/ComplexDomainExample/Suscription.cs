using System;
using System.Collections.Generic;
using System.Linq;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class Suscription : Entity
    {
        public Suscription()
        {
            SuscriptionDetail = new List<SuscriptionDetail>();
        }
        public virtual Client Client { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime BeginDate { get; set; }
        public virtual DateTime BillingDate { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
        public virtual int Months { get; set; }
        public virtual IList<SuscriptionDetail> SuscriptionDetail { get; set; }
        public virtual decimal Warranty { get; set; }
        public virtual decimal Subtotal
        {
            get { return SuscriptionDetail.Sum(x => x.Total())*Months; }
        }

        public virtual void Activate()
        {
            IsActive = true;
            ExpirationDate = BeginDate.AddMonths(Months);
        }

        public virtual void AddDetail(SuscriptionDetail detail)
        {
            detail.Suscription = this;
            SuscriptionDetail.Add(detail);
        }

        public virtual DateTime GetBeginDateForCurrentPeriod(DateTime bookingDate)
        {
            var begindate = BeginDate;
            var endDate = BillingDate;
            for (int i = 1; i < Months; i++)
            {
                if (bookingDate >= begindate && bookingDate <= endDate) return begindate;
                begindate = endDate.AddDays(1);
                endDate = begindate.GetLastDayOfMonth();
            }
            return begindate;
        }
        public virtual DateTime GetEndDateForCurrentPeriod(DateTime bookingDate)
        {
            var begindate = BeginDate;
            var endDate = BillingDate;
            for (int i = 1; i < Months; i++)
            {
                if (bookingDate >= begindate && bookingDate <= endDate) return endDate;
                begindate = endDate.AddDays(1);
                endDate = begindate.GetLastDayOfMonth();
            }
            return endDate;

        }
    }
}