using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wfa_ZabanSara.App_source.BusinessLayer;
using Wfa_ZabanSara.App_source;
using Wfa_ZabanSara.App_source.Cpublic;

namespace Wfa_ZabanSara.Forms
{
    public partial class SearchTeacherForm : MasterForm.frmMaster
    {
        public int SendParameter = 0;
        public SearchTeacherForm()
        {
            InitializeComponent();
        }

        private void SearchTeacherForm_Load(object sender, EventArgs e)
        {
            GetListTeacher();
            SetSettingOnlyOneRun();
        }

        private void DataGridViewTeacher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewTeacher.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }
        private void BtnSearchNationalCode_Click(object sender, EventArgs e)
        {
            TeacherBusiness business = new();
            DataGridViewTeacher.DataSource = business.DetailsByField("NationalCode", TextBoxSearchNationalCode.Text.Trim());
            SetSettingTeacher();
        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            TeacherBusiness Business = new();
            DataGridViewTeacher.DataSource = Business.DetailsByField("Name", TextBoxSearchName.Text.Trim());
            SetSettingTeacher();
        }

        private void BtnSearchLastName_Click(object sender, EventArgs e)
        {
            TeacherBusiness business = new();
            DataGridViewTeacher.DataSource = business.DetailsByField("LastName", TextBoxSearchLastName.Text.Trim());
            SetSettingTeacher();
        }

        private void BtnSearchDegree_Click(object sender, EventArgs e)
        {
            TeacherBusiness business = new();
            DataGridViewTeacher.DataSource = business.DetailsByField("ID_FK_Degree", ComboBoxSearch_ID_FK_Degree.SelectedValue.ToString());
            SetSettingTeacher();
        }

        private void BtnSearchSex_Click(object sender, EventArgs e)
        {
            TeacherBusiness business = new();
            DataGridViewTeacher.DataSource = business.DetailsByField("Sex", ComboBoxSearchSex.SelectedIndex.ToString());
            SetSettingTeacher();
        }

        private void DataGridViewTeacher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTeacher.CurrentRow.Cells["ID"].Value == null)
                return;
            if (DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                return;
            SendParameter = int.Parse(DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString());
            this.Close();
        }

        private void GetListTeacher()
        {
            DataGridViewTeacher.DataSource = new TeacherBusiness().GetList();
            SetSettingTeacher();

        }
        public void SetSettingTeacher()
        {
            DataGridViewTeacher.Columns["ID"].Visible = false;
            DataGridViewTeacher.Columns["ID_FK_Degree"].Visible = false;
            DataGridViewTeacher.Columns["Name"].HeaderText = "نام";
            DataGridViewTeacher.Columns["LastName"].HeaderText = "نام خانوادگی";
            DataGridViewTeacher.Columns["NationalCode"].HeaderText = "کدملی";
            DataGridViewTeacher.Columns["Degree"].HeaderText = "مدرک";
            DataGridViewTeacher.Columns["Sex"].HeaderText = "جنسیت";
            DataGridViewTeacher.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            DataGridViewTeacher.Columns["Phone"].HeaderText = "تلفن";
            DataGridViewTeacher.Columns["Address"].HeaderText = "آدرس";
            //---------------------------LoadImage-----------------------
            System.Threading.Thread tr = new System.Threading.Thread(LoadImage);
            tr.Start();
        }

        private void SetSettingOnlyOneRun()
        {
            ComboBoxSearch_ID_FK_Degree.DataSource = new BusinessDegree().GetList();
            //----------------------------------------------------------------
            ComboBoxSearch_ID_FK_Degree.DisplayMember = "Title";
            ComboBoxSearch_ID_FK_Degree.ValueMember = "ID";
            ComboBoxSearch_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxSearch_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.ListItems;
            //----------------------------------------------------------------
            ComboBoxSearchSex.Text = "انتخاب کنید";
            ComboBoxSearchSex.Items.Add("زن");
            ComboBoxSearchSex.Items.Add("مرد");
        }
        public void LoadImage()
        {
            for (int i = 0; i < DataGridViewTeacher.RowCount; i++)
            {
                if (DataGridViewTeacher.Rows[i].Cells["ID"].Value != null)
                {
                    string StrId = DataGridViewTeacher.Rows[i].Cells["ID"].Value.ToString();
                    if (File.Exists(MyFile.TeacherImage + StrId + ".jpg"))
                    {
                        Bitmap bmp = new Bitmap(Image.FromFile(MyFile.TeacherImage + StrId + ".jpg"), 50, 50);
                        DataGridViewTeacher.Rows[i].Cells["ColumnImage"].Value = bmp;
                        DataGridViewTeacher.Height = 55;
                    }
                }
            }
        }


    }
}
