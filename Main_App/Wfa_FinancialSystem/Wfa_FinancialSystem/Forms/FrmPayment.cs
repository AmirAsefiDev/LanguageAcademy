using wfa_FinancialSystem.App_source;
using wfa_FinancialSystem.App_Source.BusinessLayer;

namespace Wfa_FinancialSystem.Forms
{
    public partial class FrmPayment : MasterForm.frmMaster
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            RunOnlyOneTime();
            ClearText();
        }

        private void labelStudentInfo_Click(object sender, EventArgs e)
        {
            StudentSearchForm studentSearchForm = new();
            studentSearchForm.StrFormName = "فرم جستجوی دانشجو";
            studentSearchForm.ShowDialog();
            ////////////////////////////////////////////
            if (studentSearchForm.SendParameter > 0)
            {
                if (studentSearchForm.DgvStudent.Rows.Count > 1)
                {
                    if (studentSearchForm.DgvStudent.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (studentSearchForm.DgvStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    string studentName = studentSearchForm.DgvStudent.CurrentRow.Cells["Name"].Value.ToString();
                    string studentLastName = studentSearchForm.DgvStudent.CurrentRow.Cells["LastName"].Value.ToString();

                    txtStudentInfo.Text = studentName + " " + studentLastName;
                    txtStudentInfo.Tag = studentSearchForm.DgvStudent.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
        }

        private void RunOnlyOneTime()
        {
            ComboBoxID_FK_Bank.DataSource = new BankBusiness().GetList();
            ComboBoxID_FK_Bank.ValueMember = "ID";
            ComboBoxID_FK_Bank.DisplayMember = "Name";
            ComboBoxID_FK_PayType.DataSource = new PayTypeBusiness().GetList();
            ComboBoxID_FK_PayType.ValueMember = "ID";
            ComboBoxID_FK_PayType.DisplayMember = "PaymentType";
            txtStudentInfo.Tag = string.Empty;
            txtAmount.Tag = string.Empty;
        }

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentInfo.Tag.ToString() != string.Empty)
                GetListPayment();
        }
        private void GetListPayment()
        {
            PaymentDataGridView.DataSource = new PaymentBusiness().DetailsByField("ID_FK_Student", txtStudentInfo.Tag.ToString());
            SetSetting();
            Calc();
        }
        private void SetSetting()
        {
            PaymentDataGridView.Columns["ID"].Visible = false;
            PaymentDataGridView.Columns["ID_FK_PayType"].Visible = false;
            PaymentDataGridView.Columns["ID_FK_Bank"].Visible = false;
            PaymentDataGridView.Columns["ID_FK_Student"].Visible = false;
            PaymentDataGridView.Columns["StudentName"].HeaderText = "نام دانشجو";
            PaymentDataGridView.Columns["Bank"].HeaderText = "نام بانک";
            PaymentDataGridView.Columns["Amount"].HeaderText = "مبلغ";
            PaymentDataGridView.Columns["PaymentDate"].HeaderText = "تاریخ پرداخت";
            PaymentDataGridView.Columns["DocNumber"].HeaderText = "شماره سند";
            PaymentDataGridView.Columns["Description"].HeaderText = "توضیحات";
            PaymentDataGridView.Columns["TracingID"].HeaderText = "شماره رهگیری";
            PaymentDataGridView.Columns["PaymentType"].HeaderText = "نوع پرداخت";
            PaymentDataGridView.Columns["PaymentDate"].Width = 80;
            PaymentDataGridView.Columns["ColumnRowNumber"].Width = 50;
        }
        private void Calc()
        {
            int Pay = 0;
            for (int i = 0; i <= PaymentDataGridView.Rows.Count; ++i)
            {
                Pay += int.Parse(PaymentDataGridView.Rows[i].Cells["Amount"].Value.ToString());
            }
            labeltotalPay.Text = Pay.ToString();
            //----------------------------------------
            int AllTuition = int.Parse(UserFunction.Bedehi(txtStudentInfo.Tag.ToString()));
            labelTotalTuition.Text = AllTuition.ToString();
            int Bedehi = (AllTuition - Pay);
            labelTotalBedehi.Text = Bedehi.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myToolbarPayment_Btn_Cancel()
        {
            myToolbarPayment.SetActionMode(true);

        }

        private void myToolbarPayment_Btn_Delete()
        {
            if (txtAmount.Tag.ToString() != string.Empty)
            {
                if (MsgBox.Show("آیا می خواهید این رکورد حذف شود", "حذف تراکنش پرداخت", 2) == DialogResult.OK)
                {
                    Payment payment = new Payment();
                    payment.ID = int.Parse(txtAmount.Tag.ToString());
                    PaymentBusiness b_Bk = new PaymentBusiness();
                    b_Bk.Delete(payment);
                    ClearText();
                    GetListPayment();
                }
                else
                {
                    MsgBox.Show("لطفا روی رکورد مورد نظر کلیک کنید");
                }
            }
        }

        private void myToolbarPayment_Btn_Edit()
        {
            myToolbarPayment.ActionMode_NewOrEdit = false;
        }

        public void ClearText()
        {
            txtAmount.Text = string.Empty;
            txtDocumentNumber.Text = string.Empty;
            txtTracingID.Text = string.Empty;
            ComboBoxID_FK_Bank.SelectedIndex = 0;
            ComboBoxID_FK_PayType.SelectedIndex = 0;
        }

        private void myToolbarPayment_Btn_New()
        {
            ClearText();
            myToolbarPayment.ActionMode_NewOrEdit = true;
        }

        public bool validateData()
        {
            errorProviderPayment.Clear();
            bool Result = true;
            if (txtAmount.Text.Length < 3)
            {
                errorProviderPayment.SetError(txtAmount, "رقم بیشتری برای مبلغ وارد کنید");
                Result = false;
            }
            if (txtStudentInfo.Tag.ToString() == string.Empty)
            {
                errorProviderPayment.SetError(txtStudentInfo, "لطفا به درستی مقدار را وارد کنید");
                Result = false;
            }
            if (txtTracingID.Text.Trim() == string.Empty)
            {
                errorProviderPayment.SetError(txtStudentInfo, "لطفا به درستی مقدار را وارد کنید");
                Result = false;
            }
            if (txtDocumentNumber.Text.Trim() == string.Empty)
            {
                errorProviderPayment.SetError(txtDocumentNumber, "لطفا مقدار را به درستی وارد کنید");
                Result = false;
            }
            return Result;
        }

        private void myToolbarPayment_Btn_OK()
        {
            if (validateData())
            {
                Payment pay = new Payment();
                pay.ID_FK_Bank = int.Parse(ComboBoxID_FK_Bank.SelectedValue.ToString());
                pay.ID_FK_PayType = int.Parse(ComboBoxID_FK_PayType.SelectedValue.ToString());
                pay.ID_FK_Student = int.Parse(txtStudentInfo.Tag.ToString());
                pay.TracingID = txtTracingID.Text;
                pay.PaymentDate = MyDate.Strdate();
                pay.DocNumber = txtDocumentNumber.Text;
                pay.Amount = txtAmount.Text;
                PaymentBusiness pb = new PaymentBusiness();
                if (myToolbarPayment.ActionMode_NewOrEdit)
                {
                    if (pb.Insert(pay) != 0)
                    {
                        ClearText();
                        myToolbarPayment.ActiveRecord = pay.ID_FK_Student;
                        myToolbarPayment.SetActionMode(true);
                        GetListPayment();
                    }
                    else
                    {
                        pay.ID = int.Parse(txtAmount.Tag.ToString());

                        if (pb.Update(pay) != 0)
                        {
                            ClearText();
                            myToolbarPayment.ActiveRecord = pay.ID_FK_Student;
                            myToolbarPayment.SetActionMode(true);
                            GetListPayment();
                        }
                    }
                }
            }
        }

        private void PaymentDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PaymentDataGridView.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.ColumnIndex + 1;
        }

        private void labelDocumentNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDocumentNumber.Text = UserFunction.FreeCode();
        }

        private void buttonSearchDocumentNumber_Click(object sender, EventArgs e)
        {
            PaymentDataGridView.DataSource = new PaymentBusiness().DetailsByField("DocNumber", txtDocumentNumber.Text.ToString());
        }
    }
}
