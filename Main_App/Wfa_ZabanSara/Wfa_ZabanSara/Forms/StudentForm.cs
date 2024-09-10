using BaseControl.ExtensionMethods;
using System.Data;
using System.Windows.Forms;
using Wfa_ZabanSara.App_source;
using Wfa_ZabanSara.App_source.BusinessLayer;
using Wfa_ZabanSara.App_source.Cpublic;
using winprint;

namespace Wfa_ZabanSara.Forms
{
    public partial class StudentForm : MasterForm.frmMaster
    {
        bool ChangePicture = false;
        public StudentForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void StudentForm_Load(object sender, EventArgs e)
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
                //if (DatePickerDateOfBirth.Tag != null)
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

            //GetListStudent();
            ClearText();
            SetSettingOnlyOneRun();
        }

        private void DatePickerDateOfBirth_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DgvStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvStudent.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        public Student FillData()
        {
            Student st = new();

            st.Name = TextBoxName.Text.Trim();
            st.LastName = TextBoxLastName.Text.Trim();
            st.NationalCode = TextBoxNationalCode.Text;
            st.Phone = TextBoxPhone.Text.Trim();
            st.Sex = Convert.ToByte(ComboBoxSex.SelectedIndex);
            st.Address = TextBoxAddress.Text;
            st.DateofBirth = DatePickerDateOfBirth.Value;
            st.ID_FK_Degree = int.Parse(ComboBox_ID_FK_Degree.SelectedValue.ToString());

            return st;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

                StudentBusiness stb = new();
                DataTable dt = stb.DetailsByField("NationalCode", TextBoxNationalCode.Text);
                if (dt.Rows.Count > 0)
                {
                    MsgBox.Show("این کدملی وجود دارد", "هشدار");
                    return;
                }
                Student st = FillData();
                int ID = stb.Insert(st);
                if (ID > 0)
                {
                    if (pictureBoxStudent.Tag.ToString().Trim() != string.Empty)
                        MyFile.CopyFile(pictureBoxStudent.Tag.ToString(), MyFile.StudentImage + ID.ToString() + ".jpg");
                    st.ID = ID;
                    st.Image = MyFile.StudentImage + ID.ToString() + ".jpg";
                    stb.Update(st);
                }
                TextBoxNationalCode.Tag = ID;
                GetListStudent();
                MsgBox.Show("دانش آموز مورد نظر اضافه شد", "درج دانش آموز");
                ClearText();

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

                StudentBusiness stb = new();
                if (TextBoxNationalCode.Tag.ToString() == string.Empty)
                {
                    MsgBox.Show("لطفا بر روی رکورد مرود نظر کلیک کنید", "هشدار");
                    return;
                }
                Student st = FillData();
                st.ID = int.Parse(TextBoxNationalCode.Tag.ToString());
                stb.Update(st);
                if (st.ID > 0)
                {
                    if (ChangePicture)
                    {
                        if (pictureBoxStudent.Tag.ToString().Trim() != string.Empty)
                            MyFile.CopyFile(pictureBoxStudent.Tag.ToString(), MyFile.StudentImage + st.ID.ToString() + ".jpg");
                    }

                }
                GetListStudent();
                MsgBox.Show("دانش آموز مورد نظر اصلاح شد", "درج دانش آموز");
                ClearText();

            }
        }

        private void DgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (DgvStudent.Rows.Count > 1)
            {
                if (DgvStudent.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (DgvStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;

                TextBoxNationalCode.Text = DgvStudent.CurrentRow.Cells["NationalCode"].Value.ToString();
                TextBoxNationalCode.Tag = DgvStudent.CurrentRow.Cells["ID"].Value.ToString();
                TextBoxName.Text = DgvStudent.CurrentRow.Cells["Name"].Value.ToString();
                TextBoxLastName.Text = DgvStudent.CurrentRow.Cells["LastName"].Value.ToString();
                TextBoxAddress.Text = DgvStudent.CurrentRow.Cells["Address"].Value.ToString();
                TextBoxPhone.Text = DgvStudent.CurrentRow.Cells["Phone"].Value.ToString();
                DatePickerDateOfBirth.Text = DgvStudent.CurrentRow.Cells["DateOfBirth"].Value.ToString();
                ComboBoxSex.Text = DgvStudent.CurrentRow.Cells["Sex"].Value.ToString();
                ComboBox_ID_FK_Degree.SelectedValue = DgvStudent.CurrentRow.Cells["ID_FK_Degree"].Value.ToString();
                if (File.Exists(MyFile.StudentImage + TextBoxNationalCode.Tag.ToString() + ".jpg"))
                {
                    pictureBoxStudent.Image = Image.FromFile(MyFile.StudentImage + TextBoxNationalCode.Tag.ToString() + ".jpg");
                    pictureBoxStudent.Tag = MyFile.StudentImage + TextBoxNationalCode.Tag.ToString() + ".jpg";
                }

                else
                    pictureBoxStudent.Image = null;
            }
            else
                GetListStudent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            StudentBusiness stb = new();
            if (TextBoxNationalCode.Tag.ToString() == string.Empty)
            {
                MsgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (MsgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2) == DialogResult.OK)
            {
                Student st = new();
                st.ID = int.Parse(TextBoxNationalCode.Tag.ToString());
                stb.Delete(st);
                if (st.ID > 0)
                {
                    if (pictureBoxStudent.Tag.ToString().Trim() != string.Empty)
                    {
                        pictureBoxStudent.Image = null;
                        MyFile.DeleteFile(MyFile.StudentImage + st.ID.ToString() + ".jpg");
                    }

                }
                GetListStudent();
                MsgBox.Show("دانش آموز مورد نظر حذف شد", "حذف دانش آموز");
                ClearText();
            }
        }

        private void ButtonOpenImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new();
                op.Filter = "Image|*.jpg;*.bmp;*.png;";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStudent.Image = Image.FromFile(op.FileName);
                    pictureBoxStudent.Tag = op.FileName;
                    ChangePicture = true;
                }
            }
            catch
            {
                MsgBox.Show("عکس به درستی بالا نمی آید");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBoxStudent.Tag != null)
            {
                SaveFileDialog s = new();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    MyFile.CopyFile(pictureBoxStudent.Tag.ToString(), s.FileName);
                    MsgBox.Show("عکس مورد نظر شما کپی شد", "کپی فایل");
                }
            }
        }

        private void ButtonSearchNationalCode_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchNationalCode.Text.Trim().Length >= 2)
            {
                StudentBusiness b = new StudentBusiness();
                DgvStudent.DataSource = b.DetailsByField("NationalCode", TextBoxSearchNationalCode.Text.Trim());
                SetSettingStudent();
            }
            else
                MsgBox.Show("مقدار کد ملی را به درستی وارد کنید", "هشدار");

        }

        private void ButtonSearchName_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchName.Text.Trim().Length >= 2)
            {
                StudentBusiness b = new StudentBusiness();
                DgvStudent.DataSource = b.DetailsByField("Name", TextBoxSearchName.Text.Trim());
                SetSettingStudent();
            }
            else
                MsgBox.Show("مقدار نام را به درستی وارد کنید", "هشدار");

        }

        private void ButtonSearchLastName_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchLastName.Text.Trim().Length >= 2)
            {
                StudentBusiness b = new StudentBusiness();
                DgvStudent.DataSource = b.DetailsByField("LastName", TextBoxSearchLastName.Text.Trim());
                SetSettingStudent();
            }
            else
                MsgBox.Show("مقدار نام خانوادگی را به درستی وارد کنید", "هشدار");

        }

        private void ButtonSearchMore_Click(object sender, EventArgs e)
        {
            SearchStudentFrom f = new();
            f.StrFormName = "فرم جستجوی دانش آموزان";
            f.ShowDialog();
            /////////////////////////////////////////////////////
            if (f.SendParameter > 0)
            {


                if (f.DgvStudent.Rows.Count > 1)
                {
                    if (f.DgvStudent.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (f.DgvStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;

                    TextBoxNationalCode.Text = f.DgvStudent.CurrentRow.Cells["NationalCode"].Value.ToString();
                    TextBoxNationalCode.Tag = f.DgvStudent.CurrentRow.Cells["ID"].Value.ToString();
                    TextBoxName.Text = f.DgvStudent.CurrentRow.Cells["Name"].Value.ToString();
                    TextBoxLastName.Text = f.DgvStudent.CurrentRow.Cells["LastName"].Value.ToString();
                    TextBoxAddress.Text = f.DgvStudent.CurrentRow.Cells["Address"].Value.ToString();
                    TextBoxPhone.Text = f.DgvStudent.CurrentRow.Cells["Phone"].Value.ToString();
                    DatePickerDateOfBirth.Value = f.DgvStudent.CurrentRow.Cells["DateOfBirth"].Value.ToString();
                    ComboBoxSex.Text = f.DgvStudent.CurrentRow.Cells["Sex"].Value.ToString();
                    ComboBox_ID_FK_Degree.SelectedValue = f.DgvStudent.CurrentRow.Cells["ID_FK_Degree"].Value.ToString();
                    if (File.Exists(MyFile.StudentImage + TextBoxNationalCode.Tag.ToString() + ".jpg"))
                    {
                        pictureBoxStudent.Image = Image.FromFile(MyFile.StudentImage + TextBoxNationalCode.Tag.ToString() + ".jpg");
                        pictureBoxStudent.Tag = MyFile.StudentImage + TextBoxNationalCode.Tag.ToString() + ".jpg";
                    }

                    else
                        pictureBoxStudent.Image = null;
                }
            }
        }

        private void GetListStudent()
        {
            if(TextBoxNationalCode.Tag.ToString() != string.Empty)
            {
                StudentBusiness b = new StudentBusiness();
                DgvStudent.DataSource = b.DetailsByField("Student.ID", TextBoxNationalCode.Tag.ToString());
                SetSettingStudent();
            }
            else
                DgvStudent.DataSource = null;
        }
        public void SetSettingStudent()
        {
            DgvStudent.Columns["ID"].Visible = false;
            DgvStudent.Columns["Image"].Visible = false;
            DgvStudent.Columns["ID_FK_Degree"].Visible = false;
            DgvStudent.Columns["Name"].HeaderText = "نام";
            DgvStudent.Columns["LastName"].HeaderText = "نام خانوادگی";
            DgvStudent.Columns["NationalCode"].HeaderText = "کدملی";
            DgvStudent.Columns["Degree"].HeaderText = "مدرک";
            DgvStudent.Columns["Sex"].HeaderText = "جنسیت";
            DgvStudent.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            DgvStudent.Columns["Address"].HeaderText = "آدرس";
            DgvStudent.Columns["Phone"].HeaderText = "تلفن";

            if (DgvStudent.Rows.Count == 1)
            {
                MsgBox.Show("برای مقدار وارد شده هیچ رکوردی پیدا نشد", "هشدار");
            }
        }
        private void SetSettingOnlyOneRun()
        {
            ComboBox_ID_FK_Degree.DataSource = new BusinessDegree().GetList();
            //-------------------------------
            ComboBox_ID_FK_Degree.DisplayMember = "Title";
            ComboBox_ID_FK_Degree.ValueMember = "ID";
            ComboBox_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBox_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.ListItems;
            //------------------------------            
            ComboBoxSex.Text = "انتخاب کنید";
            ComboBoxSex.Items.Add("زن");
            ComboBoxSex.Items.Add("مرد");

        }

        private void ClearText()
        {
            TextBoxName.Text = string.Empty;
            TextBoxLastName.Text = string.Empty;
            TextBoxNationalCode.Text = string.Empty;
            TextBoxPhone.Text = string.Empty;
            ComboBoxSex.Text = "انتخاب کنید";
            ComboBox_ID_FK_Degree.Text = "A1";
            TextBoxAddress.Text = string.Empty;
            DatePickerDateOfBirth.Value = DateTime.Now.ToString();
            errorProviderStudent.Clear();
            //---------------------------
            pictureBoxStudent.Tag = string.Empty;
            pictureBoxStudent.Image = null;
            TextBoxNationalCode.Tag = string.Empty;
        }

        private bool ValidateData()
        {
            errorProviderStudent.Clear();

            bool result = true;

            if (TextBoxNationalCode.Text.Trim() == string.Empty || TextBoxNationalCode.Text.Trim().Length != 10)
            {
                errorProviderStudent.SetError(TextBoxNationalCode, "لطفا مقدار کد ملی را درست وارد کنید");
                result = false;
            }
            if (TextBoxName.Text.Trim() == string.Empty)
            {
                errorProviderStudent.SetError(TextBoxName, "لطفا مقدار نام را وارد کنید");
                result = false;
            }
            if (TextBoxLastName.Text.Trim() == string.Empty)
            {
                errorProviderStudent.SetError(TextBoxLastName, "لطفا مقدار نام خانوادگی را وارد کنید");
                result = false;
            }
            if (ComboBoxSex.SelectedIndex == -1)
            {
                errorProviderStudent.SetError(ComboBoxSex, "لطفا مقدار جنسیت را انتخاب کنید");
                result = false;
            }
            if (TextBoxPhone.Text.Trim() == string.Empty || TextBoxPhone.Text.Trim().Length != 11)
            {
                errorProviderStudent.SetError(TextBoxPhone, "لطفا مقدار تلفن را درست وارد کنید");
                result = false;
            }
            return result;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(DgvStudent));
        }
    }
}
