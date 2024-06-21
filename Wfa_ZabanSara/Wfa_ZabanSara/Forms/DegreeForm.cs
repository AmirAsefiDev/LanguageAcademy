using System;
using System.Drawing;
using System.Windows.Forms;
using Wfa_ZabanSara.App_source;
using Wfa_ZabanSara.App_source.BusinessLayer;
using Wfa_ZabanSara.App_source.DataObject;

namespace Wfa_ZabanSara.Forms
{
    public partial class DegreeForm : MasterForm.frmMaster
    {
        public DegreeForm()
        {
            InitializeComponent();
        }

        private void GetList()
        {
            BusinessDegree ObjB = new BusinessDegree();
            DgvDgree.DataSource = ObjB.GetList();
            SetOption();
        }

        private void SetOption()
        {
            DgvDgree.Columns["ID"].Visible = false;
            DgvDgree.Columns["title"].HeaderText = "مدرک";
        }
        private void DegreeForm_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void DgvDgree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvDgree.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        public bool ValidateData()
        {
            bool Result = true;
            if (TextBoxTitle.Text.Trim() == String.Empty)
            {
                errorProvider.SetError(TextBoxTitle, "لطفا مقدار را وارد نمایید");
                Result = false;
            }

            return Result;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Degree objdegree = new Degree();
                objdegree.Title = TextBoxTitle.Text.Trim();
                BusinessDegree objDB = new BusinessDegree();
                if (objDB.Insert(objdegree) != 0)
                {
                    MsgBox.Show("مدرک جدید درست ثبت شد","");
                    GetList();
                    ClearText();
                }
                else
                {
                    MsgBox.Show("مدرک جدید درست ثبت نشد","");
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (TextBoxTitle.Tag.ToString().Trim() == string.Empty)
                {
                    MsgBox.Show("لطفا برروری سطر مورد نظر خود کلیک کنید","توجه");

                    //Forms.frmMsg FrmMsg = new Forms.frmMsg();
                    //FrmMsg.labelMsg.Text = "لطفا برروری سطر مورد نظر خود کلیک کنید";
                    //FrmMsg.ShowDialog();
                    //FrmMsg.ButtonCount = 1;

                    //MessageBox.Show("لطفا برروری سطر مورد نظر خود کلیک کنید");
                    return;
                }
                Degree objD = new Degree();
                objD.ID = int.Parse(TextBoxTitle.Tag.ToString());
                objD.Title = TextBoxTitle.Text.Trim();
                BusinessDegree ObjBD = new BusinessDegree();
                if (ObjBD.Update(objD) != 0)
                {
                    MsgBox.Show("مدرک درست ویرایش شد","");
                    GetList();
                    ClearText();
                }
                else
                {
                    MsgBox.Show("مدرک درست ویرایش نشد","");
                }
            }
        }

        private void ClearText()
        {
            TextBoxTitle.Tag = string.Empty;
            TextBoxTitle.Text = string.Empty;
        }

        private void DgvDgree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDgree.Rows.Count > 1)
            {
                TextBoxTitle.Tag = DgvDgree.CurrentRow.Cells["ID"].Value.ToString();
                TextBoxTitle.Text = DgvDgree.CurrentRow.Cells["Title"].Value.ToString();
            }
            else
            {
                GetList();
            }
        }

        private void TxtID_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {      
            //Forms.frmMsg f = new frmMsg();
            if (TextBoxTitle.Tag.ToString().Trim() == string.Empty)
            {
                MsgBox.Show("لطفا برروری سطر مورد نظر خود کلیک کنید", "");

                //f.labelMsg.Text = "لطفا برروری سطر مورد نظر خود کلیک کنید";
                //f.ButtonCount = 1;
                //f.ShowDialog();
                
                return;
            }

            

            //f.labelMsg.Text = "آیا می خواهید این رکورد حذف شود";
            //f.StrFormName = "توجه!";
            //f.ButtonCount = 2;

            //if (f.ShowDialog() == DialogResult.OK)
            if ( MsgBox.Show("آیا می خواهید این رکورد حذف شود","توجه!",2)== DialogResult.OK)
            {
                Degree objD = new Degree();
                objD.ID = int.Parse(TextBoxTitle.Tag.ToString());

                BusinessDegree ObjBD = new BusinessDegree();
                ObjBD.Delete(objD);
                GetList();
                ClearText();

                MsgBox.Show("رکورد مورد نظر شما حذف شد","");
                //f.labelMsg.Text = "رکورد مورد نظر شما حذف شد";
                //f.ButtonCount = 1;
                //f.ShowDialog();

            }
        }

        private void TxtTitle_MouseEnter(object sender, EventArgs e)
        {
            TextBoxTitle.BackColor = Color.MediumVioletRed;
        }

        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            TextBoxTitle.BackColor = Color.White;
        }
    }
}
