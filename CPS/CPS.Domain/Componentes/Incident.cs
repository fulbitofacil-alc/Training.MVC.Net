using System;

namespace CPS.Domain.Componentes
{
    public class Incident
    {
        public string ProductInvolve { get; set; }
        public Branch Branch { get; set; }
        public DateTime StoryDate { get; set; }
        public string Story { get; set; }
    }
}
