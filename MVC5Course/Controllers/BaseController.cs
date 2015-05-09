using MVC5Course.ActionFilters;
using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{

    [Logger]
    public abstract class BaseController : Controller
    {
        protected FabricsEntities db = new FabricsEntities();

        protected ClientRepository repoClient = RepositoryHelper.GetClientRepository();

 #if DEBUG
         public ActionResult Debug()
        {
             return View();
         }
 #endif
    }
}