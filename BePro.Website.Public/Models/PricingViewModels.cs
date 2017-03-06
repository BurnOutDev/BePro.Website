using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Models
{
    public class TopCoursesViewModel
    {
        private TopCoursesViewModel() { }

        public static TopCoursesViewModel Create(CourseViewModel course1, CourseViewModel course2, CourseViewModel course3, CourseViewModel course4)
        {
            var result = new TopCoursesViewModel();

            result.Course1 = course1;
            result.Course2 = course2;
            result.Course3 = course3;
            result.Course4 = course4;

            return result;
        }

        public CourseViewModel Course1 { get; set; }
        public CourseViewModel Course2 { get; set; }
        public CourseViewModel Course3 { get; set; }
        public CourseViewModel Course4 { get; set; }
    }

    public class CourseViewModel
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public DateTime StartDate { get; set; }
        public int Price { get; set; }
        public char CurrencyChar { get; set; }
        public string IconUrl { get; set; }
    }
}