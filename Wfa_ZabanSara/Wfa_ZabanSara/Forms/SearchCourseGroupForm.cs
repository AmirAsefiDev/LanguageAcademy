using Wfa_ZabanSara.App_source;

namespace Wfa_ZabanSara.Forms
{
    public partial class SearchCourseGroupForm : MasterForm.frmMaster
    {
        public int SendParameter = 0;
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
            DgvCourseGroup.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
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

                    DgvCourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("ID_FK_Teacher", TextBoxSearchCourseTeacher.Tag.ToString());
                    SetSettingCourseGroup();

                    if (DgvCourseGroup.Rows.Count < 2)
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

                    DgvCourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("ID_FK_Course", TextBoxSearchCourseName.Tag.ToString());
                    SetSettingCourseGroup();

                    if (DgvCourseGroup.Rows.Count < 2)
                    {
                        MsgBox.Show("برای این درس گروه درسی تشکیل نشده");
                    }

                }
            }
        }

        private void ButtonSearchCourseYear_Click(object sender, EventArgs e)
        {
            DgvCourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("Year", TextBoxSearchCourseYear.Text);
            if (DgvCourseGroup.Rows.Count < 2)
            {
                MsgBox.Show("برای این سال گروه درسی وجود ندارد");
            }
        }

        private void DgvCourseGroup_DoubleClick(object sender, EventArgs e)
        {
            if(DgvCourseGroup.Rows.Count > 1)
            {
                if (DgvCourseGroup.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameter = int.Parse(DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }



        private void GetListCourseGroup()
        {
            CourseGroupBusiness courseGroupBusiness = new();
            DgvCourseGroup.DataSource = courseGroupBusiness.GetList();
            SetSettingCourseGroup();

        }
        private void SetSettingCourseGroup()
        {
            DgvCourseGroup.Columns["ID"].Visible = false;
            DgvCourseGroup.Columns["ID_FK_Teacher"].Visible = false;
            DgvCourseGroup.Columns["ID_FK_Course"].Visible = false;

            DgvCourseGroup.Columns["Title"].HeaderText = "نام درس";
            DgvCourseGroup.Columns["teacherName"].HeaderText = "نام استاد";
            DgvCourseGroup.Columns["LevelCourse"].HeaderText = "سطح";
            DgvCourseGroup.Columns["Tuition"].HeaderText = "شهریه";
            DgvCourseGroup.Columns["Year"].HeaderText = "سال";
            DgvCourseGroup.Columns["Term"].HeaderText = "ترم";
            DgvCourseGroup.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            DgvCourseGroup.Columns["WeekPlan"].HeaderText = "برنامه هفتگی";
        }
    }
}
