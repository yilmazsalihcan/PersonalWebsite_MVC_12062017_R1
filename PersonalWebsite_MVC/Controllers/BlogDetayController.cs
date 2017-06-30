using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;
namespace PersonalWebsite_MVC.Controllers
{

       
    public class BlogDetayController : Controller
    {
        //
        // GET: /BlogDetay/
        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult BlogDetayBul(short id)
        {
            Blogs blog = db.Blogs.FirstOrDefault(x => x.BlogId == id);

            return View(blog);
        }
	}
}