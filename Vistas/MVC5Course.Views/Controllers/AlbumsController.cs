using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MVC5Course.Views.Models;

namespace MVC5Course.Views.Controllers
{
    public class AlbumsController : Controller
    {
       public ActionResult AlbumList()
        {
            var albums = PinkFloydAlbum();
            return View(albums);
        }

        private Album PinkFloydAlbum()
        {
            var album = new Album
            {
                Title = "Wish You Were Here",
                BandName = "Pink Floyd",
                Released = new DateTime(1975, 9, 15)
            };
            var songs = new List<AlbumSong>
            {
                new AlbumSong {Title = "Shine On You Crazy Diamond", Track = 1},
                new AlbumSong {Title = "Welcome to the Machine", Track = 2},
                new AlbumSong {Title = "Have a Cigar", Track = 3},
                new AlbumSong {Title = "Wish You Were Here", Track = 4},
                new AlbumSong {Title = "Shine On You Crazy Diamond", Track = 5}
            };
            album.Songs = songs;
            return album;
        }
    }
}
