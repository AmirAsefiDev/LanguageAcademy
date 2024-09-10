using Wfa_UserAccount.App_source;
using Wfa_UserAccount.Forms.MasterForm;

namespace Wfa_UserAccount.Forms
{
    public partial class FrmPermission : frmMaster
    {
        public FrmPermission()
        {
            InitializeComponent();
        }

        private void FrmPermission_Load(object sender, EventArgs e)
        {
            //ClearText();
            GetListPermission();

        }
        private void PermissionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PermissionDataGridView.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void myToolbarPermission_Btn_Cancel()
        {
            errorProviderPermission.Clear();
            myToolbarPermission.SetActionMode(true);
        }

        private void myToolbarPermission_Btn_Delete()
        {
            if(myToolbarPermission.ActiveRecord != 0)
            {
                if (MsgBox.Show("آیا از حذف این سطح دسترسی کاربر اطمینان داری؟", "حذف دسترسی کاربر", 2) == DialogResult.OK)
                {
                    Permission permission = new Permission();
                    permission.ID = myToolbarPermission.ActiveRecord;
                    PermissionBusiness permissionBusiness = new();
                    permissionBusiness.Delete(permission);

                    ClearText();
                    GetListPermission();

                }
                else
                {
                    App_source.MsgBox.Show("لطفا روی رکورد مورد نظر کلیک کنید");
                }
            }
        }

        private void myToolbarPermission_Btn_Edit()
        {
            errorProviderPermission.Clear();
            myToolbarPermission.ActionMode_NewOrEdit = false;
        }

        private void myToolbarPermission_Btn_New()
        {
            ClearText();
            myToolbarPermission.ActionMode_NewOrEdit = true;
        }

        private void myToolbarPermission_Btn_OK()
        {
            if (textBoxUserName.Text != string.Empty)
            {
                Permission permission = new Permission();
                permission.UserState = textBoxUserName.Text.Trim();
                permission.Adduser = checkBoxAddUserPermission.Checked;
                permission.DeleteUser = checkBoxDeleteUserPermission.Checked;
                permission.EditUser = checkBoxEditUserPermission.Checked;
                permission.SelectUser = checkBoxSelectUserPermission.Checked;
                permission.PaymentManage = checkBoxPaymentManage.Checked;
                permission.CourseManage = checkBoxCoursesManage.Checked;
                permission.StudentManage = checkBoxStudentsManage.Checked;
                permission.TeacherManage = checkBoxTeachersManage.Checked;
                PermissionBusiness permissionBusiness = new();

                if (myToolbarPermission.ActionMode_NewOrEdit)
                {
                    permissionBusiness.Insert(permission);
                    ClearText();
                    GetListPermission();
                    myToolbarPermission.SetActionMode(true);
                }
                else
                {
                    permission.ID = myToolbarPermission.ActiveRecord;
                    permissionBusiness.Update(permission);
                    ClearText();
                    GetListPermission();
                    myToolbarPermission.SetActionMode(true);
                }
            }
            else
            {
                errorProviderPermission.Clear();
                errorProviderPermission.SetError(textBoxUserName, "نام کاربری را وارد کنید");
            }
        }
        private void PermissionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (PermissionDataGridView.RowCount > 0)
            {
                textBoxUserName.Text = PermissionDataGridView.CurrentRow.Cells["UserState"].Value.ToString();
                if (PermissionDataGridView.CurrentRow.Cells["ID"].Value.ToString() != string.Empty)
                    myToolbarPermission.ActiveRecord = int.Parse(PermissionDataGridView.CurrentRow.Cells["ID"].Value.ToString());
                else
                    return;
                checkBoxAddUserPermission.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["AddUser"].Value.ToString());
                checkBoxDeleteUserPermission.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["DeleteUser"].Value.ToString());
                checkBoxEditUserPermission.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["EditUser"].Value.ToString());
                checkBoxSelectUserPermission.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["SelectUser"].Value.ToString());
                checkBoxPaymentManage.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["PaymentManage"].Value.ToString());
                checkBoxCoursesManage.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["CourseManage"].Value.ToString());
                checkBoxStudentsManage.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["StudentManage"].Value.ToString());
                checkBoxTeachersManage.Checked = bool.Parse(PermissionDataGridView.CurrentRow.Cells["TeacherManage"].Value.ToString());
            }
        }

        private void checkBoxChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChooseAll.Checked)
            {
                checkBoxAddUserPermission.Checked = true;
                checkBoxDeleteUserPermission.Checked = true;
                checkBoxEditUserPermission.Checked = true;
                checkBoxSelectUserPermission.Checked = true;
                checkBoxPaymentManage.Checked = true;
                checkBoxCoursesManage.Checked = true;
                checkBoxStudentsManage.Checked = true;
                checkBoxTeachersManage.Checked = true;
            }
            else
            {
                checkBoxAddUserPermission.Checked = false;
                checkBoxDeleteUserPermission.Checked = false;
                checkBoxEditUserPermission.Checked = false;
                checkBoxSelectUserPermission.Checked = false;
                checkBoxPaymentManage.Checked = false;
                checkBoxCoursesManage.Checked = false;
                checkBoxStudentsManage.Checked = false;
                checkBoxTeachersManage.Checked = false;
            }
        }

        private void GetListPermission()
        {
            PermissionDataGridView.DataSource = new PermissionBusiness().GetList();
            setSetting();
        }
        private void setSetting()
        {
            PermissionDataGridView.Columns["ID"].Visible = false;
            PermissionDataGridView.Columns["ColumnRowNumber"].Width = 50;
            PermissionDataGridView.Columns["UserState"].HeaderText = "نام کاربری";
            PermissionDataGridView.Columns["AddUser"].HeaderText = "اضافه کردن کاربر جدید";
            PermissionDataGridView.Columns["DeleteUser"].HeaderText = "حذف کردن کاربر جدید";
            PermissionDataGridView.Columns["EditUser"].HeaderText = "ویرایش کردن کاربر جدید";
            PermissionDataGridView.Columns["SelectUser"].HeaderText = "دیدن کاربران";
            PermissionDataGridView.Columns["PaymentManage"].HeaderText = "مدیریت امور مالی";
            PermissionDataGridView.Columns["CourseManage"].HeaderText = "مدیریت دروس";
            PermissionDataGridView.Columns["StudentManage"].HeaderText = "مدیریت دانش آموزان";
            PermissionDataGridView.Columns["TeacherManage"].HeaderText = "مدیریت اساتید";
        }

        private void ClearText()
        {
            errorProviderPermission.Clear();
            textBoxUserName.Text = string.Empty;
            foreach (CheckBox checkBox in groupBoxCheckingOut.Controls)
            {
                checkBox.Checked = false;
            }
        }

    }
}
