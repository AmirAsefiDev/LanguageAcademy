using BaseControl.ExtensionMethods;
using System.Data;
using Wfa_ZabanSara.App_source;
using Wfa_ZabanSara.App_source.BusinessLayer;
using Wfa_ZabanSara.App_source.Cpublic;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class TeacherForm : MasterForm.frmMaster
    {
        bool ChangePicture = false;
        public TeacherForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            DatePickerDateOfBirth.Value = DateTime.Now.ToString("yyyy/MM/dd");
            DatePickerDateOfBirth.InputMask = "0000/00/00";
            DatePickerDateOfBirth.RightToLeft = RightToLeft.No;
            DatePickerDateOfBirth.OnValueChanged += (obj, args) =>
            {
                DatePickerDateOfBirth.Tag = DatePickerDateOfBirth.Value.ConvertToDate();
            };
            DatePickerDateOfBirth.GetDropdownControl += () =>
            {
                var picker = new BaseControl.DateTimePicker();
                picker.OnDateDoubleClick += (obj, args) =>
                {
                    DatePickerDateOfBirth.CloseDropdown();
                };
                DatePickerDateOfBirth.Click += DatePickerDateOfBirth_Click;
                {
                    picker.SelectedDate = Convert.ToDateTime(DatePickerDateOfBirth.Value.ToString());
                }
                //if(DatePickerDateOfBirth != null)
                //{
                //    picker.SelectedDate = (DateTime)DatePickerDateOfBirth.Tag;
                //}
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    DatePickerDateOfBirth.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    DatePickerDateOfBirth.Tag = picker.SelectedDate.ToString();
                };
                return picker;
            };


            //GetListTeacher();
            ClearText();
            SetSettingOnlyOneRun();
        }

        private void DatePickerDateOfBirth_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ButtonChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new();
                open.Filter = "Image|*.jpg;*.bmp;*.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    PictureBoxTeacher.Image = Image.FromFile(open.FileName);
                    PictureBoxTeacher.Tag = open.FileName;
                    ChangePicture = true;
                }
            }
            catch
            {
                MsgBox.Show("عکس به درستی بالا نمی آید");
            }
        }

        private void ButtonSaveImage_Click(object sender, EventArgs e)
        {
            if (PictureBoxTeacher.Tag != null)
            {
                SaveFileDialog save = new();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    MyFile.CopyFile(PictureBoxTeacher.Tag.ToString(), save.FileName);
                    MsgBox.Show("عکس مورد نظر شما کپی شد", "کپی فایل");
                }
            }
        }

        private void DataGridViewTeacher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridViewTeacher.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                TeacherBusiness teacherBusiness = new();
                DataTable dt = teacherBusiness.DetailsByField("NationalCode", TextBoxNationalCode.Text);
                if (dt.Rows.Count > 0)
                {
                    MsgBox.Show("این کدملی وجود دارد", "هشدار");
                    return;
                }
                Teacher teacher = FillData();
                int ID = teacherBusiness.Insert(teacher);
                if (ID > 0)
                {
                    if (PictureBoxTeacher.Tag.ToString().Trim() != string.Empty)
                        MyFile.CopyFile(PictureBoxTeacher.Tag.ToString(),
                            MyFile.TeacherImage + ID.ToString() + ".jpg");

                }
                TextBoxNationalCode.Tag = ID;
                GetListTeacher();
                MsgBox.Show("استاد مورد نظر اضافه شد", "درج استاد");
                ClearText();
            }
        }


        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                TeacherBusiness business = new();
                if (TextBoxNationalCode.Tag.ToString() == string.Empty)
                {
                    MsgBox.Show("لطفا برروی رکورد مورد نظر کلیک کنید", "هشدار");
                    return;
                }
                Teacher teacher = FillData();
                teacher.ID = int.Parse(TextBoxNationalCode.Tag.ToString());
                business.Update(teacher);
                if (teacher.ID > 0)
                {
                    if (ChangePicture)
                    {
                        if (PictureBoxTeacher.Tag.ToString().Trim() != string.Empty)
                            MyFile.CopyFile(PictureBoxTeacher.Tag.ToString(), MyFile.TeacherImage + teacher.ID.ToString() + ".jpg");
                        ChangePicture = false;
                    }
                }
                GetListTeacher();
                MsgBox.Show("ویرایش استاد مورد نظر انجام شد", "ویرایش استاد");
                ClearText();
            }
        }
        private void DataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (DataGridViewTeacher.Rows.Count > 1)
            {
                if (DataGridViewTeacher.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;

                TextBoxNationalCode.Text = DataGridViewTeacher.CurrentRow.Cells["NationalCode"].Value.ToString();
                TextBoxNationalCode.Tag = DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString();
                TextBoxName.Text = DataGridViewTeacher.CurrentRow.Cells["Name"].Value.ToString();
                TextBoxLastName.Text = DataGridViewTeacher.CurrentRow.Cells["LastName"].Value.ToString();
                ComboBox_ID_FK_Degree.SelectedValue = DataGridViewTeacher.CurrentRow.Cells["ID_FK_Degree"].Value.ToString();
                ComboBoxSex.Text = DataGridViewTeacher.CurrentRow.Cells["Sex"].Value.ToString();
                DatePickerDateOfBirth.Value = DataGridViewTeacher.CurrentRow.Cells["DateOfBirth"].Value.ToString();
                TextBoxPhone.Text = DataGridViewTeacher.CurrentRow.Cells["Phone"].Value.ToString();
                TextBoxAddress.Text = DataGridViewTeacher.CurrentRow.Cells["Address"].Value.ToString();
                if (File.Exists(MyFile.TeacherImage + TextBoxNationalCode.Tag.ToString() + ".jpg"))
                {
                    PictureBoxTeacher.Image = Image.FromFile(MyFile.TeacherImage + TextBoxNationalCode.Tag.ToString() + ".jpg");
                    PictureBoxTeacher.Tag = MyFile.StudentImage + TextBoxNationalCode.Tag.ToString();
                }
                else
                {
                    PictureBoxTeacher.Image = null;
                }
            }
            else
                GetListTeacher();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            TeacherBusiness business = new();
            if (TextBoxNationalCode.Tag == null || string.IsNullOrEmpty(TextBoxNationalCode.Tag.ToString()))
            {
                MsgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (MsgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2) == DialogResult.OK)
            {
                Teacher teacher = new();
                teacher.ID = int.Parse(TextBoxNationalCode.Tag.ToString());
                business.Delete(teacher);
                if (teacher.ID > 0)
                {
                    if (PictureBoxTeacher.Tag.ToString().Trim() != string.Empty)
                    {
                        PictureBoxTeacher.Image = null;
                        MyFile.DeleteFile(MyFile.TeacherImage + teacher.ID.ToString() + ".jpg");
                    }
                }
                GetListTeacher();
                MsgBox.Show("استاد مورد نظر حذف شد", "حذف استاد");
                ClearText();
            }
        }

        private void ButtonSearchNationalCode_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchNationalCode.Text.Trim().Length >= 2)
            {
                TeacherBusiness business = new();
                DataGridViewTeacher.DataSource = business.DetailsByField("NationalCode", TextBoxSearchNationalCode.Text.Trim());
                SetSettingTeacher();
            }
            else
                MsgBox.Show("مقدار کد ملی را به درستی وارد کنید", "هشدار");
        }

        private void ButtonSearchName_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchName.Text.Trim().Length >= 2)
            {
                TeacherBusiness Business = new();
                DataGridViewTeacher.DataSource = Business.DetailsByField("Name", TextBoxSearchName.Text.Trim());
                SetSettingTeacher();
            }
            else
                MsgBox.Show("مقدار نام را به درستی وارد کنید", "هشدار");

        }

        private void ButtonSearchLastName_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchLastName.Text.Trim().Length >= 2)
            {
                TeacherBusiness business = new();
                DataGridViewTeacher.DataSource = business.DetailsByField("LastName", TextBoxSearchLastName.Text.Trim());
                SetSettingTeacher();
            }
            else
                MsgBox.Show("مقدار نام خانوادگی را به درستی وارد کنید", "هشدار");
        }

        private void ButtonSearchMore_Click(object sender, EventArgs e)
        {
            SearchTeacherForm search = new();
            search.StrFormName = "فرم جستجوی استادان";
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

                    TextBoxNationalCode.Text = search.DataGridViewTeacher.CurrentRow.Cells["NationalCode"].Value.ToString();
                    TextBoxNationalCode.Tag = search.DataGridViewTeacher.CurrentRow.Cells["ID"].Value.ToString();
                    TextBoxName.Text = search.DataGridViewTeacher.CurrentRow.Cells["Name"].Value.ToString();
                    TextBoxLastName.Text = search.DataGridViewTeacher.CurrentRow.Cells["LastName"].Value.ToString();
                    TextBoxAddress.Text = search.DataGridViewTeacher.CurrentRow.Cells["Address"].Value.ToString();
                    TextBoxPhone.Text = search.DataGridViewTeacher.CurrentRow.Cells["Phone"].Value.ToString();
                    DatePickerDateOfBirth.Value = search.DataGridViewTeacher.CurrentRow.Cells["DateOfBirth"].Value.ToString();
                    ComboBoxSex.Text = search.DataGridViewTeacher.CurrentRow.Cells["Sex"].Value.ToString();
                    ComboBox_ID_FK_Degree.SelectedValue = search.DataGridViewTeacher.CurrentRow.Cells["ID_FK_Degree"].Value.ToString();
                    if (File.Exists(MyFile.TeacherImage + TextBoxNationalCode.Tag.ToString() + ".jpg"))
                    {
                        PictureBoxTeacher.Image = Image.FromFile(MyFile.TeacherImage + TextBoxNationalCode.Tag.ToString() + ".jpg");
                        PictureBoxTeacher.Tag = MyFile.TeacherImage + TextBoxNationalCode.Tag.ToString() + ".jpg";
                    }

                    else
                        PictureBoxTeacher.Image = null;
                }
            }


        }


        private void GetListTeacher()
        {
            if (TextBoxNationalCode.Tag.ToString() != string.Empty)
            {
                StudentBusiness b = new StudentBusiness();
                DataGridViewTeacher.DataSource = b.DetailsByField("Teacher.ID", TextBoxNationalCode.Tag.ToString());
                SetSettingTeacher();
            }
            else
                DataGridViewTeacher.DataSource = null;

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

            if (DataGridViewTeacher.Rows.Count == 1)
            {
                MsgBox.Show("برای مقدار وارد شده هیچ رکوردی پیدا نشد", "هشدار");
            }
        }

        private void SetSettingOnlyOneRun()
        {
            ComboBox_ID_FK_Degree.DataSource = new BusinessDegree().GetList();
            //----------------------------------------------------------------
            ComboBox_ID_FK_Degree.DisplayMember = "Title";
            ComboBox_ID_FK_Degree.ValueMember = "ID";
            ComboBox_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBox_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.ListItems;
            //----------------------------------------------------------------
            ComboBoxSex.Text = "انتخاب کنید";
            ComboBoxSex.Items.Add("زن");
            ComboBoxSex.Items.Add("مرد");
        }

        private bool ValidateData()
        {
            errorProviderTeacher.Clear();

            bool result = true;

            if (TextBoxNationalCode.Text.Trim() == string.Empty || TextBoxNationalCode.Text.Trim().Length != 10)
            {
                errorProviderTeacher.SetError(TextBoxNationalCode, "لطفا مقدار کد ملی را درست وارد کنید");
                result = false;
            }
            if (TextBoxName.Text.Trim() == string.Empty)
            {
                errorProviderTeacher.SetError(TextBoxName, "لطفا مقدار نام را وارد کنید");
                result = false;
            }
            if (TextBoxLastName.Text.Trim() == string.Empty)
            {
                errorProviderTeacher.SetError(TextBoxLastName, "لطفا مقدار نام خانوادگی را وارد کنید");
                result = false;
            }
            if (ComboBoxSex.SelectedIndex == -1)
            {
                errorProviderTeacher.SetError(ComboBoxSex, "لطفا مقدار جنسیت را انتخاب کنید");
                result = false;
            }
            if (TextBoxPhone.Text.Trim() == string.Empty || TextBoxPhone.Text.Trim().Length != 11)
            {
                errorProviderTeacher.SetError(TextBoxPhone, "لطفا مقدار تلفن را درست وارد کنید");
                result = false;
            }
            return result;
        }
        private Teacher FillData()
        {
            Teacher teacher = new()
            {
                Name = TextBoxName.Text.Trim(),
                LastName = TextBoxLastName.Text.Trim(),
                NationalCode = TextBoxNationalCode.Text.Trim(),
                Phone = TextBoxPhone.Text.Trim(),
                ID_FK_Degree = int.Parse(ComboBox_ID_FK_Degree.SelectedValue.ToString()),
                Sex = Convert.ToByte(ComboBoxSex.SelectedIndex),
                DateOfBirth = DatePickerDateOfBirth.Value,
                Address = TextBoxAddress.Text,
            };
            return teacher;
        }

        private void ClearText()
        {
            TextBoxName.Text = string.Empty;
            TextBoxLastName.Text = string.Empty;
            TextBoxNationalCode.Text = string.Empty;
            TextBoxNationalCode.Tag = string.Empty;
            ComboBox_ID_FK_Degree.Text = "A1";
            ComboBoxSex.Text = "انتخاب کنید";
            DatePickerDateOfBirth.Value = DateTime.Now.ToString();
            TextBoxPhone.Text = string.Empty;
            TextBoxAddress.Text = string.Empty;
            //----------------------------------
            PictureBoxTeacher.Tag = string.Empty;
            PictureBoxTeacher.Image = null;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DataGridViewTeacher));
        }
    }
}
