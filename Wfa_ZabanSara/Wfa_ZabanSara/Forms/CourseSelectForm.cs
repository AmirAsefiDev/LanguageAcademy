using System.Windows.Forms;
using Wfa_ZabanSara.App_source;

namespace Wfa_ZabanSara.Forms
{
    public partial class CourseSelectForm : MasterForm.frmMaster
    {
        public CourseSelectForm()
        {
            InitializeComponent();
        }
        private void CourseSelectForm_Load(object sender, EventArgs e)
        {
            GetListCourseSelect();
            ClearText();

        }
        private void DgvCourseSelect_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvCourseSelect.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }
        private void ButtonStudentCourseSelect_Click(object sender, EventArgs e)
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

                    TextBoxStudentCourseSelect.Text = StudentName + " " + StudentLastName;
                    TextBoxStudentCourseSelect.Tag = searchStudent.DgvStudent.CurrentRow.Cells["ID"].Value.ToString();

                }
            }
        }

        private void ButtonCourseGroup_Click(object sender, EventArgs e)
        {
            SearchCourseGroupForm searchCourseGroup = new();
            searchCourseGroup.StrFormName = "فرم جستجوی گروه درسی";
            searchCourseGroup.ShowDialog();
            //----------------------------------------
            if (searchCourseGroup.SendParameter > 0)
            {
                if (searchCourseGroup.DgvCourseGroup.Rows.Count > 1)
                {
                    if (searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    string TeacherName = searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["teacherName"].Value.ToString();
                    string CourseTitle = searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["Title"].Value.ToString();

                    TextBoxCourseGroup.Text = CourseTitle + "(" + TeacherName + ")";
                    TextBoxCourseGroup.Tag = searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
        }


        private void ButtonNewCourseSelect_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CourseSelectBusiness ObjCourseSelectBusiness = new();
                CourseSelect ObjCourseSelect = FillData();
                if (ObjCourseSelectBusiness.Insert(ObjCourseSelect) == 0)
                {
                    MsgBox.Show("این دانشجو قبلا این انتخاب را انجام داده است", "انتخاب واحد");
                }
                else
                {
                    GetListCourseSelect();
                    MsgBox.Show("انتخاب واحد مورد نظر اضافه شد", "انتخاب واحد");
                    ClearText();
                }
            }
        }

        private void DgvCourseSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (DgvCourseSelect.Rows.Count > 1)
            {

                if (DgvCourseSelect.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                TextBoxStudentCourseSelect.Text = DgvCourseSelect.CurrentRow.Cells["StudentName"].Value.ToString();
                TextBoxStudentCourseSelect.Tag = DgvCourseSelect.CurrentRow.Cells["ID_FK_Student"].Value.ToString();

                string TeacherName = DgvCourseSelect.CurrentRow.Cells["teacherName"].Value.ToString();
                string CourseTitle = DgvCourseSelect.CurrentRow.Cells["Title"].Value.ToString();

                TextBoxCourseGroup.Text = CourseTitle + "(" + TeacherName + ")";
                TextBoxCourseGroup.Tag = DgvCourseSelect.CurrentRow.Cells["ID_FK_CourseGroup"].Value.ToString();
                TextBoxActivityScore.Text = DgvCourseSelect.CurrentRow.Cells["ActivityScore"].Value.ToString();
                TextBoxAttendScore.Text = DgvCourseSelect.CurrentRow.Cells["AttendScore"].Value.ToString();
                TextBoxFinalScore.Text = DgvCourseSelect.CurrentRow.Cells["FinalScore"].Value.ToString();
                TextBoxFinalScore.Tag = DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString();

            }
        }

        private void ButtonEditCourseSelect_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (TextBoxFinalScore.Tag.ToString() == string.Empty)
                {
                    MsgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                    return;
                }
                CourseSelectBusiness ObjCourseSelectBusiness = new();
                CourseSelect ObjCourseSelect = FillData();

                ObjCourseSelect.ID = int.Parse(TextBoxFinalScore.Tag.ToString());
                ObjCourseSelectBusiness.Update(ObjCourseSelect);
                GetListCourseSelect();
                MsgBox.Show(" انتخاب واحد مورد نظر ویرایش شد", "ویرایش انتخاب واحد");
                ClearText();
            }
        }

        private void ButtonDeleteCourseSelect_Click(object sender, EventArgs e)
        {
            if (TextBoxFinalScore.Tag.ToString() == string.Empty)
            {
                MsgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (App_source.MsgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2)
            == DialogResult.OK)
            {
                CourseSelectBusiness ObjCourseSelectBusiness = new();
                CourseSelect ObjCourseSelect = FillData();

                ObjCourseSelect.ID = int.Parse(TextBoxFinalScore.Tag.ToString());
                ObjCourseSelectBusiness.Delete(ObjCourseSelect);

                GetListCourseSelect();
                MsgBox.Show(" انتخاب واحد مورد نظر حذف شد", "حذف انتخاب واحد");
                ClearText();
            }
        }

        private void ButtonPrintCourseSelect_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGroupSelection_Click(object sender, EventArgs e)
        {

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

                    DgvCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Student.ID",TextBoxSearchStudent.Tag.ToString());
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
            if (searchCourseGroup.SendParameter > 0)
            {
                if (searchCourseGroup.DgvCourseGroup.Rows.Count > 1)
                {
                    if (searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    string TeacherName = searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["teacherName"].Value.ToString();
                    string CourseTitle = searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["Title"].Value.ToString();

                    TextBoxSearchCourseGroup.Text = CourseTitle + "(" + TeacherName + ")";
                    TextBoxSearchCourseGroup.Tag = searchCourseGroup.DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString();

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

        private void ButtonSearchMore_Click(object sender, EventArgs e)
        {
            //
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
            DgvCourseSelect.Columns["StudentName"].HeaderText = "دانشجو";
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
        }
        private bool ValidateData()
        {
            bool Result = true;
            errorProviderCourseSelect.Clear();

            if (TextBoxStudentCourseSelect.Text.Trim() == string.Empty)
            {
                errorProviderCourseSelect.SetError(TextBoxStudentCourseSelect, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }
            if (TextBoxCourseGroup.Text.Trim() == string.Empty)
            {
                errorProviderCourseSelect.SetError(TextBoxCourseGroup, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }

            if (TextBoxActivityScore.Text.Trim() == string.Empty)
                TextBoxActivityScore.Text = "0.00";

            if (TextBoxAttendScore.Text.Trim() == string.Empty)
                TextBoxAttendScore.Text = "0.00";

            if (TextBoxFinalScore.Text.Trim() == string.Empty)
                TextBoxFinalScore.Text = "0.00";

            decimal ActivityScore = Convert.ToDecimal(TextBoxActivityScore.Text.Trim());
            decimal AttendScore = Convert.ToDecimal(TextBoxAttendScore.Text.Trim());
            decimal FinalScore = Convert.ToDecimal(TextBoxFinalScore.Text.Trim());

            if ((ActivityScore + AttendScore + FinalScore) > 100)
            {
                MsgBox.Show("نمره کل نباید از 100 بیشتر باشد", "هشدار درج نمره");
                Result = false;
            }

            return Result;
        }

        private void ClearText()
        {
            TextBoxStudentCourseSelect.Text = string.Empty;
            TextBoxStudentCourseSelect.Tag = string.Empty;
            TextBoxCourseGroup.Text = string.Empty;
            TextBoxCourseGroup.Tag = string.Empty;
            TextBoxActivityScore.Text = "0.00";
            TextBoxActivityScore.Tag = string.Empty;
            TextBoxAttendScore.Text = "0.00";
            TextBoxAttendScore.Tag = string.Empty;
            TextBoxFinalScore.Text = "0.00";
            TextBoxFinalScore.Text = string.Empty;
        }

        public CourseSelect FillData()
        {
            CourseSelect courseSelect = new()
            {
                ID_FK_Student = int.Parse(TextBoxStudentCourseSelect.Tag.ToString()),
                ID_FK_CourseGroup = int.Parse(TextBoxCourseGroup.Tag.ToString()),
                ActivityScore = Convert.ToDecimal(TextBoxActivityScore.Text.ToString()),
                AttendScore = Convert.ToDecimal(TextBoxAttendScore.Text.ToString()),
                FinalScore = Convert.ToDecimal(TextBoxFinalScore.Text.ToString()),

            };
            return courseSelect;
        }

    }
}
