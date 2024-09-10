using Wfa_ZabanSara.App_source.BusinessLayer;


namespace Wfa_FinancialSystem.Forms
{
    public partial class SearchStudentFromDemo : MasterForm.frmMaster
    {
        public int SendParameter = 0;
        public SearchStudentFromDemo()
        {
            //InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        //private void InitializeComponent()
        //{
        //    DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        //    DgvStudent = new DataGridView();
        //    ColumnRowNumber = new DataGridViewTextBoxColumn();
        //    ColumnImage = new DataGridViewImageColumn();
        //    groupBox1 = new GroupBox();
        //    BtnSearchDegree = new Button();
        //    label4 = new Label();
        //    ComboBoxSearch_ID_FK_Degree = new BaseControl.MyComboBox();
        //    BtnSearchSex = new Button();
        //    label5 = new Label();
        //    ComboBoxSearchSex = new BaseControl.MyComboBox();
        //    BtnSearchLastName = new Button();
        //    BtnSearchName = new Button();
        //    BtnSearchNationalCode = new Button();
        //    label9 = new Label();
        //    TextBoxSearchLastName = new BaseControl.MyTextBox();
        //    label10 = new Label();
        //    label11 = new Label();
        //    TextBoxSearchName = new BaseControl.MyTextBox();
        //    TextBoxSearchNationalCode = new BaseControl.MyTextBox();
        //    ((System.ComponentModel.ISupportInitialize)DgvStudent).BeginInit();
        //    groupBox1.SuspendLayout();
        //    SuspendLayout();
        //    // 
        //    // DgvStudent
        //    // 
        //    DgvStudent.AllowUserToDeleteRows = false;
        //    dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
        //    DgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        //    DgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    DgvStudent.BackgroundColor = SystemColors.ButtonHighlight;
        //    DgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    DgvStudent.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber, ColumnImage });
        //    DgvStudent.Dock = DockStyle.Fill;
        //    DgvStudent.Location = new Point(0, 242);
        //    DgvStudent.Margin = new Padding(3, 4, 3, 4);
        //    DgvStudent.Name = "DgvStudent";
        //    DgvStudent.ReadOnly = true;
        //    DgvStudent.RowHeadersWidth = 51;
        //    DgvStudent.Size = new Size(1007, 308);
        //    DgvStudent.TabIndex = 2;
        //    DgvStudent.CellDoubleClick += DgvStudent_CellDoubleClick_1;
        //    DgvStudent.CellFormatting += DgvStudent_CellFormatting_1;
        //    // 
        //    // ColumnRowNumber
        //    // 
        //    ColumnRowNumber.HeaderText = "ردیف";
        //    ColumnRowNumber.MinimumWidth = 6;
        //    ColumnRowNumber.Name = "ColumnRowNumber";
        //    ColumnRowNumber.ReadOnly = true;
        //    // 
        //    // ColumnImage
        //    // 
        //    ColumnImage.HeaderText = "عکس";
        //    ColumnImage.MinimumWidth = 6;
        //    ColumnImage.Name = "ColumnImage";
        //    ColumnImage.ReadOnly = true;
        //    ColumnImage.Resizable = DataGridViewTriState.True;
        //    ColumnImage.SortMode = DataGridViewColumnSortMode.Automatic;
        //    // 
        //    // groupBox1
        //    // 
        //    groupBox1.BackColor = Color.WhiteSmoke;
        //    groupBox1.Controls.Add(BtnSearchDegree);
        //    groupBox1.Controls.Add(label4);
        //    groupBox1.Controls.Add(ComboBoxSearch_ID_FK_Degree);
        //    groupBox1.Controls.Add(BtnSearchSex);
        //    groupBox1.Controls.Add(label5);
        //    groupBox1.Controls.Add(ComboBoxSearchSex);
        //    groupBox1.Controls.Add(BtnSearchLastName);
        //    groupBox1.Controls.Add(BtnSearchName);
        //    groupBox1.Controls.Add(BtnSearchNationalCode);
        //    groupBox1.Controls.Add(label9);
        //    groupBox1.Controls.Add(TextBoxSearchLastName);
        //    groupBox1.Controls.Add(label10);
        //    groupBox1.Controls.Add(label11);
        //    groupBox1.Controls.Add(TextBoxSearchName);
        //    groupBox1.Controls.Add(TextBoxSearchNationalCode);
        //    groupBox1.Dock = DockStyle.Top;
        //    groupBox1.Location = new Point(0, 78);
        //    groupBox1.Margin = new Padding(3, 4, 3, 4);
        //    groupBox1.Name = "groupBox1";
        //    groupBox1.Padding = new Padding(3, 4, 3, 4);
        //    groupBox1.Size = new Size(1007, 164);
        //    groupBox1.TabIndex = 3;
        //    groupBox1.TabStop = false;
        //    groupBox1.Text = "جستجو";
        //    // 
        //    // BtnSearchDegree
        //    // 
        //    BtnSearchDegree.BackgroundImage = Properties.Resources.search_1_;
        //    BtnSearchDegree.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        //    BtnSearchDegree.Location = new Point(701, 96);
        //    BtnSearchDegree.Margin = new Padding(3, 4, 3, 4);
        //    BtnSearchDegree.Name = "BtnSearchDegree";
        //    BtnSearchDegree.Size = new Size(37, 36);
        //    BtnSearchDegree.TabIndex = 11;
        //    BtnSearchDegree.UseVisualStyleBackColor = true;
        //    BtnSearchDegree.Click += BtnSearchDegree_Click_1;
        //    // 
        //    // label4
        //    // 
        //    label4.AutoSize = true;
        //    label4.Location = new Point(895, 101);
        //    label4.Name = "label4";
        //    label4.Size = new Size(51, 23);
        //    label4.TabIndex = 9;
        //    label4.Text = "مدرک";
        //    // 
        //    // ComboBoxSearch_ID_FK_Degree
        //    // 
        //    ComboBoxSearch_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.None;
        //    ComboBoxSearch_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.None;
        //    ComboBoxSearch_ID_FK_Degree.DataSource = null;
        //    ComboBoxSearch_ID_FK_Degree.DisplayMember = "";
        //    ComboBoxSearch_ID_FK_Degree.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        //    ComboBoxSearch_ID_FK_Degree.Location = new Point(750, 98);
        //    ComboBoxSearch_ID_FK_Degree.Margin = new Padding(3, 5, 3, 5);
        //    ComboBoxSearch_ID_FK_Degree.Name = "ComboBoxSearch_ID_FK_Degree";
        //    ComboBoxSearch_ID_FK_Degree.SelectedIndex = -1;
        //    ComboBoxSearch_ID_FK_Degree.SelectedValue = null;
        //    ComboBoxSearch_ID_FK_Degree.Size = new Size(130, 31);
        //    ComboBoxSearch_ID_FK_Degree.TabIndex = 10;
        //    ComboBoxSearch_ID_FK_Degree.ValueMember = "";
        //    // 
        //    // BtnSearchSex
        //    // 
        //    BtnSearchSex.BackgroundImage = Properties.Resources.search_1_;
        //    BtnSearchSex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        //    BtnSearchSex.Location = new Point(367, 92);
        //    BtnSearchSex.Margin = new Padding(3, 4, 3, 4);
        //    BtnSearchSex.Name = "BtnSearchSex";
        //    BtnSearchSex.Size = new Size(37, 36);
        //    BtnSearchSex.TabIndex = 14;
        //    BtnSearchSex.UseVisualStyleBackColor = true;
        //    BtnSearchSex.Click += BtnSearchSex_Click_1;
        //    // 
        //    // label5
        //    // 
        //    label5.AutoSize = true;
        //    label5.Location = new Point(562, 101);
        //    label5.Name = "label5";
        //    label5.Size = new Size(62, 23);
        //    label5.TabIndex = 12;
        //    label5.Text = "جنسیت";
        //    // 
        //    // ComboBoxSearchSex
        //    // 
        //    ComboBoxSearchSex.AutoCompleteMode = AutoCompleteMode.None;
        //    ComboBoxSearchSex.AutoCompleteSource = AutoCompleteSource.None;
        //    ComboBoxSearchSex.DataSource = null;
        //    ComboBoxSearchSex.DisplayMember = "";
        //    ComboBoxSearchSex.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        //    ComboBoxSearchSex.Location = new Point(414, 96);
        //    ComboBoxSearchSex.Margin = new Padding(3, 5, 3, 5);
        //    ComboBoxSearchSex.Name = "ComboBoxSearchSex";
        //    ComboBoxSearchSex.SelectedIndex = -1;
        //    ComboBoxSearchSex.SelectedValue = null;
        //    ComboBoxSearchSex.Size = new Size(130, 31);
        //    ComboBoxSearchSex.TabIndex = 13;
        //    ComboBoxSearchSex.ValueMember = "";
        //    // 
        //    // BtnSearchLastName
        //    // 
        //    BtnSearchLastName.BackgroundImage = Properties.Resources.search_1_;
        //    BtnSearchLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        //    BtnSearchLastName.Location = new Point(29, 29);
        //    BtnSearchLastName.Margin = new Padding(3, 4, 3, 4);
        //    BtnSearchLastName.Name = "BtnSearchLastName";
        //    BtnSearchLastName.Size = new Size(37, 36);
        //    BtnSearchLastName.TabIndex = 8;
        //    BtnSearchLastName.UseVisualStyleBackColor = true;
        //    BtnSearchLastName.Click += BtnSearchLastName_Click_1;
        //    // 
        //    // BtnSearchName
        //    // 
        //    BtnSearchName.BackgroundImage = Properties.Resources.search_1_;
        //    BtnSearchName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        //    BtnSearchName.Location = new Point(370, 34);
        //    BtnSearchName.Margin = new Padding(3, 4, 3, 4);
        //    BtnSearchName.Name = "BtnSearchName";
        //    BtnSearchName.Size = new Size(37, 36);
        //    BtnSearchName.TabIndex = 5;
        //    BtnSearchName.UseVisualStyleBackColor = true;
        //    BtnSearchName.Click += BtnSearchName_Click;
        //    // 
        //    // BtnSearchNationalCode
        //    // 
        //    BtnSearchNationalCode.BackgroundImage = Properties.Resources.search_1_;
        //    BtnSearchNationalCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        //    BtnSearchNationalCode.Location = new Point(700, 32);
        //    BtnSearchNationalCode.Margin = new Padding(3, 4, 3, 4);
        //    BtnSearchNationalCode.Name = "BtnSearchNationalCode";
        //    BtnSearchNationalCode.Size = new Size(37, 36);
        //    BtnSearchNationalCode.TabIndex = 2;
        //    BtnSearchNationalCode.UseVisualStyleBackColor = true;
        //    BtnSearchNationalCode.Click += BtnSearchNationalCode_Click;
        //    // 
        //    // label9
        //    // 
        //    label9.AutoSize = true;
        //    label9.Location = new Point(230, 37);
        //    label9.Name = "label9";
        //    label9.Size = new Size(100, 23);
        //    label9.TabIndex = 6;
        //    label9.Text = "نام خانوادگی";
        //    // 
        //    // TextBoxSearchLastName
        //    // 
        //    TextBoxSearchLastName.IsNumber = false;
        //    TextBoxSearchLastName.IsReal = false;
        //    TextBoxSearchLastName.Location = new Point(78, 33);
        //    TextBoxSearchLastName.Margin = new Padding(3, 5, 3, 5);
        //    TextBoxSearchLastName.Name = "TextBoxSearchLastName";
        //    TextBoxSearchLastName.Size = new Size(134, 27);
        //    TextBoxSearchLastName.TabIndex = 7;
        //    // 
        //    // label10
        //    // 
        //    label10.AutoSize = true;
        //    label10.Location = new Point(575, 36);
        //    label10.Name = "label10";
        //    label10.Size = new Size(30, 23);
        //    label10.TabIndex = 3;
        //    label10.Text = "نام";
        //    // 
        //    // label11
        //    // 
        //    label11.AutoSize = true;
        //    label11.Location = new Point(908, 39);
        //    label11.Name = "label11";
        //    label11.Size = new Size(58, 23);
        //    label11.TabIndex = 0;
        //    label11.Text = "کدملی";
        //    // 
        //    // TextBoxSearchName
        //    // 
        //    TextBoxSearchName.IsNumber = false;
        //    TextBoxSearchName.IsReal = false;
        //    TextBoxSearchName.Location = new Point(420, 35);
        //    TextBoxSearchName.Margin = new Padding(3, 5, 3, 5);
        //    TextBoxSearchName.Name = "TextBoxSearchName";
        //    TextBoxSearchName.Size = new Size(134, 27);
        //    TextBoxSearchName.TabIndex = 4;
        //    // 
        //    // TextBoxSearchNationalCode
        //    // 
        //    TextBoxSearchNationalCode.IsNumber = true;
        //    TextBoxSearchNationalCode.IsReal = false;
        //    TextBoxSearchNationalCode.Location = new Point(749, 36);
        //    TextBoxSearchNationalCode.Margin = new Padding(3, 5, 3, 5);
        //    TextBoxSearchNationalCode.Name = "TextBoxSearchNationalCode";
        //    TextBoxSearchNationalCode.Size = new Size(149, 27);
        //    TextBoxSearchNationalCode.TabIndex = 1;
        //    // 
        //    // SearchStudentFrom
        //    // 
        //    AutoScaleDimensions = new SizeF(9F, 21F);
        //    BackgroundImageLayout = ImageLayout.None;
        //    ClientSize = new Size(1007, 550);
        //    Controls.Add(DgvStudent);
        //    Controls.Add(groupBox1);
        //    Name = "SearchStudentFrom";
        //    Load += SearchStudentFrom_Load_1;
        //    Controls.SetChildIndex(groupBox1, 0);
        //    Controls.SetChildIndex(DgvStudent, 0);
        //    ((System.ComponentModel.ISupportInitialize)DgvStudent).EndInit();
        //    groupBox1.ResumeLayout(false);
        //    groupBox1.PerformLayout();
        //    ResumeLayout(false);
        //}

        //public DataGridView DgvStudent;
        //private DataGridViewTextBoxColumn ColumnRowNumber;
        //private DataGridViewImageColumn ColumnImage;
        //private GroupBox groupBox1;
        //private Button BtnSearchDegree;
        //private Label label4;
        //private BaseControl.MyComboBox ComboBoxSearch_ID_FK_Degree;
        //private Button BtnSearchSex;
        //private Label label5;
        //private BaseControl.MyComboBox ComboBoxSearchSex;
        //private Button BtnSearchLastName;
        //private Button BtnSearchName;
        //private Button BtnSearchNationalCode;
        //private Label label9;
        //private BaseControl.MyTextBox TextBoxSearchLastName;
        //private Label label10;
        //private Label label11;
        //private BaseControl.MyTextBox TextBoxSearchName;
        //private BaseControl.MyTextBox TextBoxSearchNationalCode;

        private void SearchStudentFrom_Load_1(object sender, EventArgs e)
        {

        }

        private void DgvStudent_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void BtnSearchNationalCode_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchLastName_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSearchSex_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSearchDegree_Click_1(object sender, EventArgs e)
        {

        }

        private void DgvStudent_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
