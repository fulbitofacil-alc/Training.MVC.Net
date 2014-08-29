using System;
using System.Collections.Generic;

namespace MVC5Course.Automapper.Models.Complex
{
    public class BookingDTO : BaseDTO
    {
        public ClientDTO Client { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<BookingDetailDTO> Detail { get; set; }
        public bool IsActive { get; set; }
        public decimal Total { get; set; }
        public bool WasUsed { get; set; }
        public BranchDTO Branch { get; set; }
        public string Status { get; set; }
        public string OfficeBookedName { get; set; }
        public bool IsEditable { get; set; }
        
    }
}
