using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVC5Course.WebApi.Attributes
{
    public class MemberRangeAttribute : RangeAttribute
    {
        public MemberRangeAttribute(int minimum, int maximum) : base(minimum, maximum) { }
        public override bool IsValid(object value)
        {
            if (value is ICollection)
            {
                var items = (ICollection)value;
                return items.Cast<int>().All(i => IsValid(i));
            }
            else
            {
                return base.IsValid(value);
            }
        }
    }
}