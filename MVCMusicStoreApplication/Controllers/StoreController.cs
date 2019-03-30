using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store/Index/4
        public ActionResult Index(int id)
        {
            var albums = db.Albums.Where(a => a.GenreId.Equals(id));
            return View(albums.ToList());
        }

        //GET: Store/Browse
        public ActionResult Browse()
        {
            return View(db.Genres.ToList());
        }

        //GET: Store/Details/3
        public ActionResult Details(int id)
        {
            Album details = db.Albums.Find(id);
            return View(details);
        }
        
    }
}