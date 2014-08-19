using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MVC5Course.Models.DataModel
{
    [DebuggerDisplay("{Name} (ArtistId = {ArtistId})")]
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required, MaxLength(120)]
        public string Name { get; set; }
    }
}
