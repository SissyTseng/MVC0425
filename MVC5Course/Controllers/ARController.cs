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
    }
}