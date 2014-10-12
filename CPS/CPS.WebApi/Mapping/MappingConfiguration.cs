using AutoMapper;
using CPS.WebApi.Models;

namespace CPS.WebApi.Mapping
{
    public class MappingConfiguration
    {
        public static  void Mappings()
        {
            Mapper.CreateMap<IssueDto, Issue>()
                .Include<TechnicalIssueDto, TechnicalIssue>()
                .Include<CommonIssueDto, CommonIssue>();
        }
    }
}