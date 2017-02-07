using BePro.Website.Public.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BePro.Website.Public.Controllers
{
    public class AdminController : Controller
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

        public ActionResult Registrations()
        {
            return View(Context.RegistrationEntities.AsNoTracking().ToList());
        }

        public FileResult DownloadCV(int regId)
        {
            var entity = Context.RegistrationEntities.FirstOrDefault(x => x.EntityID == regId);
            return File(entity.DocumentFile, "application/pdf");
        }
    }
}