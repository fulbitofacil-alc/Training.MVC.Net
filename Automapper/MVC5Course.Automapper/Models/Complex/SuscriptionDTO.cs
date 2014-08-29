using System;

namespace MVC5Course.Automapper.Models.Complex
{
    public class SuscriptionDTO : BaseDTO
    {
        public ClientDTO Client { get; set; }
        public bool IsActive { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Months { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Warranty { get; set; }
        //public IList<SuscriptionDetailDTO> SuscriptionDetail { get; set; }

    }
}