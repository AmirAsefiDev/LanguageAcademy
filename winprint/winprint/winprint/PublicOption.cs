using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winprint
{
    class PublicOption
    {
        public static string GetPertionDate()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            return  pc.GetDayOfMonth(DateTime.Now)+"/"+ pc.GetMonth(DateTime.Now) + " / "+pc.GetYear(DateTime.Now) ;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
