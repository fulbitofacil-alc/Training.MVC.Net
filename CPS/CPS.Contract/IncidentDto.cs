using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPS.Contract
{
    public class IncidentDto
    {
        public string ProductInvolve { get; set; }
        public BranchDto Branch { get; set; }
        public DateTime StoryDate { get; set; }
        public string Story { get; set; }
    }
}
