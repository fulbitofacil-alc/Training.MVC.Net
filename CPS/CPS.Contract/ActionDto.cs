using System;
using System.Collections.Generic;

namespace CPS.Contract
{
    public class ActionDto
    {
        public ClaimDto Claim { get; set; }
        public string Description { get; set; }
        public DateTime RecordDate { get; set; }
        public IList<DocumentDto> Documents { get; set; } 
    }
}