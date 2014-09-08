using System;
using System.Collections.Generic;

namespace CPS.Contract
{
    public class ClaimDto : BaseDto
    {
        public DateTime RecordDate { get; set; }
        public DateTime NotifyDate { get; set; }
        public AddressDto NotifyAddress { get; set; }
        public ClientDto Client { get; set; }
        public IncidentDto Incident { get; set; }
        public BranchDto ClaimBranch { get; set; }
        public WorkflowDto Workflow { get; set; }
        public Boolean ToFavorOfCustomer { get; set; }
        public DateTime ExpectedDate { get; set; }
         
    }
}