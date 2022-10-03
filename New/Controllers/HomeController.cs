using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

          public ActionResult Services()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Careers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Downloads()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult webApplications()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult desktopApplications()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult androidApplications()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult digitalSolutions()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult graphicDesigning()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult digitalMarketing()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }








    }
}