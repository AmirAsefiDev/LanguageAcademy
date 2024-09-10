using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Wfa_UserAccount.App_source
{
 public   class MsgBox
    {
        //public static void Show(string StrMessage)
        //{
        //    Forms.FrmMsg f = new Forms.FrmMsg();
        //    f.labMsg.Text = StrMessage;
        //    f.ShowDialog();
        //}
        //public static void Show(string StrMessage,string strtitle)
        //{
        //    Forms.FrmMsg f = new Forms.FrmMsg();
        //    f.labMsg.Text = StrMessage;
        //    f.StrFormName = strtitle;
        //    f.ShowDialog();
        //}
        //public static DialogResult Show(string StrMessage, string strtitle,int ButtonCount)
        //{
        //    Forms.FrmMsg f = new Forms.FrmMsg();
        //    f.labMsg.Text = StrMessage;
        //    f.StrFormName = strtitle;
        //    f.ButtonCount = ButtonCount;
        //   return f.ShowDialog();
        //}

        public static void Show(string StrMessage)
        {
            Wfa_UserAccount.Forms.FrmMsg f = new Wfa_UserAccount.Forms.FrmMsg();
            f.labelMsg.Text = StrMessage;
            f.ShowDialog();
        }
        public static void Show(string StrMessage, string strtitle)
        {
            Wfa_UserAccount.Forms.FrmMsg f = new Wfa_UserAccount.Forms.FrmMsg();
            f.labelMsg.Text = StrMessage;
            f.StrFormName = strtitle;
            f.ShowDialog();
        }
        public static DialogResult Show(string StrMessage, string strtitle, int ButtonCount)
        {
            Wfa_UserAccount.Forms.FrmMsg f = new Wfa_UserAccount.Forms.FrmMsg();
            f.labelMsg.Text = StrMessage;
            f.StrFormName = strtitle;
            f.ButtonCount = ButtonCount;
            return f.ShowDialog();
        }
    }
}
