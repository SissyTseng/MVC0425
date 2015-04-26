using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {
            return View("View1");
        }

        public ActionResult View1()
        {
            return View();
        }

        public ActionResult View2()
        {
            return PartialView();
        }

        public string Content1()
        {
            return "Disallow: /";
        }

        public ActionResult File1()
        {
            var wc = new WebClient();
            var content = wc.DownloadData("http://static.ettoday.net/images/5/d5975.jpg");
            return File(content, "image/jpg","Img1.jpg");
        }


        public ActionResult File3(string url)
        {
            var wc = new WebClient();
            var content = wc.DownloadData(url);

            return File(content, "image/png");
        }

        public ActionResult File4()
        {
            return File(Server.MapPath("~/Content/File1.html"), "text/html");
        }

        public ActionResult File5()
        {
            byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/Img1.jpg"));

            return File(content, "image/jpg", "File5.png");
        }
        public ActionResult Json1()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var data = db.Product.Take(10);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Redirect1()
        {
            //return Redirect("");
            return RedirectToAction("File3",new { url = "http://pixelbuddha.net/sites/default/files/freebie-slide/freebie-slide-1426497148-1.jpg" }); 
        }

        public ActionResult Redirect2()
        {
            return RedirectToActionPermanent("File3", new { url = "http://pixelbuddha.net/sites/default/files/freebie-slide/freebie-slide-1426497148-1.jpg" });
        }


        public ActionResult HttpNotFound1()
        {
            return HttpNotFound();
        }

        public ActionResult HttpStatusCodeResult1()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        public ActionResult HttpStatusCodeResult2()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Created);
        }

    }
}