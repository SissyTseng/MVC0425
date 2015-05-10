﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public string GetTime()
        {
            return DateTime.Now.ToString(); 
        }

        public JsonResult GetJson()
        {
            return Json(new  { result = "OK" });
        }
    }
}