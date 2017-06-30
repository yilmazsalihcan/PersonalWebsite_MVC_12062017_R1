using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;

namespace PersonalWebsite_MVC.Controllers
{
    public class KategoriListeleController : Controller
    {
        //
        // GET: /KategoriListele/
        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {

            return View(db.Categories.ToList());
        }

        public ActionResult KategoriSil(short id)
        {
            Categories kat=db.Categories.FirstOrDefault(x => x.CategoryId == id);
           
            return View(kat);
        }

        [HttpPost]
        public ActionResult KategoriSil(Categories cat)
        {
            Categories kategori = db.Categories.FirstOrDefault(x => x.CategoryId == cat.CategoryId);
            db.Categories.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}