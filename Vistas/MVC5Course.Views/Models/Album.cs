using System;
using System.Collections.Generic;

namespace MVC5Course.Views.Models
{
    public class AlbumSong
    {
        public int Track { get; set; }
        public string Title { get; set; }
    }

    public class Album
    {
        public string BandName { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public IEnumerable<AlbumSong> Songs { get; set; } 
    }
}
