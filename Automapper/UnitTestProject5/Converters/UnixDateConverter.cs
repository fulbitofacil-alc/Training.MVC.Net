using System;
using AutoMapper;

namespace UnitTestProject5.Converters
{
    public class UnixDateConverter : ITypeConverter<double, DateTime>
    {
        public DateTime Convert(ResolutionContext context)
        {
            var source = (double) context.SourceValue;
            var unixEpoch = new DateTime(1970, 1, 1).ToLocalTime();
            var localDate = unixEpoch.AddSeconds(source).ToLocalTime();
            return localDate;
        }
    }
}