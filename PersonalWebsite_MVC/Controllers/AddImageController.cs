using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PersonalWebsite_MVC.Models;

namespace PersonalWebsite_MVC.Controllers
{
    public class AddImageController : Controller
    {
        //
        // GET: /AddImage/
        PERSONALEntities db = new PERSONALEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
         
        public ActionResult AddImage(HttpPostedFileBase uploadFile)
        {
            Images image = new Images();

           
             //   string physicalPath = Server.MapPath("~/Content/admin/uploadimage/");
                var fileName = Path.GetFileName(uploadFile.FileName);
             //   var path = Path.Combine(Server.MapPath("~/Content/admin/uploadimage"),User.Identity.Name, fileName);
                var path = Path.Combine(Server.MapPath("~/Content/admin/uploadimage"),fileName);
                uploadFile.SaveAs(path);
                image.ImageURL = path;
                db.Images.Add(image);
                db.SaveChanges();
                ViewBag.Sonuc = "Kayıt Başarılı";
         
            return RedirectToAction("Index");
        }
	}
}