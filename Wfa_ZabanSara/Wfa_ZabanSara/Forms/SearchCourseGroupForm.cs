using Wfa_ZabanSara.App_source;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class SearchCourseGroupForm : MasterForm.frmMaster
    {
        public int SendParameters = 0;
        public SearchCourseGroupForm()
        {
            InitializeComponent();
        }

        private void SearchCourseGroupForm_Load(object sender, EventArgs e)
        {
            GetListCourseGroup();
        }
        private void DgvCourseGroup_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvCourseSelect.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void ButtonSearchCourseTeacher_Click(object sender, EventArgs e)
        {
            Forms.SearchTeacherForm searchTeacher = new();
            searchTeacher.StrFormName = "فرم جستجوی استاد";
            searchTeacher.ShowDialog();
            ///--------------------------------------------
            if (searchTeacher.SendParameter > 0)
            {
                if (searchTeacher.DataGridViewTeacher.Rows.Count > 1)
                {
                    if (searchTeacher.DataGridViewTeacher.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchTeacher.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    TextBoxSearchCourseTeacher.Text = searchTeacher.DataGridViewTeacher.CurrentRow.Cells["Name"].Value.ToString() + " " +
                        searchTeacher.DataGridViewTeacher.CurrentRow.Cells["LastName"].Value.ToString();
                    TextBoxSearchCourseTeacher.Tag = searchTeacher.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString();

                    DgvCourseSelect.DataSource = new CourseGroupBusiness().DetailsByField("Teacher.ID", TextBoxSearchCourseTeacher.Tag.ToString());
                    SetSettingCourseGroup();

                    if (DgvCourseSelect.Rows.Count < 2)
                    {
                        MsgBox.Show("برای این استاد گروه درسی تعریف نشده");
                    }
                }
            }
        }

        private void ButtonSearchCourseName_Click(object sender, EventArgs e)
        {
            SearchCourseForm searchCourse = new();
            searchCourse.StrFormName = "فرم جستجوی درس";
            searchCourse.ShowDialog();
            //------------------------------------
            if (searchCourse.SendParameter > 0)
            {
                if (searchCourse.DataGridViewSearchCourse.Rows.Count > 1)
                {
                    if (searchCourse.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourse.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    TextBoxSearchCourseName.Text = searchCourse.DataGridViewSearchCourse.CurrentRow.Cells["Title"].Value.ToString();
                    TextBoxSearchCourseName.Tag = searchCourse.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString();

                    DgvCourseSelect.DataSource = new CourseGroupBusiness().DetailsByField("Course.ID", TextBoxSearchCourseName.Tag.ToString());
                    SetSettingCourseGroup();

                    if (DgvCourseSelect.Rows.Count < 2)
                    {
                        MsgBox.Show("برای این درس گروه درسی تشکیل نشده");
                    }

                }
            }
        }

        private void ButtonSearchCourseYear_Click(object sender, EventArgs e)
        {
            DgvCourseSelect.DataSource = new CourseGroupBusiness().DetailsByField("Year", TextBoxSearchCourseYear.Text);
            if (DgvCourseSelect.Rows.Count < 2)
            {
                MsgBox.Show("برای این سال گروه درسی وجود ندارد");
            }
        }

        private void DgvCourseGroup_DoubleClick(object sender, EventArgs e)
        {
            if (DgvCourseSelect.Rows.Count > 1)
            {
                if (DgvCourseSelect.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameters = int.Parse(DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }



        private void GetListCourseGroup()
        {
            CourseGroupBusiness courseGroupBusiness = new();
            DgvCourseSelect.DataSource = courseGroupBusiness.GetList();
            SetSettingCourseGroup();

        }
        private void SetSettingCourseGroup()
        {
            DgvCourseSelect.Columns["ID"].Visible = false;
            DgvCourseSelect.Columns["ID_FK_Teacher"].Visible = false;
            DgvCourseSelect.Columns["ID_FK_Course"].Visible = false;

            DgvCourseSelect.Columns["Title"].HeaderText = "نام درس";
            DgvCourseSelect.Columns["teacherName"].HeaderText = "نام استاد";
            DgvCourseSelect.Columns["LevelCourse"].HeaderText = "سطح";
            DgvCourseSelect.Columns["Tuition"].HeaderText = "شهریه";
            DgvCourseSelect.Columns["Year"].HeaderText = "سال";
            DgvCourseSelect.Columns["Term"].HeaderText = "ترم";
            DgvCourseSelect.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            DgvCourseSelect.Columns["WeekPlan"].HeaderText = "برنامه هفتگی";

        }

        private void DgvCourseGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCourseSelect.Rows.Count > 1)
            {
                if (DgvCourseSelect.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameters = int.Parse(DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        private void ButtonPrintCourseGroup_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DgvCourseSelect));
        }
    }
}
