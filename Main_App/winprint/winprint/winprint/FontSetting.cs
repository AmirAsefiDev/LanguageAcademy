using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winprint
{
   public  class FontSetting
    {
        public static void SaveFontToText(Font InputFont)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(System.Drawing.Font));
            // Saving Font object as a string
            string fontString = converter.ConvertToString(InputFont);

            // Compose a string that consists of three lines.

            System.IO.StreamWriter file = new System.IO.StreamWriter("FontSetting.txt");
            file.WriteLine(fontString);

            file.Close();

        }

        public static void RemoveFont()
        {
            if (System.IO.File.Exists("FontSetting.txt"))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                System.IO.File.Delete("FontSetting.txt");
            }
        }
        public static Font ReadFontFromText()
        {

            System.IO.StreamReader file = new System.IO.StreamReader("FontSetting.txt");

            string fontString = file.ReadLine();
            file.Close();
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(System.Drawing.Font));
            Font font = (Font)converter.ConvertFromString(fontString);

            return font;
        }
    }
}
