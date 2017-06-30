using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;
namespace PersonalWebsite_MVC.Controllers
{
    public class AddBlogController : Controller
    {
        // GET: AddBlog
        
        PERSONALEntities db = new PERSONALEntities();

        [HttpPost]
        public ActionResult Index(Blogs blog)
        {

            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("BlogListele","Index");
        }
    }
}