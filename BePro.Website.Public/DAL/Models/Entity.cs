using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.DAL.Models
{
    public class Entity
    {
        public DateTime DateCreated { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
    }
}