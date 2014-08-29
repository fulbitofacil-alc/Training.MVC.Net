using System;

namespace MVC5Course.Automapper.Models.Complex
{
    public class BalanceDTO
    {
        public int BalanceId { get; set; }
        public string Period { get; set; }
        public DateTime BillingDate { get; set; }
        public bool Cancelled { get; set; }
        public int DaysInDefault { get; set; }
    }
}