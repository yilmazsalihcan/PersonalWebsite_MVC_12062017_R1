using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite_MVC.Models;

namespace PersonalWebsite_MVC.Controllers
{
    public class AddUserController : Controller
    {
        //
        // GET: /AddUser/
        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult KullaniciDuzenle(short id)
        {
            Users kullanici = db.Users.FirstOrDefault(x => x.UserId == id);

            return View(kullanici);
        }

        public ActionResult KullaniciEkle()
        {

            return View();
        }
	}
}