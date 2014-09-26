using System.Data.Common;

namespace CPS.WebApi.Models
{
    public abstract class Issue
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}