using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyDate
    {
    public static string Strdate()
    {


        DateTime d = DateTime.Now;
        PersianCalendar pc = new PersianCalendar();
        return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));

    }
    }

