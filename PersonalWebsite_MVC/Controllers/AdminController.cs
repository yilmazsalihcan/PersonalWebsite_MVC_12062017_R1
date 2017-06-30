using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;

namespace PersonalWebsite_MVC.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        PERSONALEntities db = new PERSONALEntities();
       
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        [HttpPost]
        public ActionResult BlogEkle(Blogs blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

       

       



	}
}