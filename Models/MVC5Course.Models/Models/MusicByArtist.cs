using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVC5Course.Models.Resources;

namespace MVC5Course.Models.Models
{
    public class MusicByArtist
    {
        [Display(Name = "resArtistName",ResourceType = typeof(MusicResource))]
        public String Artist { get; set; }
        public String Album { get; set; }
        public int Track { get; set; }
        public String Title { get; set; }
        public String Genre { get; set; }
    }


}