using CPS.WebApi.Models;

namespace CPS.WebApi.Bll
{
    public interface  IIssueBll<TIssue> where TIssue:Issue
    {
        TIssue Save(TIssue issue);
    }

    public class CommonIssueBll : IIssueBll<CommonIssue>
    {
        public CommonIssue Save(CommonIssue issue)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TechnicalIssueBll : IIssueBll<TechnicalIssue>
    {
        public TechnicalIssue Save(TechnicalIssue issue)
        {
            throw new System.NotImplementedException();
        }
    }
  
}