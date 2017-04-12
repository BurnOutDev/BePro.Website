using BePro.Website.Public.Models;
using System.Net;
using System.Web.Mvc;

namespace BePro.Website.Public.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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

        public ActionResult Open()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationViewModel model)
        {
            return View(model);
        }

        public ActionResult SuccessRedirect()
        {
            return Redirect("http://bepro.com.ge");
        }

        public ActionResult RegistrationView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationView(RegistrationViewModel model)
        {
            return View();
        }

        [HttpPost]
        public HttpStatusCodeResult SendMessage(MessageViewModel model)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}