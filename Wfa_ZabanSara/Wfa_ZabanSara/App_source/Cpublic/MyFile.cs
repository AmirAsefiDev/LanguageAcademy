using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wfa_ZabanSara.App_source.Cpublic
{
    public class MyFile
    {
        public static void CopyFile(string StrPath1,string StrPath2)
        {
            if (File.Exists(StrPath2))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(StrPath2);
            }
            File.Copy(StrPath1, StrPath2);

        }
        public static void DeleteFile(string StrPath1)
        {
            if(File.Exists(StrPath1))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(StrPath1);
            }
        }
    }
}
