using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace wfa_FinancialSystem.App_source
{
 public class MsgBox
    {
        public static void Show(string StrMessage)
        {
            Wfa_FinancialSystem.Forms.frmMsg f = new Wfa_FinancialSystem.Forms.frmMsg();
            f.labelMsg.Text = StrMessage;
            f.ShowDialog();
        }
        public static void Show(string StrMessage,string strtitle)
        {
            Wfa_FinancialSystem.Forms.frmMsg f = new Wfa_FinancialSystem.Forms.frmMsg();
            f.labelMsg.Text = StrMessage;
            f.StrFormName = strtitle;
            f.ShowDialog();
        }
        public static DialogResult Show(string StrMessage, string strtitle,int ButtonCount)
        {
            Wfa_FinancialSystem.Forms.frmMsg f = new Wfa_FinancialSystem.Forms.frmMsg();
            f.labelMsg.Text = StrMessage;
            f.StrFormName = strtitle;
            f.ButtonCount = ButtonCount;
           return f.ShowDialog();
        }
    }
}
