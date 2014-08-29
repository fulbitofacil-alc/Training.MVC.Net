using System;
using System.Collections.Generic;

namespace MVC5Course.Automapper.Models.Complex
{
    public class AvailableOfficesDTO
    {
        public string OfficeName { get; set; }
        public IList<OfficeScheduleDTO> Schedule {get; set; }
    }

    public class OfficeScheduleDTO
    {
        public int Schedule { get; set; }
        public bool IsBooked { get; set; }
    }

    public class BookingScheduleItemDTO
    {
        // TODO: Change office command (changes booked office name)...
        // TODO: Extend schedule command (extends booked schedule)...
        // TODO: Edit booking command (edits booking, only manager)...
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public int BookingId { get; set; }
        public bool CheckedIn { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
    }

    public class BookingScheduleByRoomDTO
    {
        public string RoomName { get; set; }
        public IEnumerable<BookingScheduleItemDTO> BookingSchedule { get; set; }
    }
}