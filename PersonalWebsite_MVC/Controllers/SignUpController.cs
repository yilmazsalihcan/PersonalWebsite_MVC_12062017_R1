using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;

namespace PersonalWebsite_MVC.Controllers
{
    public class SignUpController : Controller
    {
        //
        // GET: /SignUp/
        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {        
            return View();
        }

        
        [HttpPost]
        public ActionResult KayitOl(Users u)
        {
            UserDetails udetail = new UserDetails();
            u.RegisterDate = DateTime.Now;
            u.UserDetails = udetail;
            db.Users.Add(u);
            db.SaveChanges();
            ViewBag.Sonuc = "Başarılı bir şekilde kayıt oldunuz";
            return RedirectToAction("Index");
        }


	}
}