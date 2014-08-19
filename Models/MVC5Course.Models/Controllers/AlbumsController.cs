
using System.Linq;

using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MVC5Course.Models.DataModel;
using MVC5Course.Models.DataModel.Context;
using MVC5Course.Models.Models;

namespace MVC5Course.Models.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/
        ChinookContext _db = new ChinookContext();
        public ActionResult Index()
        {
            var albums = _db.Artists.ToList();
            return View(albums);
        }

        public ActionResult MusicBy(Artist artist )
        {
            var songs = (from track in _db.PlaylistTracks
                where track.Track.Album.ArtistId == artist.ArtistId
                orderby track.Track.AlbumId
                select new MusicByArtist
                { 
                    Artist = track.Track.Album.Artist.Name,
                    Album =  track.Track.Album.Title,
                    Genre = track.Track.Genre.Name,
                    Title = track.Track.Name,
                    Track = track.Track.TrackId
                }).DistinctBy(x=>x.Title);

            return View(songs);
        }
	}
}