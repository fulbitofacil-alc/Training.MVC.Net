using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class MainScheduleItem
    {
        public TimeSpan Start { get; set; }
        public String StartFormatted { get { return Start.ToString(@"hh\:mm"); } }
        public TimeSpan End { get; set; }
        public String EndFormatted { get { return Start.ToString(@"hh\:mm"); } }

        public string TimeInterval
        {
            get { return string.Format("{0} - {1}", Start.ToString(@"hh\:mm"), End.ToString(@"hh\:mm")); }
        }

        public int Index { get; set; }
    }

    public class Settings
    {
        private TimeSpan _interval;
        private TimeSpan _beginDayHour;
        private TimeSpan _endDayHour ;
        private int _totalIntervals;

        public Settings()
        {
            _beginDayHour = new TimeSpan(8, 0, 0);
            _endDayHour = new TimeSpan(22, 0, 0);
            _interval = new TimeSpan(0, 30, 0);
            _totalIntervals = (int)(_endDayHour - _beginDayHour).TotalMinutes/30;
        }

        public IEnumerable<MainScheduleItem> GetMainSchedule()
        {
            var retVal = new List<MainScheduleItem>();
            var currentInterval = _beginDayHour;
            for (var i= 0; i<= _totalIntervals; i++)
            {
                retVal.Add(new MainScheduleItem
                {
                    Index = i,
                    Start = currentInterval,
                    End = currentInterval.Add(_interval)
                });
                currentInterval = currentInterval.Add(_interval);
            }

            return retVal;
        } 
    }

    public static class ScheduleResolver
    {
        public static DateTime GetScheduleTimeFrom(DateTime bookingDate, int indexInterval)
        {
            var timeSchedule = new Settings().GetMainSchedule().ToList();
            return bookingDate + timeSchedule.FirstOrDefault(x => x.Index == indexInterval).Start;
        }
    }

}