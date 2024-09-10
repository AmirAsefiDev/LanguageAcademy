using wfa_FinancialSystem.App_source;
using Wfa_FinancialSystem.Forms.MasterForm;

namespace Wfa_FinancialSystem.Forms
{
    public partial class FrmPayType : frmMaster
    {
        public FrmPayType()
        {
            InitializeComponent();
        }

        private void PayTypeDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PayTypeDataGridView.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void FrmPayType_Load(object sender, EventArgs e)
        {
            TextsClear();
        }

        private void myToolbarPayType_Btn_Cancel()
        {
            myToolbarPayType.SetActionMode(true);
            TextsClear();
        }

        private void myToolbarPayType_Btn_Delete()
        {
            if (MsgBox.Show("آیا از حذف نوع پرداخت مورد نظر اطمینان دارید؟", "حذف کاربر", 2) == DialogResult.OK)
            {
                PayType payType = new();
                payType.ID = myToolbarPayType.ActiveRecord;
                PayTypeBusiness payTypeBusiness = new();
                payTypeBusiness.Delete(payType);
                TextsClear();
                GetListPayType();
                MsgBox.Show("نوع پرداخت مورد نظر پاک شده");
            }
            else
            {
                MsgBox.Show("لطفا روی رکورد مورد نظر خود کلیک کنید",
                    "انتخاب رکورد ");
            }
        }

        private void myToolbarPayType_Btn_Edit()
        {
            myToolbarPayType.SetActionMode(false);
            myToolbarPayType.ActionMode_NewOrEdit = false;
        }

        private void myToolbarPayType_Btn_New()
        {
            myToolbarPayType.SetActionMode(false);
            myToolbarPayType.ActionMode_NewOrEdit = true;
        }

        private void myToolbarPayType_Btn_OK()
        {
            if (validateData())
            {
                PayType payType = new();
                payType.PaymentType = myTextBoxPayType.Text.Trim();
                payType.Description = textBoxDescription.Text.Trim();
                PayTypeBusiness payTypeBusiness = new();
                //Insert Payment
                if (myToolbarPayType.ActionMode_NewOrEdit)
                {
                    int id = payTypeBusiness.Insert(payType);
                   
                    if (id != 0)
                    {
                        TextsClear();
                        myToolbarPayType.ActiveRecord = id;
                        GetListPayType();
                        myToolbarPayType.SetActionMode(true);
                        MsgBox.Show("رکورد جدید با موفقیت اضافه شد");
                    }
                }
                //Update Payment
                else
                {
                    payType.ID = myToolbarPayType.ActiveRecord;
                    int ID = payTypeBusiness.Update(payType);
                    
                    if (ID != 0)
                    {
                        TextsClear();
                        myToolbarPayType.ActiveRecord = payType.ID;
                        GetListPayType();
                        myToolbarPayType.SetActionMode(true);
                        MsgBox.Show("رکورد جدید با موفقیت ویرایش شد");
                    }
                }
            }
        }

        private void PayTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextsClear();
            if (PayTypeDataGridView.Rows.Count > 0)
            {
                myToolbarPayType.ActiveRecord = int.Parse(PayTypeDataGridView.CurrentRow.Cells["ID"].Value.ToString());
                myTextBoxPayType.Text = PayTypeDataGridView.CurrentRow.Cells["PaymentType"].Value.ToString();
                textBoxDescription.Text = PayTypeDataGridView.CurrentRow.Cells["Description"].Value.ToString();
            }
        }

        void GetListPayType()
        {
            if (myToolbarPayType.ActiveRecord != 0)
            {
                PayType payType = new();
                payType.ID = myToolbarPayType.ActiveRecord;
                PayTypeDataGridView.DataSource = new PayTypeBusiness().Details(payType);
                setSetting();
            }
            else
            {
                PayTypeDataGridView.DataSource = null;
            }
        }
        void setSetting()
        {
            PayTypeDataGridView.Columns["ID"].Visible = false;
            PayTypeDataGridView.Columns["PaymentType"].HeaderText = "نوع پرداخت";
            PayTypeDataGridView.Columns["Description"].HeaderText = "توضیحات";
            if (PayTypeDataGridView.Rows.Count == 0)
            {
                MsgBox.Show("رکوردی برای نمایش پیدا نشد");
            }
        }

        void TextsClear()
        {
            myTextBoxPayType.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            myToolbarPayType.ActiveRecord = 0;
        }
        bool validateData()
        {
            errorProviderPayType.Clear();
            bool res = true;

            if (myTextBoxPayType.Text == string.Empty || myTextBoxPayType.Text == null)
            {
                errorProviderPayType.SetError(myTextBoxPayType, "خواهشمندم مقدار نوع پرداخت را وارد کنید عزیز دل");
                res = false;
            }
            if (textBoxDescription.Text == string.Empty || myTextBoxPayType.Text == null)
            {
                errorProviderPayType.SetError(textBoxDescription, "خواهشمندم مقدار توضیحات را وارد کنید عزیز دل");
                res = false;
            }

            return res;
        }

        private void buttonSearchPayType_Click(object sender, EventArgs e)
        {
            PayTypeDataGridView.DataSource = new PayTypeBusiness().DetailsByField("PaymentType", myTextBoxPayType.Text.Trim());
            setSetting();
        }
    }

}
