using System.Collections.Generic;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class RateHeader : Entity
    {
        public RateHeader()
        {
           RateDetail = new List<RateDetail>(); 
        }
        public virtual int Range { get; set; }
        public virtual Office Office { get; set; }
        public virtual bool IsEnabled { get; set; }
        public virtual IList<RateDetail> RateDetail { get; set; }

        public virtual void AddDetail(RateDetail detail)
        {
            detail.RateHeader = this;
            RateDetail.Add(detail);
        }

    }

    //public abstract class RateHeader<TDetail> : RateHeader
    //{
    //    private IList<TDetail> ratesByRange;

    //    protected RateHeader()
    //    {
    //        ratesByRange = new List<TDetail>();
    //    }

    //    public virtual IEnumerable<TDetail> RatesByRange
    //    {
    //        get { return ratesByRange; }
    //    }

    //    public virtual TDetail AddDetail()
    //    {
    //        TDetail result = CreateNewDetail();
    //        ratesByRange.Add(result);
    //        return result;
    //    }

    //    protected abstract TDetail CreateNewDetail();

    //    public virtual void RemoveDetail(TDetail detail)
    //    {
    //        ratesByRange.Remove(detail);
    //        ResetParent(detail);
    //    }

    //    protected abstract void ResetParent(TDetail detail);
    //}
}