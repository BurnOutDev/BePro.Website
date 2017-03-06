using BePro.Website.Public.DAL;
using BePro.Website.Public.DAL.Models;
using BePro.Website.Public.Models;
using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BePro.Website.Public.Controllers
{
    public class HomeController : Controller
    {
        private CommonContext _context;
        public CommonContext Context
        {
            get
            {
                if (_context == null)
                    _context = new CommonContext();
                return _context;
            }
        }

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
            if (ModelState.IsValid && this.IsCaptchaValid("არასწორია"))
            {
                var entity = new RegistrationEntity()
                {
                    BirthDate = model.BirthDate.Value,
                    Course = model.Course,
                    DocumentExtension = Path.GetExtension(model.DocumentFile.FileName),
                    DocumentFile = new BinaryReader(model.DocumentFile.InputStream).ReadBytes(model.DocumentFile.ContentLength),
                    Education = model.Education,
                    Email = model.Email,
                    LastName = model.LastName,
                    Message = model.Message,
                    MobileNumber = model.MobileNumber,
                    FirstName = model.FirstName,
                    PrivateNumber = model.PrivateNumber,
                    WorkCompany = model.WorkCompany,
                    WorkPosition = model.WorkPosition,
                    DateCreated = DateTime.UtcNow,
                    UserAgent = Request.UserAgent,
                    IPAddress = Request.UserHostAddress
                };

                Context.RegistrationEntities.Add(entity);
                Context.SaveChanges();

                return RedirectToAction("SuccessRedirect");
            }

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
            Context.MessageEntities.Add(new MessageEntity()
            {
                DateCreated = DateTime.Now,
                Email = model.Email,
                IPAddress = Request.UserHostAddress,
                Message = model.Message,
                Name = model.Name,
                UserAgent = Request.UserAgent
            });

            Context.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public FileResult DownloadCVForm()
        {
            return File(Server.MapPath("~/App_Data/CV_Form.docx"), "application/force-download", "BePro_CV_Form.docx");
        }
    }
}