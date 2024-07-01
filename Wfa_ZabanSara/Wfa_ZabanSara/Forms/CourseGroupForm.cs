using System.Data;
using System.Globalization;
using Wfa_ZabanSara.App_source;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class CourseGroupForm : MasterForm.frmMaster
    {
        public CourseGroupForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void CourseGroupForm_Load(object sender, EventArgs e)
        {
            GetListCourseGroup();
            ClearText();
        }
        private void DgvCourseGroup_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvCourseGroup.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }
        private void ButtonCourseName_Click(object sender, EventArgs e)
        {
            SearchCourseForm searchCourseForm = new();
            searchCourseForm.StrFormName = "فرم جستجوی درس";
            searchCourseForm.ShowDialog();
            //----------------------------
            if (searchCourseForm.SendParameter > 0)
            {
                if (searchCourseForm.DataGridViewSearchCourse.Rows.Count > 1)
                {
                    if (searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    TextBoxCourseName.Text = searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["title"].Value.ToString();
                    TextBoxCourseName.Tag = searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    TextBoxTuition.Text = searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["Tuition"].Value.ToString();
                    int LevelCount = int.Parse(searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["LevelCount"].Value.ToString());
                    ComboBoxLevelCourse.Text = "انتخاب کنید";
                    ComboBoxLevelCourse.Items.Clear();
                    for (int i = 1; i <= LevelCount; i++)
                    {
                        ComboBoxLevelCourse.Items.Add(i);
                    }


                }
            }
        }

        private void ButtonSearchTeacher_Click(object sender, EventArgs e)
        {
            SearchTeacherForm search = new();
            search.StrFormName = "فرم جستجوی استاد";
            search.ShowDialog();
            //----------------------------------------
            if (search.SendParameter > 0)
            {
                if (search.DataGridViewTeacher.Rows.Count > 1)
                {
                    if (search.DataGridViewTeacher.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (search.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    TextBoxTeacherCourse.Text = search.DataGridViewTeacher.CurrentRow.Cells["Name"].Value.ToString() + " " + search.DataGridViewTeacher.CurrentRow.Cells["LastName"].Value.ToString();
                    TextBoxTeacherCourse.Tag = search.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
        }

        private void ButtonNewCourseGroup_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CourseGroupBusiness ObjCourseGroupBusiness = new();
                CourseGroup courseGroup = FillData();

                TextBoxTuition.Tag = ObjCourseGroupBusiness.Insert(courseGroup);

                GetListCourseGroup();
                MsgBox.Show("درس مورد نظر اضافه شد", "درج درس");
                ClearText();
            }
        }
        private void ButtonEditCourseGroup_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (TextBoxTuition.Tag.ToString() == string.Empty)
                {
                    MsgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                    return;
                }
                CourseGroupBusiness ObjCourseGroupBusiness = new CourseGroupBusiness();
                CourseGroup courseGroup = FillData();
                courseGroup.ID = int.Parse(TextBoxTuition.Tag.ToString());

                ObjCourseGroupBusiness.Update(courseGroup);

                GetListCourseGroup();
                MsgBox.Show("گروه درس مورد نظر ویرایش شد", "درج گروه درسی");
                ClearText();
            }
        }
        private void DgvCourseGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (DgvCourseGroup.Rows.Count > 1)
            {
                if (DgvCourseGroup.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;

                TextBoxTuition.Tag = DgvCourseGroup.CurrentRow.Cells["ID"].Value.ToString();
                TextBoxTeacherCourse.Tag = DgvCourseGroup.CurrentRow.Cells["ID_FK_Teacher"].Value.ToString();
                TextBoxTeacherCourse.Text = DgvCourseGroup.CurrentRow.Cells["teacherName"].Value.ToString();
                TextBoxCourseName.Tag = DgvCourseGroup.CurrentRow.Cells["ID_FK_Course"].Value.ToString();
                TextBoxCourseName.Text = DgvCourseGroup.CurrentRow.Cells["Title"].Value.ToString();
                //--------------GetAllLevel---------
                DataTable dt = new CourseBusiness().DetailsByField("ID", TextBoxCourseName.Tag.ToString());
                byte LevelCount = dt.Rows[0].Field<byte>("LevelCount");
                ComboBoxLevelCourse.Items.Clear();
                for (int i = 1; i <= LevelCount; i++)
                {
                    ComboBoxLevelCourse.Items.Add(i);
                }
                ComboBoxLevelCourse.Text = DgvCourseGroup.CurrentRow.Cells["LevelCourse"].Value.ToString();
                TextBoxTuition.Text = DgvCourseGroup.CurrentRow.Cells["Tuition"].Value.ToString();
                TextBoxCourseYear.Text = DgvCourseGroup.CurrentRow.Cells["Year"].Value.ToString();
                TextBoxTerm.Text = DgvCourseGroup.CurrentRow.Cells["Term"].Value.ToString();
                TextBoxClassNumber.Text = DgvCourseGroup.CurrentRow.Cells["ClassNumber"].Value.ToString();
                TextBoxWeekPlan.Text = DgvCourseGroup.CurrentRow.Cells["WeekPlan"].Value.ToString();
            }
            else
                GetListCourseGroup();
        }

        private void ButtonDeleteCourseGroup_Click(object sender, EventArgs e)
        {
            if (TextBoxTuition.Tag.ToString() == string.Empty)
            {
                MsgBox.Show("لطفا برروی سطر مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (MsgBox.Show("آیا می خواهید این رکورد حذف شود", "حذف گروه درس", 2) == DialogResult.OK)
            {
                CourseGroupBusiness ObjCourseGroupBusiness = new();
                CourseGroup ObjCourseGroup = FillData();
                ObjCourseGroup.ID = int.Parse(TextBoxTuition.Tag.ToString());
                ObjCourseGroupBusiness.Delete(ObjCourseGroup);
            }

            GetListCourseGroup();
            MsgBox.Show("گروه درس مورد نظر شما حذف شد", "حذف گروه درس");
            ClearText();
        }

        private void ButtonPrintCourseGroup_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DgvCourseGroup));
        }

        private void ButtonSearchCourseTeacher_Click(object sender, EventArgs e)
        {
            SearchTeacherForm searchTeacherForm = new();
            searchTeacherForm.StrFormName = "فرم جستجوی استاد";
            searchTeacherForm.ShowDialog();
            //-------------------------
            if (searchTeacherForm.SendParameter > 0)
            {
                if (searchTeacherForm.DataGridViewTeacher.Rows.Count > 1)
                {
                    if (searchTeacherForm.DataGridViewTeacher.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchTeacherForm.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    TextBoxSearchCourseTeacher.Text = searchTeacherForm.DataGridViewTeacher.CurrentRow.Cells["Name"].Value.ToString() + " " +
                        searchTeacherForm.DataGridViewTeacher.CurrentRow.Cells["LastName"].Value.ToString();
                    TextBoxSearchCourseTeacher.Tag = searchTeacherForm.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString();

                    DgvCourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("ID_FK_Teacher", TextBoxSearchCourseTeacher.Tag.ToString());
                    SetSettingCourseGroup();

                    if (DgvCourseGroup.Rows.Count < 2)
                    {
                        MsgBox.Show("برای این استاد گروه درس تعریف نشده");
                    }

                }
            }

        }

        private void ButtonSearchCourseName_Click(object sender, EventArgs e)
        {
            SearchCourseForm searchCourseForm = new();
            searchCourseForm.StrFormName = "فرم جستجوی درس";
            searchCourseForm.ShowDialog();
            //------------------------------------
            if (searchCourseForm.SendParameter > 0)
            {
                if (searchCourseForm.DataGridViewSearchCourse.Rows.Count > 1)
                {
                    if (searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    TextBoxSearchCourseName.Text = searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["Title"].Value.ToString();
                    TextBoxSearchCourseName.Tag = searchCourseForm.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString();

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

        private void ButtonSearchMore_Click(object sender, EventArgs e)
        {
            SearchCourseGroupForm searchForm = new();
            searchForm.StrFormName = "فرم جستجوی گروه درسی";
            searchForm.ShowDialog();
            //---------------------------------------------
            if (searchForm.SendParameters > 0)
            {
                if (searchForm.DgvCourseSelect.Rows.Count > 1)
                {
                    if (searchForm.DgvCourseSelect.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchForm.DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    TextBoxTuition.Tag = searchForm.DgvCourseSelect.CurrentRow.Cells["ID"].Value.ToString();
                    TextBoxTeacherCourse.Tag = searchForm.DgvCourseSelect.CurrentRow.Cells["ID_FK_Teacher"].Value.ToString();
                    TextBoxCourseName.Tag = searchForm.DgvCourseSelect.CurrentRow.Cells["ID_FK_Course"].Value.ToString();
                    TextBoxTeacherCourse.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["teacherName"].Value.ToString();
                    TextBoxCourseName.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["Title"].Value.ToString();

                    //--------GetAllLevels------

                    DataTable Dt = new CourseBusiness().DetailsByField("ID", TextBoxCourseName.Tag.ToString());
                    byte levelCount = Dt.Rows[0].Field<byte>("LevelCount");
                    ComboBoxLevelCourse.Items.Clear();
                    for (int i = 1; i < levelCount; i++)
                    {
                        ComboBoxLevelCourse.Items.Add(i);
                    }

                    ComboBoxLevelCourse.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["LevelCourse"].Value.ToString();

                    TextBoxTuition.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["Tuition"].Value.ToString();
                    TextBoxCourseYear.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["Year"].Value.ToString();
                    TextBoxTerm.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["Term"].Value.ToString();
                    TextBoxClassNumber.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["ClassNumber"].Value.ToString();
                    TextBoxWeekPlan.Text = searchForm.DgvCourseSelect.CurrentRow.Cells["WeekPlan"].Value.ToString();
                }
            }
        }



        private void GetListCourseGroup()
        {
            ////if (TextBoxTuition.Tag == null)
            //if (TextBoxTuition.Tag.ToString() != string.Empty)
            //{
            //    CourseGroupBusiness courseGroupBusiness = new();
            //    DgvCourseGroup.DataSource = courseGroupBusiness.DetailsByField("CourseGroup.ID",TextBoxTuition.Tag.ToString());
            //    SetSettingCourseGroup();
            //}
            //else
            //    DgvCourseGroup.DataSource = null;
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
        public CourseGroup FillData()
        {
            CourseGroup courseGroup = new()
            {
                ID_FK_Course = int.Parse(TextBoxCourseName.Tag.ToString()),
                ID_FK_Teacher = int.Parse(TextBoxTeacherCourse.Tag.ToString()),
                LevelCourse = Convert.ToByte(ComboBoxLevelCourse.SelectedIndex + 1),
                Term = Convert.ToByte(TextBoxTerm.Text),
                Year = Convert.ToInt16(TextBoxCourseYear.Text),
                WeekPlan = TextBoxWeekPlan.Text,
                Tuition = TextBoxTuition.Text,
                ClassNumber = Convert.ToByte(TextBoxClassNumber.Text)
            };
            return courseGroup;
        }
        private bool ValidateData()
        {
            errorProviderCourseGroup.Clear();
            bool result = true;

            if (TextBoxCourseName.Text.Trim() == string.Empty)
            {
                errorProviderCourseGroup.SetError(TextBoxCourseName, "درس مورد نظر را انتخاب نمایید");
                result = false;
            }
            if (TextBoxTuition.Text.Trim() == string.Empty)
            {
                errorProviderCourseGroup.SetError(TextBoxTuition, "مقدار شهریه را وارد کنید");
                result = false;
            }
            if (ComboBoxLevelCourse.SelectedIndex == -1)
            {
                errorProviderCourseGroup.SetError(ComboBoxLevelCourse, "سطح مورد نظر خود را انتخاب کنید");
                result = false;
            }
            if (TextBoxTeacherCourse.Text.Trim() == string.Empty)
            {
                errorProviderCourseGroup.SetError(TextBoxTeacherCourse, "استاد مورد نظر را انتخاب نمایید");
                result = false;
            }
            if (TextBoxTerm.Text.Trim() == string.Empty)
            {
                errorProviderCourseGroup.SetError(TextBoxTerm, "ترم مورد نظر خود را وارد کنید");
                result = false;
            }
            if (TextBoxClassNumber.Text.Trim() == string.Empty)
            {
                errorProviderCourseGroup.SetError(TextBoxClassNumber, "نام کلاس مورد نظر را وارد کنید");
                result = false;
            }
            if (TextBoxWeekPlan.Text.Trim() == string.Empty)
            {
                errorProviderCourseGroup.SetError(TextBoxWeekPlan, "زمان مد نطر خود را برای کلاس وارد کنید");
                result = false;
            }
            return result;
        }
        private void ClearText()
        {
            TextBoxCourseName.Text = string.Empty;
            TextBoxCourseName.Tag = string.Empty;
            TextBoxTuition.Text = string.Empty;
            ComboBoxLevelCourse.Items.Clear();
            TextBoxTeacherCourse.Text = string.Empty;
            TextBoxTeacherCourse.Tag = string.Empty;
            TextBoxWeekPlan.Text = string.Empty;
            TextBoxClassNumber.Text = string.Empty;
            TextBoxTerm.Text = string.Empty;
            ComboBoxLevelCourse.Text = "انتخاب کنید";
            TextBoxTuition.Tag = string.Empty; //برای کد گروهی درسی
            //-----------------------GetYear--------------------
            PersianCalendar p = new();
            DateTime date = new();
            date = DateTime.Parse(DateTime.Now.ToShortDateString());
            int year = p.GetYear(date);
            TextBoxCourseYear.Text = year.ToString();
        }


    }
}
