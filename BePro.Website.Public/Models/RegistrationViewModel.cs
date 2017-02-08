using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "ველი სავალდებულოა")]
        [Display(Name = "სახელი")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        [MaxLength(11, ErrorMessage = "უნდა იყოს 11 სიმბოლო"), MinLength(11, ErrorMessage = "უნდა იყოს 11 სიმბოლო"), RegularExpression("^[0-9]*$", ErrorMessage = "უნდა შეიცავდეს მხოლოდ ციფრებს")]
        public string PrivateNumber { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        public string Education { get; set; }
        
        public string WorkCompany { get; set; }

        public string WorkPosition { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        public HttpPostedFileBase DocumentFile { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        public string Course { get; set; }

        public string Message { get; set; }
    }
}