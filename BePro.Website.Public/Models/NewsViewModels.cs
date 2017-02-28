using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Models
{
    public class NewsListItemViewModel
    {
        public long NewsID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}