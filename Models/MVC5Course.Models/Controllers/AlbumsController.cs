using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models.DataModel.Context;

namespace MVC5Course.Models.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/
        ChinookContext _db = new ChinookContext();
        public ActionResult Index()
        {
            var albums = _db.Albums.ToList();
            return View(albums);
        }
	}
}