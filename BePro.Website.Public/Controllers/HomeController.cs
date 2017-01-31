using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BePro.Website.Public.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Prices()
        {
            return View();
        }

        public ActionResult Come()
        {
            return View();
        }

        public ActionResult Corporate()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Open()
        {
            return View();
        }

        public ActionResult Price()
        {
            return View();
        }
    }
}