using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;


namespace PersonalWebsite_MVC.Controllers
{
    public class BlogListeleController : Controller
    {
        // GET: BlogListele

        PERSONALEntities db = new PERSONALEntities();

        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public ActionResult BlogSil(short id)
        {

            Blogs b = db.Blogs.FirstOrDefault(x => x.BlogId == id);

            return View(b);

        }

        [HttpPost]
        public ActionResult BlogSil(Blogs blog)
        {

            Blogs b = db.Blogs.FirstOrDefault(x => x.BlogId == blog.BlogId);
            db.Blogs.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    } 
        
}