using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wfa_ZabanSara.App_source;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class SearchCourseForm : MasterForm.frmMaster
    {
        public int SendParameter = 0;
        public SearchCourseForm()
        {
            InitializeComponent();

        }

        private void SearchCourseForm_Load(object sender, EventArgs e)
        {
            GetListCourse();
        }
        private void DataGridViewSearchCourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewSearchCourse.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void BtnSearchTitle_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchTitle.Text.Trim().Length >= 2)
            {
                CourseBusiness business = new();
                DataGridViewSearchCourse.DataSource = business.DetailsByField("Title", TextBoxSearchTitle.Text.Trim());
                SetSettingCourse();
            }
            else
                MsgBox.Show("مقدار نام درس را به درستی وارد کنید", "هشدار");

        }

        private void BtnSearchLevelCount_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchLevelCount.Text.Trim().Length >= 1)
            {
                CourseBusiness business = new();
                DataGridViewSearchCourse.DataSource = business.DetailsByField("LevelCount", TextBoxSearchLevelCount.Text.Trim());
                SetSettingCourse();
            }
            else
                MsgBox.Show("مقدار تعداد سطح را به درستی وارد کنید", "هشدار");

        }

        private void BtnSearchTuition_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchTuition.Text.Trim().Length >= 2)
            {
                CourseBusiness business = new();
                DataGridViewSearchCourse.DataSource = business.DetailsByField("Tuition", TextBoxSearchTuition.Text.Trim());
                SetSettingCourse();
            }
            else
                MsgBox.Show("مقدار شهریه را به درستی وارد کنید", "هشدار");

        }

        private void DataGridViewSearchCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value == null)
                return;
            if (DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                return;
            SendParameter = int.Parse(DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString());
            this.Close();
        }


        //this method get all information about Course Table in Database to dataGridView
        private void GetListCourse()
        {
            DataGridViewSearchCourse.DataSource = new CourseBusiness().GetList();
            SetSettingCourse();
        }

        // this method edit ColumnName to persian to user
        public void SetSettingCourse()
        {
            DataGridViewSearchCourse.Columns["ID"].Visible = false;
            DataGridViewSearchCourse.Columns["Title"].HeaderText = "نام درس";
            DataGridViewSearchCourse.Columns["LevelCount"].HeaderText = "تعداد سطح";
            DataGridViewSearchCourse.Columns["Tuition"].HeaderText = "شهریه";

            if (DataGridViewSearchCourse.Rows.Count == 1)
            {
                MsgBox.Show("برای مقدار وارد شده هیچ رکوردی پیدا نشد");
            }
        }

        private void ButtonPrintSearch_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DataGridViewSearchCourse));
        }
    }
}
