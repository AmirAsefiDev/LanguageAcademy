using wfa_FinancialSystem.App_source;

namespace Wfa_FinancialSystem.Forms
{
    public partial class FrmBank : MasterForm.frmMaster
    {
        public FrmBank()
        {
            InitializeComponent();
        }

        private void FrmBank_Load(object sender, EventArgs e)
        {

        }

        private void DateGridViewBank_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewBank.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void myToolbar1_Btn_Cancel()
        {
            myToolbarBank.SetActionMode(true);
            clearText();
        }

        private void myToolbar1_Btn_Delete()
        {
            if(myToolbarBank.ActiveRecord != 0)
            {
                if(MsgBox.Show("آیا از حذف بانک مورد نظر اطمینان دارید؟","حذف کاربر",2) == DialogResult.OK)
                {
                    Bank bank = new();
                    bank.ID = myToolbarBank.ActiveRecord;
                    BankBusiness bankBusiness = new();
                    bankBusiness.Delete(bank);
                    clearText();
                    GetListBank();
                }
            }
            else { MsgBox.Show("لطفا روی رکورد مورد نظر خود کلیک کنید","انتخاب رکورد "); }
        }

        private void myToolbar1_Btn_Edit()
        {
            myToolbarBank.ActionMode_NewOrEdit = false;
        }

        private void myToolbar1_Btn_New()
        {
            myToolbarBank.ActionMode_NewOrEdit = true;

        }
        private void myToolbar1_Btn_OK()
        {
            if (ValidateData() == true)
            {
                Bank bank = new();
                bank.Name = myTextBoxBankName.Text.Trim();
                BankBusiness bankBusiness = new();

                //Insert
                if (myToolbarBank.ActionMode_NewOrEdit)
                {
                    int Id = bankBusiness.Insert(bank);
                    clearText();
                    if (Id != 0)
                    {
                        myToolbarBank.ActiveRecord = Id;
                        GetListBank();
                        myToolbarBank.SetActionMode(true);
                        MsgBox.Show("رکورد جدید با موفقیت اضافه شد");
                    }
                }
                //Update
                else
                {
                    bank.ID = myToolbarBank.ActiveRecord;
                    int ID = bankBusiness.Update(bank);
                    clearText();
                    if (ID != 0)
                    {
                        GetListBank();
                        myToolbarBank.SetActionMode(true);
                        MsgBox.Show("رکورد جدید با موفقیت ویرایش شد");
                    }
                }
            }
        }
        private void buttonSearchBank_Click(object sender, EventArgs e)
        {
            DataGridViewBank.DataSource = new BankBusiness().DetailsByField("Name", myTextBoxBankName.Text.Trim());
            setSetting();
        }

        private void DataGridViewBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearText();
            if (DataGridViewBank.Rows.Count > 0)
            {
                myTextBoxBankName.Text = DataGridViewBank.CurrentRow.Cells["Name"].Value.ToString();
                myToolbarBank.ActiveRecord = int.Parse(DataGridViewBank.CurrentRow.Cells["ID"].Value.ToString());
            }
        }
        public void clearText()
        {
            myTextBoxBankName.Text = string.Empty;
            myToolbarBank.ActiveRecord = 0;
        }

        public bool ValidateData()
        {
            errorProviderBank.Clear();
            bool Result = true;

            if (myTextBoxBankName.Text.Trim() == string.Empty || myTextBoxBankName.Text.Trim() == null)
            {
                errorProviderBank.SetError(myTextBoxBankName, "خواهشمندم مقدار نام را وارد کنید عزیز دل");
                Result = false;
            }

            return Result;
        }

        public void GetListBank()
        {
            if (myToolbarBank.ActiveRecord != 0)
            {
                Bank bank = new();
                bank.ID = myToolbarBank.ActiveRecord;
                DataGridViewBank.DataSource = new BankBusiness().Details(bank);
                setSetting();
            }
            else
                DataGridViewBank.DataSource = null;
        }
        public void setSetting()
        {
            DataGridViewBank.Columns["ID"].Visible = false;
            DataGridViewBank.Columns["Name"].HeaderText = "نام بانک";
            if (DataGridViewBank.Rows.Count == 0)
            {
                MsgBox.Show("رکوردی برای نمایش پیدا نشد");
            }
        }



 
    }
}
