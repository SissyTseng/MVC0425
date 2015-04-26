using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        // GET: AF
        public ActionResult Index()
        {
            return View();
        }
        [HandleError(ExceptionType=typeof(ArgumentException),Master="",View="Error.Arg")]
        public ActionResult NG(string type="")
        {
            if (type == "1")
                throw new ArgumentException("arg error");
            else
                    throw new Exception("ERRorrrrrrrrrr");
           return View();
        }
    }
}