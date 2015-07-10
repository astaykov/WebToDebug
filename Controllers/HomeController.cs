using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebToDebug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = System.Configuration.ConfigurationManager.AppSettings["T"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            System.Diagnostics.Trace.TraceWarning("Application is about to crash!");
            throw new ApplicationException("I just crashed");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}