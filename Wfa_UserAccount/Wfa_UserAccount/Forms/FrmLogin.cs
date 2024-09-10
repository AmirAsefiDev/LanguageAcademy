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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                string StrPasswordHash = Heilton_HASH.SHA2_Hash(textBoxPassword.Text);
                if (UserFunction.App_open(myTextBoxUserName.Text, StrPasswordHash) == 1)
                {
                    DataTable DT = new UsersBusiness().DetailsByField("UserName",myTextBoxUserName.Text);

                    ActiveUser.Name = DT.Rows[0].Field<string>("Name");
                    ActiveUser.LastName = DT.Rows[0].Field<string>("LastName");
                    ActiveUser.UserName = DT.Rows[0].Field<string>("Username");
                    ActiveUser.Password = DT.Rows[0].Field<string>("Password");
                    int perID = DT.Rows[0].Field<int>("ID_FK_Permission");
                    DT = new PermissionBusiness().DetailsByField("ID", perID.ToString());
                    ActiveUser.Permission = DT.Rows[0].Field<string>("UserState");
                    this.Close();
                }
                else
                {
                    App_source.MsgBox.Show("این نام کاربری و رمز عبور اشتباه می باشد");
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidateLogin()
        {
            errorProviderLogin.Clear();
            bool res = true;

            if(myTextBoxUserName.Text.Trim() == string.Empty)
            {
                errorProviderLogin.SetError(myTextBoxUserName, "نام کاربری را وارد کنید");
                res = false;
            }
            if (textBoxPassword.Text.Trim()==string.Empty)
            {
                errorProviderLogin.SetError(textBoxPassword,"رمز عبور را وارد کنید");
                res = false;
            }

            return res;
        }
    }
}
