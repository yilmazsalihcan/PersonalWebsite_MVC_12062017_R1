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

           
            Session["BlogId"] = id;

            return View(blog);
        }

        [HttpPost]
        public ActionResult YorumYap(string Description)
        {
            Comments yorum = new Comments();
            yorum.Title = "Test Yorumu";
            yorum.Description = Description;
            yorum.UserId = 1;
            yorum.RegisterDate = DateTime.Now;
            yorum.BlogId =Convert.ToInt16(Session["BlogId"]);
            db.Comments.Add(yorum);
            db.SaveChanges();
            return RedirectToAction("BlogDetayBul","BlogDetay");
        }

	}
}