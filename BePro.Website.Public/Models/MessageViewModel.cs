using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Models
{
    public class MessageViewModel
    {
        [Display(Name="სახელი")]
        public string Name { get; set; }
        [Display(Name="ელ. ფოსტა")]
        public string Email { get; set; }
        [Display(Name="შეტყობინება")]
        public string Message { get; set; }
    }
}