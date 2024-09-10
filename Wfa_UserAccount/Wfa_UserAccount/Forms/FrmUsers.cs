using System.Data;
using Wfa_UserAccount.App_source;

namespace Wfa_UserAccount.Forms
{
    public partial class FrmUsers : MasterForm.frmMaster
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            clearText();
            RunOnlyOneTime();
            GetListUsers();
        }
        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            usersDataGridView.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void myToolbar1_Btn_Cancel()
        {
            myToolbarUsers.SetActionMode(true);
        }

        private void myToolbar1_Btn_Delete()
        {
            if (myToolbarUsers.ActiveRecord != 0)
            {
                if (MsgBox.Show("آیا از حذف این سوال اطمینان داری؟", "حذف سوال امنیتی", 2) == DialogResult.OK)
                {
                    Users users = new();
                    users.ID = myToolbarUsers.ActiveRecord;
                    UsersBusiness business = new UsersBusiness();
                    business.Delete(users);
                    clearText();
                    GetListUsers();
                }

            }
            else
            {
                App_source.MsgBox.Show("لطفا روی رکورد مورد نظر کلیک کنید");
            }
        }

        private void myToolbar1_Btn_Edit()
        {
            myToolbarUsers.ActionMode_NewOrEdit = false;
        }

        private void myToolbar1_Btn_New()
        {
            myToolbarUsers.ActionMode_NewOrEdit = true;
        }

        private void myToolbar1_Btn_OK()
        {
            if (validateData())
            {
                Users users = new();
                users.Name = myTextBoxName.Text;
                users.LastName = myTextBoxLastName.Text;
                users.UserName = myTextBoxUsername.Text;
                users.Password = Heilton_HASH.SHA2_Hash(textBoxPassword.Text);
                users.Answer = myTextBoxAnswer.Text;
                users.ID_FK_Permission = int.Parse(myComboBoxID_FK_Permission.SelectedValue.ToString());
                users.ID_FK_SecurityQuestion = int.Parse(myComboBoxID_FK_SecurityQuestion.SelectedValue.ToString());
                UsersBusiness usersBusiness = new UsersBusiness();
                if (myToolbarUsers.ActionMode_NewOrEdit)
                {
                    DataTable DT = (new UsersBusiness().DetailsByField("UserName", myTextBoxUsername.Text));
                    if (DT.Rows.Count > 0)
                    {
                        MsgBox.Show("این نام کاربری وجود دارد");
                        return;
                    }
                    int id = usersBusiness.Insert(users);
                    if (id != 0)
                    {
                        clearText();
                        myToolbarUsers.ActiveRecord = id;
                        GetListUsers();
                        myToolbarUsers.SetActionMode(true);
                    }
                }
                else
                {
                    users.ID = myToolbarUsers.ActiveRecord;
                    DataTable DT = (new UsersBusiness().DetailsByField("UserName", myTextBoxUsername.Text));
                    if (DT.Rows.Count > 0)
                    {
                        if (users.ID != DT.Rows[0].Field<int>("ID"))
                        {
                            MsgBox.Show("این نام کاربری وجود دارد");
                            return;
                        }
                    }
                    usersBusiness.Update(users);
                    myToolbarUsers.ActiveRecord = users.ID;
                    clearText();
                    GetListUsers();
                    myToolbarUsers.SetActionMode(true);
                }
            }
        }
        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearText();
            if (usersDataGridView.Rows.Count > 1)
            {
                if (usersDataGridView.CurrentRow.Cells["ID"].Value.ToString() != string.Empty)
                    myToolbarUsers.ActiveRecord = int.Parse(usersDataGridView.CurrentRow.Cells["ID"].Value.ToString());
                else
                    return;
                myTextBoxName.Text = usersDataGridView.CurrentRow.Cells["Name"].Value.ToString();
                myTextBoxLastName.Text = usersDataGridView.CurrentRow.Cells["LastName"].Value.ToString();
                myTextBoxUsername.Text = usersDataGridView.CurrentRow.Cells["UserName"].Value.ToString();
                myComboBoxID_FK_Permission.SelectedValue = usersDataGridView.CurrentRow.Cells["ID_FK_Permission"].Value.ToString();
                textBoxPassword.Text = usersDataGridView.CurrentRow.Cells["Password"].Value.ToString();
                myComboBoxID_FK_SecurityQuestion.SelectedValue = usersDataGridView.CurrentRow.Cells["ID_FK_SecurityQuestion"].Value.ToString();
                myTextBoxAnswer.Text = usersDataGridView.CurrentRow.Cells["Answer"].Value.ToString();
            }

        }

        private bool validateData()
        {
            bool res = true;

            errorProviderUsers.Clear();
            if (myTextBoxName.Text.Trim() == string.Empty)
            {
                errorProviderUsers.SetError(myTextBoxName, "لطفا مقدار نام را وارد نمایید");
                return false;
            }
            if (myTextBoxLastName.Text.Trim() == string.Empty)
            {
                errorProviderUsers.SetError(myTextBoxLastName, "لطفا مقدار نام خانوادگی را وارد نمایید");
                return false;
            }
            if (myTextBoxUsername.Text.Trim() == string.Empty)
            {
                errorProviderUsers.SetError(myTextBoxUsername, "لطفا مقدار نام کاربری را وارد نمایید");
                return false;
            }
            if (myTextBoxAnswer.Text.Trim() == string.Empty)
            {
                errorProviderUsers.SetError(myTextBoxAnswer, "لطفا مقدار سوال امنیتی را وارد نمایید");
                return false;
            }
            return res;
        }


        private void RunOnlyOneTime()
        {
            myComboBoxID_FK_Permission.DataSource = new PermissionBusiness().GetList();
            myComboBoxID_FK_Permission.ValueMember = "UserState";
            myComboBoxID_FK_Permission.ValueMember = "ID";

            myComboBoxID_FK_SecurityQuestion.DataSource = new SecurityQuestionBusiness().GetList();
            myComboBoxID_FK_SecurityQuestion.ValueMember = "ID";
            myComboBoxID_FK_SecurityQuestion.DisplayMember = "Question";
        }

        private void GetListUsers()
        {
            usersDataGridView.DataSource = new UsersBusiness().GetList();
            setSetting();
        }

        private void setSetting()
        {
            usersDataGridView.Columns["ColumnRowNumber"].Width = 40;
            usersDataGridView.Columns["ID"].Visible = false;
            usersDataGridView.Columns["Password"].Visible = false;
            usersDataGridView.Columns["ID_FK_Permission"].Visible = false;
            usersDataGridView.Columns["ID_FK_SecurityQuestion"].Visible = false;
            usersDataGridView.Columns["Question"].Visible = false;
            usersDataGridView.Columns["Name"].HeaderText = "نام";
            usersDataGridView.Columns["LastName"].HeaderText = "نام خانوادگی";
            usersDataGridView.Columns["Answer"].HeaderText = "جواب سوال امنیتی";
            usersDataGridView.Columns["UserName"].HeaderText = "نام کاربری";
            usersDataGridView.Columns["UserState"].HeaderText = "سطح دسترسی";

        }

        private void clearText()
        {
            myTextBoxName.Text = string.Empty;
            myTextBoxLastName.Text = string.Empty;
            myTextBoxUsername.Text = string.Empty;
            //myComboBoxID_FK_Permission.SelectedIndex = 0;
            //myComboBoxID_FK_SecurityQuestion.SelectedIndex = 0;
            textBoxPassword.Text = string.Empty;
            myTextBoxAnswer.Text = string.Empty;
        }
    }
}
