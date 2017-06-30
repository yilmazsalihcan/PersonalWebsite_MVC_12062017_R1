using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;
namespace PersonalWebsite_MVC.Controllers
{
   
    public class AddCategoryController : Controller
    {
        //
        // GET: /AddCategory/
        PERSONALEntities db = new PERSONALEntities();
     
        
        public ActionResult Index()
        {


            return View();
        }

        [HttpPost]
        public ActionResult CategoryEkle(Categories cat)
        {
            db.Categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}