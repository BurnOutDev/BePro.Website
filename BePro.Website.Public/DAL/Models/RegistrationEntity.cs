using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.DAL.Models
{
    public class RegistrationEntity : Entity
    {
        [Key]
        public long EntityID { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string PrivateNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }

        public string Work { get; set; }
        public string WorkCompany { get; set; }
        public string WorkPosition { get; set; }

        public byte[] DocumentFile { get; set; }
        public string DocumentExtension { get; set; }

        public string Course { get; set; }
        public string CourseDates { get; set; }

        public string Message { get; set; }
    }
}