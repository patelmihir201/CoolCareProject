using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoolCare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserSignUp()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult UserLogin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult BookService()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult TechWorkDoneReport()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    
    }
}