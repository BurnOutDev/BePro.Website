using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [MaxLength(11), MinLength(11), RegularExpression("^[0-9]*$")]
        public string PrivateNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Education { get; set; }

        [Required]
        public string Work { get; set; }

        public string WorkCompany { get; set; }

        public string WorkPosition { get; set; }

        [Required]
        public HttpPostedFileBase DocumentFile { get; set; }

        [Required]
        public string Course { get; set; }
        [Required]
        public string CourseDates { get; set; }

        public byte[] Captcha { get; set; }

        [Required]
        public string CaptchaInput { get; set; }

        public string Message { get; set; }
    }
}