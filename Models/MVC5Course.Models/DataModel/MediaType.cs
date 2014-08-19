using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MVC5Course.Models.DataModel
{
    [DebuggerDisplay("{Name} (MediaTypeId = {MediaTypeId})")]
    public class MediaType
    {
        [Key]
        public int MediaTypeId { get; set; }

        [MaxLength(120)]
        public string Name { get; set; }
    }
}
