using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MVC5Course.Models.DataModel
{
    [DebuggerDisplay("{Title} (AlbumId = {AlbumId})")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required, MaxLength(160)]
        public string Title { get; set; }

        [Required]
        public int ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
    }
}