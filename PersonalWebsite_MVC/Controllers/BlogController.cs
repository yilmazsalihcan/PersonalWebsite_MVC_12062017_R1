using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;
namespace PersonalWebsite_MVC.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {
            List<Blogs> blogs = db.Blogs.ToList();
            ViewBag.Blogs = blogs;
            return View(blogs);
        }
        public ActionResult KategoriyeGoreListele(short id)
        {
            //Bu kısımda sorun var. Hocaya sor. Nereye listeyi döndürecek.
            List<Blogs> blogs = db.Blogs.Where(x => x.CategoryId == id).ToList();

            return RedirectToAction("Index");
        }

       

    

	}
}