namespace CPS.WebApi.Models
{
    public class TechnicalIssueDto : IssueDto
    {
        public TechnicalIssueDto()
        {
            BindingType = "TechnicalIssueDto";
        }
        public string ProjectDescription { get; set; }
        public string Module { get; set; }
        public string ServiceName { get; set; }
    }

    public class CommonIssueDto : IssueDto
    {
        public CommonIssueDto()
        {
            BindingType = "CommonIssueDto";
        }
        public string Location { get; set; }
        public string Owner { get; set; }
    }

}