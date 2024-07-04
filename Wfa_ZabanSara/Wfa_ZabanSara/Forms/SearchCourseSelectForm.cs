using Wfa_ZabanSara.App_source;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class SearchCourseSelectForm : MasterForm.frmMaster
    {
        public int SendParameters = 0;
        public SearchCourseSelectForm()
        {
            InitializeComponent();
        }

        private void SearchCourseSelectForm_Load(object sender, EventArgs e)
        {
            GetListCourseSelect();
        }

        private void DgvCourseSelect_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvCourseSelect.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void DgvCourseSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void ButtonSearchStudent_Click(object sender, EventArgs e)
        {
            SearchStudentFrom searchStudent = new();
            searchStudent.StrFormName = "فرم جستجوی دانش آموز";
            searchStudent.ShowDialog();
            //-------------------------------------
            if (searchStudent.SendParameter > 0)
            {
                if (searchStudent.DgvStudent.Rows.Count > 1)
                {
                    if (searchStudent.DgvStudent.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchStudent.DgvStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    string StudentName = searchStudent.DgvStudent.CurrentRow.Cells["Name"].Value.ToString();
                    string StudentLastName = searchStudent.DgvStudent.CurrentRow.Cells["LastName"].Value.ToString();

                    TextBoxSearchStudent.Text = StudentName + " " + StudentLastName;
                    TextBoxSearchStudent.Tag = searchStudent.DgvStudent.CurrentRow.Cells["ID"].Value.ToString();

                    DgvCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Student.ID", TextBoxSearchStudent.Tag.ToString());
                    SetSettingCourseSelect();
                }
            }
        }

        private void ButtonSearchCourseGroup_Click(object sender, EventArgs e)
        {
            SearchCourseGroupForm searchCourseGroup = new();
            searchCourseGroup.StrFormName = "فرم جستجوی گروه درسی";
            searchCourseGroup.ShowDialog();
            //----------------------------------------
            if (searchCourseGroup.SendParameters > 0)
            {
                if (searchCourseGroup.DgvCourseSelect.Rows.Count > 1)
                {
                    if (searchCourseGroup.DgvCourseSelect.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseGroup.DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    string TeacherName = searchCourseGroup.DgvCourseSelect.CurrentRow.Cells["teacherName"].Value.ToString();
                    string CourseTitle = searchCourseGroup.DgvCourseSelect.CurrentRow.Cells["Title"].Value.ToString();

                    TextBoxSearchCourseGroup.Text = CourseTitle + "(" + TeacherName + ")";
                    TextBoxSearchCourseGroup.Tag = searchCourseGroup.DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString();

                    DgvCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("ID_FK_CourseGroup", TextBoxSearchCourseGroup.Tag.ToString());
                }
            }
        }

        private void ButtonSearchCourseGroupYear_Click(object sender, EventArgs e)
        {
            DgvCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Year", TextBoxSearchCourseGroupYear.Text);
            if (DgvCourseSelect.Rows.Count == 1)
            {
                MsgBox.Show("هیچ رکوردی پیدا نشد", " انتخاب واحد");
            }

            SetSettingCourseSelect();
        }

        private void GetListCourseSelect()
        {
            CourseSelectBusiness ObjCourseSelectBusiness = new();
            DgvCourseSelect.DataSource = ObjCourseSelectBusiness.GetList();
            SetSettingCourseSelect();
        }
        private void SetSettingCourseSelect()
        {
            DgvCourseSelect.Columns["ID"].Visible = false;
            DgvCourseSelect.Columns["ID_FK_CourseGroup"].Visible = false;
            DgvCourseSelect.Columns["ID_FK_Student"].Visible = false;
            DgvCourseSelect.Columns["StudentName"].HeaderText = "نام دانشجو";
            DgvCourseSelect.Columns["Title"].HeaderText = "نام درس";
            DgvCourseSelect.Columns["teacherName"].HeaderText = " نام استاد";
            DgvCourseSelect.Columns["LevelCourse"].HeaderText = " سطح";
            DgvCourseSelect.Columns["Tuition"].HeaderText = "شهریه";
            DgvCourseSelect.Columns["Year"].HeaderText = "سال";
            DgvCourseSelect.Columns["Term"].HeaderText = "ترم";
            DgvCourseSelect.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            DgvCourseSelect.Columns["AttendScore"].HeaderText = "نمره حضور و غیاب";
            DgvCourseSelect.Columns["FinalScore"].HeaderText = "نمره پایانی";
            DgvCourseSelect.Columns["ActivityScore"].HeaderText = "نمره فعالیت کلاسی ";
            DgvCourseSelect.Columns["Score"].HeaderText = "نمره کامل";
            DgvCourseSelect.Columns["WeekPlan"].HeaderText = "برنامه هفتگی";
            //-------------Columns Width--------------
            DgvCourseSelect.Columns["Term"].Width = 30;
            DgvCourseSelect.Columns["LevelCourse"].Width = 50;
            DgvCourseSelect.Columns["Year"].Width = 50;
            DgvCourseSelect.Columns["Tuition"].Width = 80;
            DgvCourseSelect.Columns["ClassNumber"].Width = 70;
            DgvCourseSelect.Columns["AttendScore"].Width = 70;
            DgvCourseSelect.Columns["FinalScore"].Width = 70;
            DgvCourseSelect.Columns["ActivityScore"].Width = 70;
            DgvCourseSelect.Columns["Score"].Width = 70;
            DgvCourseSelect.Columns["ClassNumber"].Width = 70;
            if (DgvCourseSelect.Rows.Count == 1)
            {
                App_source.MsgBox.Show("هیچ رکوردی پیدا نشد", " انتخاب واحد");
            }
        }

        private void ButtonPrintCourseSelect_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DgvCourseSelect));
        }
    }
}
