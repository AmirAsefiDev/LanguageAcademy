using System.Data;
using Wfa_ZabanSara.App_source;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class CourseForm : Forms.MasterForm.frmMaster
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            //GetListCourse();
            ClearText();
        }

        private void DataGridViewCourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCourse.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        // this function Add new Course to Database so it'has Title,LevelCount,Tuition
        private void ButtonNewCource_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CourseBusiness courseBusiness = new();
                DataTable dt = courseBusiness.DetailsByField("Title", TextBoxTitle.Text.Trim());
                //here we're checking to we don't have extra record 
                if (dt.Rows.Count > 0)
                {
                    MsgBox.Show("این درس وجود دارد لطفا درس دیگری را وارد کنید", "هشدار");
                    return;
                }

                Course course = FillDataCourse();

                //courseBusiness.Insert(course);
                int Id = courseBusiness.Insert(course);
                 TextBoxTitle.Tag = Id;
                GetListCourse();
                MsgBox.Show("درس مورد نظر اضافه شد", "درج درس");
                ClearText();
            }
        }

        // this function gives information to controls of DataGridView and they using this information to Deleting,Editing Course
        private void DataGridViewCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (DataGridViewCourse.Rows.Count > 1)
            {
                if (DataGridViewCourse.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DataGridViewCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;

                TextBoxTitle.Text = DataGridViewCourse.CurrentRow.Cells["Title"].Value.ToString();
                TextBoxTitle.Tag = DataGridViewCourse.CurrentRow.Cells["ID"].Value.ToString();
                TextBoxLevelCount.Text = DataGridViewCourse.CurrentRow.Cells["LevelCount"].Value.ToString();
                TextBoxTuition.Text = DataGridViewCourse.CurrentRow.Cells["Tuition"].Value.ToString();
            }
            else
                GetListCourse();
        }

        // this function Update Course to Database so it'has Title,LevelCount,Tuition
        private void ButtonEditCourse_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CourseBusiness courseBusiness = new();
                if (TextBoxTitle.Tag.ToString() == string.Empty)
                {
                    MsgBox.Show("لطفا برروی رکورد مورد نظر کلیک کنید", "هشدار");
                    return;
                }
                Course course = FillDataCourse();
                course.ID = int.Parse(TextBoxTitle.Tag.ToString());
                courseBusiness.Update(course);
                GetListCourse();
                MsgBox.Show("ویرایش درس مورد نظر انجام شد", "ویرایش درس");
                ClearText();
            }
        }

        // this function Delete Course to Database so it'has Title,LevelCount,Tuition
        private void ButtonDeleteCourse_Click(object sender, EventArgs e)
        {
            CourseBusiness courseBusiness = new();
            if (TextBoxTitle.Tag == null || string.IsNullOrEmpty(TextBoxTitle.Tag.ToString()))
            {
                MsgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (MsgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2) == DialogResult.OK)
            {
                Course course = new();
                course.ID = int.Parse(TextBoxTitle.Tag.ToString());
                courseBusiness.Delete(course);
                GetListCourse();
                MsgBox.Show("درس مورد نظر شما پاک شد", "حذف استاد");
                ClearText();
            }
        }

        //when user click on this button We gonna Check the Course Id Exists or not by TextBoxTitle
        private void ButtonSearchTitle_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchTitle.Text.Trim().Length >= 2)
            {
                CourseBusiness courseBusiness = new();
                DataGridViewCourse.DataSource = courseBusiness.DetailsByField("Title", TextBoxSearchTitle.Text.Trim());
                SetSettingCourse();
            }
            else
                MsgBox.Show("مقدار نام درس را به درستی وارد کنید", "هشدار");
        }

        //After click you go to the SearchFromCourse To Seaching Better about course 
        private void ButtonSearchMore_Click(object sender, EventArgs e)
        {
            SearchCourseForm search = new();
            search.StrFormName = "فرم جستجوی درس";
            search.ShowDialog();
            //----------------------------------------
            if (search.SendParameter > 0)
            {
                if (search.DataGridViewSearchCourse.Rows.Count > 1)
                {
                    if (search.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (search.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    TextBoxTitle.Text = search.DataGridViewSearchCourse.CurrentRow.Cells["Title"].Value.ToString();
                    TextBoxTitle.Tag = search.DataGridViewSearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    TextBoxLevelCount.Text = search.DataGridViewSearchCourse.CurrentRow.Cells["LevelCount"].Value.ToString();
                    TextBoxTuition.Text = search.DataGridViewSearchCourse.CurrentRow.Cells["Tuition"].Value.ToString();
                }
            }
        }
        private void ButtonPrintCourse_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DataGridViewCourse));
        }

        //this method get all information about Course Table in Database to dataGridView
        private void GetListCourse()
        {
            if (TextBoxTitle.Tag.ToString() != string.Empty)
            {
                CourseBusiness b = new CourseBusiness();
                DataGridViewCourse.DataSource = b.DetailsByField("Course.ID", TextBoxTitle.Tag.ToString());
                SetSettingCourse();
            }
            else
                DataGridViewCourse.DataSource = null;
        }

        // this method edit ColumnName to persian to user
        public void SetSettingCourse()
        {
            DataGridViewCourse.Columns["ID"].Visible = false;
            DataGridViewCourse.Columns["Title"].HeaderText = "نام درس";
            DataGridViewCourse.Columns["LevelCount"].HeaderText = "تعداد سطح";
            DataGridViewCourse.Columns["Tuition"].HeaderText = "شهریه";

            if (DataGridViewCourse.Rows.Count == 1)
            {
                MsgBox.Show("برای مقدار وارد شده هیچ رکوردی پیدا نشد");
            }
        }

        // this method ckeck All controls like textbox that they don't empty
        private bool ValidateData()
        {
            errorProviderCourse.Clear();

            bool result = true;

            if (TextBoxTitle.Text.Trim() == string.Empty)
            {
                errorProviderCourse.SetError(TextBoxTitle, "لطفا نام درس را وارد کنید");
                result = false;
            }
            if (TextBoxLevelCount.Text.Trim() == string.Empty)
            {
                errorProviderCourse.SetError(TextBoxLevelCount, "لطفا تعداد سطح را وارد کنید");
                result = false;
            }
            if (TextBoxTuition.Text.Trim() == string.Empty)
            {
                errorProviderCourse.SetError(TextBoxTuition, "لطفا مقدار شهریه را وارد کنید");
                result = false;
            }

            return result;
        }

        //This function clean all controls in form after any action like add,edit.all controls become to empty version
        private void ClearText()
        {
            TextBoxTitle.Text = string.Empty;
            TextBoxTitle.Tag = string.Empty;
            TextBoxLevelCount.Text = string.Empty;
            TextBoxTuition.Text = string.Empty;
        }

        //this function takes information of controls and save them to Class 
        //and after that transfer to database by Business,DataLayer after checking
        private Course FillDataCourse()
        {
            Course course = new()
            {
                Title = TextBoxTitle.Text.Trim(),
                LevelCount = Convert.ToByte(TextBoxLevelCount.Text.Trim()),
                Tuition = TextBoxTuition.Text.Trim(),
            };
            return course;
        }


    }
}
