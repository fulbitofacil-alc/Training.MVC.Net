using CPS.WebApi.Models;

namespace CPS.WebApi.Bll
{
    public interface  IIssueBll<TIssue> where TIssue:IssueDto
    {
        TIssue Save(TIssue issue);
    }

    public class CommonIssueBll : IIssueBll<CommonIssueDto>
    {
        public CommonIssueDto Save(CommonIssueDto issue)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TechnicalIssueBll : IIssueBll<TechnicalIssueDto>
    {
        public TechnicalIssueDto Save(TechnicalIssueDto issue)
        {
            throw new System.NotImplementedException();
        }
    }
  
}