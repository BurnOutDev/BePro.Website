using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Helpers
{
    public static class DateTimeHelper
    {
        public static string ToShortDateStringGeo(this DateTime dt)
        {
            switch (dt.Month)
            {
                case 1:
                    return $"{dt.Day} იანვარი";
                case 2:    
                    return $"{dt.Day} თებერვალი";
                case 3:    
                    return $"{dt.Day} მარტი";
                case 4:    
                    return $"{dt.Day} აპრილი";
                case 5:    
                    return $"{dt.Day} მაისი";
                case 6:    
                    return $"{dt.Day} ივნისი";
                case 7:    
                    return $"{dt.Day} ივლისი";
                case 8:    
                    return $"{dt.Day} აგვისტო";
                case 9:    
                    return $"{dt.Day} სექტემბერი";
                case 10:   
                    return $"{dt.Day} ოქტომბერი";
                case 11:   
                    return $"{dt.Day} ნოემბერი";
                case 12:   
                    return $"{dt.Day} დეკემბერი";
                default:   
                    return $"{dt.Day} შეცდომა";
            }
        }
    }
}