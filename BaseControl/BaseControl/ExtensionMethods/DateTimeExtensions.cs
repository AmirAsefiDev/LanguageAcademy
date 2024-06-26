﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BaseControl.ExtensionMethods
{
    public static class DateTimeExtensions
    {  
        public static DateTime? ConvertToDate(this string input)
        {
            try
            {
                var startDateYear = input.Split('/')[0];
                var startDateMonth = input.Split('/')[1];
                var startDateDay = input.Split('/')[2];
                return new DateTime(int.Parse(startDateYear), int.Parse(startDateMonth), int.Parse(startDateDay),
                    new System.Globalization.PersianCalendar());
            }
            catch(Exception)
            {
                return null;
                throw;
            }

        }
    }
}
