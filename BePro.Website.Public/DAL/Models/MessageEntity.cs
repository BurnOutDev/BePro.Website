using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.DAL.Models
{
    public class MessageEntity : Entity
    {
        [Key]
        public long MessageID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
