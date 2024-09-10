using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wfa_UserAccount.Forms.MasterForm;

namespace Wfa_UserAccount.Forms
{
    public partial class FrmMain : frmMaster
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new Forms.FrmLogin().ShowDialog();

        }

        private void BtnSecurityQuestions_Click(object sender, EventArgs e)
        {
            Forms.FrmSecurityQuestions f = new Forms.FrmSecurityQuestions();
            f.StrFormName = "سوالات امنیتی";
            f.ShowDialog();
        }

        private void BtnPermission_Click(object sender, EventArgs e)
        {
            Forms.FrmPermission f = new Forms.FrmPermission();
            f.StrFormName = "سطح دسترسی";
            f.ShowDialog();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            Forms.FrmUsers f = new Forms.FrmUsers();
            f.StrFormName = "کاربران";
            f.ShowDialog();
        }

        private void BtnloginTest_Click(object sender, EventArgs e)
        {
            new Forms.FrmLogin().ShowDialog();
            App_source.MsgBox.Show("این کاربر و رمز عبور  درست می باشد", "پیغام");
        }

    }
}
