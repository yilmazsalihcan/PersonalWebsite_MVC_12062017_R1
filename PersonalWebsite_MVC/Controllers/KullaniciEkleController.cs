using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;

namespace PersonalWebsite_MVC.Controllers
{
    public class KullaniciEkleController : Controller
    {
        //
        // GET: /KullaniciEkle/
        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult KullaniciEkle(Users u)
        {
            u.RegisterDate = DateTime.Now;
            db.Users.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult KullaniciDuzenle(Users u,short id)
        {

            var yeniad = u.Name;
            var yenikAdi = u.Username;
            var yeniPassword = u.Password;
            var eskideger = db.Users.FirstOrDefault(x => x.UserId == id);
            eskideger.Name = yeniad;
            eskideger.Username = yenikAdi;
            eskideger.Password = yeniPassword;
            db.SaveChanges();
            ViewBag.Sonuc = "Değiştirme işlemi başarılı";


            return RedirectToAction("Index","Adduser");
        }

	}
}