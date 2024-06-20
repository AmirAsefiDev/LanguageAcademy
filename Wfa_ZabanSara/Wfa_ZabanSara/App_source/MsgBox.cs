using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfa_ZabanSara.App_source
{
    public class MsgBox
    {
        public static void Show(string strMessage)
        {
            Forms.frmMsg fmsg = new Forms.frmMsg();
            fmsg.labelMsg.Text = strMessage;
            fmsg.ShowDialog();
        }

        public static void Show(string strMessage,string strTitle)
        {
            Forms.frmMsg fmsg = new Forms.frmMsg();
            fmsg.labelMsg.Text = strMessage;
            fmsg.StrFormName = strTitle;
            fmsg.ShowDialog();
        }

        public static DialogResult Show(string strMessage, string strTitle,int ButtonCount)
        {
            Forms.frmMsg fmsg = new Forms.frmMsg();
            fmsg.labelMsg.Text = strMessage;
            fmsg.StrFormName = strTitle;
            fmsg.ButtonCount = ButtonCount;
            return fmsg.ShowDialog();
        }
    }
}
