using System;
using CPS.WebApi.JsonHelpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CPS.WebApi.Models
{
    [JsonConverter(typeof (IssueConverter))]
    public abstract class IssueDto
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string TypeName
        {
            get { return this.GetType().Name; }
        }

        private class IssueConverter : JsonAbstractCreationConverter<IssueDto>
        {
            protected override IssueDto Create(Type objectType, JObject jObject)
            {
                var typeName = jObject.Value<string>("BindingType");
                switch (typeName)
                {
                    case "CommonIssueDto":
                        return new CommonIssueDto();
                    case "TechnicalIssueDto":
                        return new TechnicalIssueDto();
                    default:
                        return null;
                }

            }
        }
    }
}