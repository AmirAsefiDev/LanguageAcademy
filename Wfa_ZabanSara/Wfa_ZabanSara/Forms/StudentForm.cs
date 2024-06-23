using BaseControl.ExtensionMethods;
using Wfa_ZabanSara.App_source;
using Wfa_ZabanSara.App_source.BusinessLayer;

namespace Wfa_ZabanSara.Forms
{
    public partial class StudentForm : MasterForm.frmMaster
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        private void GetListStudent()
        {
            DgvStudent.DataSource = new StudentBusiness().GetList();
            ComboBox_ID_FK_Degree.DataSource = new BusinessDegree().GetList();

            SetSetting();

        }
        public void SetSetting()
        {
            DgvStudent.Columns["ID"].Visible = false;
            DgvStudent.Columns["Image"].Visible = false;
            DgvStudent.Columns["Name"].HeaderText = "نام";
            DgvStudent.Columns["LastName"].HeaderText = "نام خانوادگی";
            DgvStudent.Columns["NationalCode"].HeaderText = "کدملی";
            DgvStudent.Columns["Degree"].HeaderText = "مدرک";
            DgvStudent.Columns["Sex"].HeaderText = "جنسیت";
            DgvStudent.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            DgvStudent.Columns["Address"].HeaderText = "آدرس";
            DgvStudent.Columns["Phone"].HeaderText = "تلفن";
            //--------------------------------------------------------
            ComboBox_ID_FK_Degree.DisplayMember = "Title";
            ComboBox_ID_FK_Degree.ValueMember = "ID";
            ComboBox_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBox_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.ListItems;
            //--------------------------------------------------------
            ComboBoxSex.Text = "انتخاب کنید";
            ComboBoxSex.Items.Add("زن");
            ComboBoxSex.Items.Add("مرد");
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
                if (DatePickerDateOfBirth.Tag != null)
                {
                    picker.SelectedDate = (DateTime)DatePickerDateOfBirth.Tag;
                  
                }
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    DatePickerDateOfBirth.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    DatePickerDateOfBirth.Tag = picker.SelectedDate.ToString();
                };
                return picker;
            };

            GetListStudent();
        }

        private void DgvStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvStudent.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private bool ValidateData()
        {
            bool result = true;

            if (TextBoxNationalCode.Text.Trim() == string.Empty)
            {
                errorProviderStudent.SetError(TextBoxNationalCode, "لطفا مقدار کد ملی را وارد کنید");
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
            return result;
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
                Student st = FillData();
                stb.Insert(st);
                GetListStudent();
                MsgBox.Show("دانش آموز مورد نظر اضافه شد","درج دانش آموز");
                
            }
        }
    }
}
