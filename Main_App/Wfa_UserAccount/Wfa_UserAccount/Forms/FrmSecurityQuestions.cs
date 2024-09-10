using Wfa_UserAccount.App_source;
using Wfa_UserAccount.Forms.MasterForm;

namespace Wfa_UserAccount.Forms
{
    public partial class FrmSecurityQuestions : frmMaster
    {
        public FrmSecurityQuestions()
        {
            InitializeComponent();
        }

        private void FrmSecurityQuestions_Load(object sender, EventArgs e)
        {
            ClearText();
            GetListSecurityQuestion();
        }

        private void SecurityQuestionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SecurityQuestionDataGridView.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void myToolbarSecurityQuestion_Btn_Cancel()
        {
            myToolbarSecurityQuestion.SetActionMode(true);
        }

        private void myToolbarSecurityQuestion_Btn_Delete()
        {
            if(myToolbarSecurityQuestion.ActiveRecord != 0)
            {
                if (MsgBox.Show("آیا از حذف این سوال اطمینان داری؟","حذف سوال امنیتی",2)==DialogResult.OK)
                {
                    SecurityQuestion securityQuestion = new SecurityQuestion();
                    securityQuestion.ID = myToolbarSecurityQuestion.ActiveRecord;
                    SecurityQuestionBusiness business = new SecurityQuestionBusiness();
                    business.Delete(securityQuestion);
                    ClearText();
                    GetListSecurityQuestion();
                }
                else
                {
                    App_source.MsgBox.Show("لطفا روی رکورد مورد نظر کلیک کنید");
                }
            }
        }

        private void myToolbarSecurityQuestion_Btn_Edit()
        {
            myToolbarSecurityQuestion.ActionMode_NewOrEdit = false;
        }

        private void myToolbarSecurityQuestion_Btn_New()
        {
            ClearText();
            myToolbarSecurityQuestion.ActionMode_NewOrEdit = true;
        }

        private void myToolbarSecurityQuestion_Btn_OK()
        {
            if (ValidateData())
            {
                SecurityQuestion securityQuestion = new SecurityQuestion();
                securityQuestion.question = TextBoxQuestion.Text;
                securityQuestion.Description = textBoxDescription.Text;

                SecurityQuestionBusiness questionBusiness = new SecurityQuestionBusiness();
                if (myToolbarSecurityQuestion.ActionMode_NewOrEdit)
                {
                    //add
                    int id = questionBusiness.Insert(securityQuestion);

                    if (id > 0)
                    {
                        myToolbarSecurityQuestion.ActiveRecord = securityQuestion.ID;
                        myToolbarSecurityQuestion.SetActionMode(true);
                        GetListSecurityQuestion();
                        ClearText();
                    }
                }
                else
                {
                    //edit
                    securityQuestion.ID = myToolbarSecurityQuestion.ActiveRecord;
                    questionBusiness.Update(securityQuestion);

                    ClearText();

                    GetListSecurityQuestion();
                    myToolbarSecurityQuestion.SetActionMode(true);
                }
            }

        }

        private void SecurityQuestionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SecurityQuestionDataGridView.RowCount > 0)
            {
               TextBoxQuestion.Text = SecurityQuestionDataGridView.CurrentRow.Cells["Question"].Value.ToString();
               if(SecurityQuestionDataGridView.CurrentRow.Cells["ID"].Value.ToString()!=string.Empty)
                myToolbarSecurityQuestion.ActiveRecord=int.Parse(SecurityQuestionDataGridView.CurrentRow.Cells["ID"].Value.ToString());
               textBoxDescription.Text = SecurityQuestionDataGridView.CurrentRow.Cells["Description"].Value.ToString();
            }



        }

        private void GetListSecurityQuestion()
        {
            SecurityQuestionDataGridView.DataSource = new SecurityQuestionBusiness().GetList();
            setSetting();
        }
        private void ClearText()
        {
            TextBoxQuestion.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
        }
        private void setSetting()
        {
            SecurityQuestionDataGridView.Columns["ColumnRowNumber"].Width = 35;
            SecurityQuestionDataGridView.Columns["ID"].Visible = false;
            SecurityQuestionDataGridView.Columns["question"].HeaderText = "سوال امنیتی";
            SecurityQuestionDataGridView.Columns["Description"].HeaderText = "پاسخ سوالات امنیتی";
            //[ID]
            //,[Question]
            //,[Description]
        }
        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool result = true;

            if (TextBoxQuestion.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(TextBoxQuestion, "سوال خود را در ابتدا وارد کنید");
                result = false;
            }

            return result;
        }
    }
}
