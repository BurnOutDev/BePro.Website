using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BePro.Website.Public.Models;

namespace BePro.Website.Public.Controllers
{
    public class PricingController : Controller
    {
        public ActionResult Index()
        {
            var courses = TopCoursesViewModel.Create(
                new CourseViewModel()
                {
                    AuthorName = "ნიკოლოზ კანდელაკი",
                    CurrencyChar = '₾',
                    IconUrl = "../../img/courses/course1.png",
                    Name = "ფინანსური ანალიზი",
                    Price = 550,
                    StartDate = DateTime.Today.AddDays(35)
                },
                new CourseViewModel()
                {
                    AuthorName = "ნინი საჩალელი",
                    CurrencyChar = '₾',
                    IconUrl = "../../img/courses/course2.png",
                    Name = "საბანკო პროგრამები",
                    Price = 400,
                    StartDate = DateTime.Today.AddDays(42)
                },
                new CourseViewModel()
                {
                    AuthorName = " კახა ჯაჯანაშვილი",
                    CurrencyChar = '₾',
                    IconUrl = "../../img/courses/course3.png",
                    Name = "რისკების მენეჯმენტი",
                    Price = 450,
                    StartDate = DateTime.Today.AddDays(27)
                },
                new CourseViewModel()
                {
                    AuthorName = "ზურა რუსია",
                    CurrencyChar = '₾',
                    IconUrl = "../../img/courses/course4.png",
                    Name = "იპოთეკა და ბანკი",
                    Price = 450,
                    StartDate = DateTime.Today.AddDays(51)
                });

            return View(courses);
        }
    }
}
