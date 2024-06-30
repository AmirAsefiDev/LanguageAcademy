using Wfa_ZabanSara.App_source.BusinessLayer;

namespace Wfa_ZabanSara.Forms
{
    public partial class SearchStudentFrom : MasterForm.frmMaster
    {
        public int SendParameter = 0;
        public SearchStudentFrom()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        private void SearchStudentFrom_Load(object sender, EventArgs e)
        {
            GetListStudent();
            SetrSettingOnlyOneRun();
        }

        private void DgvStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgvStudent.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void ButtonSearchNationalCode_Click(object sender, EventArgs e)
        {
            StudentBusiness b = new StudentBusiness();
            DgvStudent.DataSource = b.DetailsByField("NationalCode", TextBoxSearchNationalCode.Text.Trim());
            SetSetting();
        }

        private void ButtonSearchName_Click(object sender, EventArgs e)
        {
            StudentBusiness b = new StudentBusiness();
            DgvStudent.DataSource = b.DetailsByField("Name", TextBoxSearchName.Text.Trim());
            SetSetting();
        }

        private void BtnSearchLastName_Click(object sender, EventArgs e)
        {
            StudentBusiness b = new StudentBusiness();
            DgvStudent.DataSource = b.DetailsByField("LastName", TextBoxSearchLastName.Text.Trim());
            SetSetting();
        }

        public void SetSetting()
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
            //---------------------------LoadImage-----------------------------
            System.Threading.Thread tr = new System.Threading.Thread(LoadImage);
            tr.Start();
        }
        private void BtnSearchSex_Click(object sender, EventArgs e)
        {
            StudentBusiness b = new StudentBusiness();
            DgvStudent.DataSource = b.DetailsByField("Sex", ComboBoxSearchSex.SelectedIndex.ToString());
            SetSetting();
        }
        private void BtnSearchDegree_Click(object sender, EventArgs e)
        {
            StudentBusiness b = new StudentBusiness();
            DgvStudent.DataSource = b.DetailsByField("ID_FK_Degree", ComboBoxSearch_ID_FK_Degree.SelectedValue.ToString());
            SetSetting();
        }

        private void SetrSettingOnlyOneRun()
        {
            ComboBoxSearch_ID_FK_Degree.DataSource = new BusinessDegree().GetList();
            //-------------------------------
            ComboBoxSearch_ID_FK_Degree.DisplayMember = "Title";
            ComboBoxSearch_ID_FK_Degree.ValueMember = "ID";
            ComboBoxSearch_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxSearch_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.ListItems;
            ////------------------------------            
            ComboBoxSearchSex.Text = "انتخاب کنید";
            ComboBoxSearchSex.Items.Add("زن");
            ComboBoxSearchSex.Items.Add("مرد");

        }
        private void GetListStudent()
        {
            DgvStudent.DataSource = new StudentBusiness().GetList();
            SetSetting();

        }

        private void DgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvStudent.CurrentRow.Cells["ID"].Value == null)
                return;
            if (DgvStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                return;
            SendParameter = int.Parse(DgvStudent.CurrentRow.Cells["ID"].Value.ToString());
            this.Close();
        }
        public void LoadImage()
        {
            for (int i = 0; i < DgvStudent.RowCount; i++)
            {
                if (DgvStudent.Rows[i].Cells["ID"].Value != null)
                {
                    string StrId = DgvStudent.Rows[i].Cells["ID"].Value.ToString();
                    if (File.Exists("StudentImage/" + StrId + ".jpg"))
                    {
                        Bitmap bmp = new Bitmap(Image.FromFile("StudentImage/" + StrId + ".jpg"), 50, 50);
                        DgvStudent.Rows[i].Cells["ColumnImage"].Value = bmp;
                        DgvStudent.Rows[i].Height = 55;
                    }


                }
            }
        }
    }
}
