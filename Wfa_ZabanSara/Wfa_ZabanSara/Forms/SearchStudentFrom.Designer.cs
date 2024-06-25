namespace Wfa_ZabanSara.Forms
{
    partial class SearchStudentFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            BtnPrint = new Button();
            BtnSearchDegree = new Button();
            label4 = new Label();
            ComboBoxSearch_ID_FK_Degree = new BaseControl.MyComboBox();
            BtnSearchSex = new Button();
            label5 = new Label();
            ComboBoxSearchSex = new BaseControl.MyComboBox();
            button1 = new Button();
            BtnSearchLastName = new Button();
            BtnSearchName = new Button();
            BtnSearchNationalCode = new Button();
            label9 = new Label();
            TextBoxSearchLastName = new BaseControl.MyTextBox();
            label10 = new Label();
            label11 = new Label();
            TextBoxSearchName = new BaseControl.MyTextBox();
            TextBoxSearchNationalCode = new BaseControl.MyTextBox();
            ButtonSearchLastName = new Button();
            DgvStudent = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            ColumnImage = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvStudent).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(ButtonSearchLastName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 133);
            panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(BtnPrint);
            groupBox1.Controls.Add(BtnSearchDegree);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ComboBoxSearch_ID_FK_Degree);
            groupBox1.Controls.Add(BtnSearchSex);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ComboBoxSearchSex);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnSearchLastName);
            groupBox1.Controls.Add(BtnSearchName);
            groupBox1.Controls.Add(BtnSearchNationalCode);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TextBoxSearchLastName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TextBoxSearchName);
            groupBox1.Controls.Add(TextBoxSearchNationalCode);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(941, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // BtnPrint
            // 
            BtnPrint.Image = Properties.Resources.PrintImge;
            BtnPrint.ImageAlign = ContentAlignment.MiddleRight;
            BtnPrint.Location = new Point(191, 68);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(91, 47);
            BtnPrint.TabIndex = 15;
            BtnPrint.Text = "پرنیت";
            BtnPrint.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnSearchDegree
            // 
            BtnSearchDegree.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchDegree.Image = Properties.Resources.search_1_;
            BtnSearchDegree.Location = new Point(698, 78);
            BtnSearchDegree.Name = "BtnSearchDegree";
            BtnSearchDegree.Size = new Size(33, 29);
            BtnSearchDegree.TabIndex = 11;
            BtnSearchDegree.UseVisualStyleBackColor = true;
            BtnSearchDegree.Click += BtnSearchDegree_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(873, 83);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 9;
            label4.Text = "مدرک";
            // 
            // ComboBoxSearch_ID_FK_Degree
            // 
            ComboBoxSearch_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSearch_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSearch_ID_FK_Degree.DataSource = null;
            ComboBoxSearch_ID_FK_Degree.DisplayMember = "";
            ComboBoxSearch_ID_FK_Degree.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSearch_ID_FK_Degree.Location = new Point(737, 79);
            ComboBoxSearch_ID_FK_Degree.Name = "ComboBoxSearch_ID_FK_Degree";
            ComboBoxSearch_ID_FK_Degree.SelectedIndex = -1;
            ComboBoxSearch_ID_FK_Degree.SelectedValue = null;
            ComboBoxSearch_ID_FK_Degree.Size = new Size(130, 25);
            ComboBoxSearch_ID_FK_Degree.TabIndex = 10;
            ComboBoxSearch_ID_FK_Degree.ValueMember = "";
            // 
            // BtnSearchSex
            // 
            BtnSearchSex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchSex.Image = Properties.Resources.search_1_;
            BtnSearchSex.Location = new Point(385, 74);
            BtnSearchSex.Name = "BtnSearchSex";
            BtnSearchSex.Size = new Size(33, 29);
            BtnSearchSex.TabIndex = 14;
            BtnSearchSex.UseVisualStyleBackColor = true;
            BtnSearchSex.Click += BtnSearchSex_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(562, 81);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 12;
            label5.Text = "جنسیت";
            // 
            // ComboBoxSearchSex
            // 
            ComboBoxSearchSex.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSearchSex.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSearchSex.DataSource = null;
            ComboBoxSearchSex.DisplayMember = "";
            ComboBoxSearchSex.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSearchSex.Location = new Point(424, 78);
            ComboBoxSearchSex.Margin = new Padding(3, 4, 3, 4);
            ComboBoxSearchSex.Name = "ComboBoxSearchSex";
            ComboBoxSearchSex.SelectedIndex = -1;
            ComboBoxSearchSex.SelectedValue = null;
            ComboBoxSearchSex.Size = new Size(130, 25);
            ComboBoxSearchSex.TabIndex = 13;
            ComboBoxSearchSex.ValueMember = "";
            // 
            // button1
            // 
            button1.Location = new Point(61, 67);
            button1.Name = "button1";
            button1.Size = new Size(92, 47);
            button1.TabIndex = 16;
            button1.Text = "انتقال کد";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnSearchLastName
            // 
            BtnSearchLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchLastName.Image = Properties.Resources.search_1_;
            BtnSearchLastName.Location = new Point(22, 22);
            BtnSearchLastName.Name = "BtnSearchLastName";
            BtnSearchLastName.Size = new Size(33, 29);
            BtnSearchLastName.TabIndex = 8;
            BtnSearchLastName.UseVisualStyleBackColor = true;
            BtnSearchLastName.Click += BtnSearchLastName_Click;
            // 
            // BtnSearchName
            // 
            BtnSearchName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchName.Image = Properties.Resources.search_1_;
            BtnSearchName.Location = new Point(385, 25);
            BtnSearchName.Name = "BtnSearchName";
            BtnSearchName.Size = new Size(33, 29);
            BtnSearchName.TabIndex = 5;
            BtnSearchName.UseVisualStyleBackColor = true;
            BtnSearchName.Click += ButtonSearchName_Click;
            // 
            // BtnSearchNationalCode
            // 
            BtnSearchNationalCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchNationalCode.Image = Properties.Resources.search_1_;
            BtnSearchNationalCode.Location = new Point(698, 24);
            BtnSearchNationalCode.Name = "BtnSearchNationalCode";
            BtnSearchNationalCode.Size = new Size(33, 29);
            BtnSearchNationalCode.TabIndex = 2;
            BtnSearchNationalCode.UseVisualStyleBackColor = true;
            BtnSearchNationalCode.Click += ButtonSearchNationalCode_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 29);
            label9.Name = "label9";
            label9.Size = new Size(77, 17);
            label9.TabIndex = 6;
            label9.Text = "نام خانوادگی";
            // 
            // TextBoxSearchLastName
            // 
            TextBoxSearchLastName.IsNumber = false;
            TextBoxSearchLastName.IsReal = false;
            TextBoxSearchLastName.Location = new Point(61, 25);
            TextBoxSearchLastName.Margin = new Padding(3, 4, 3, 4);
            TextBoxSearchLastName.Name = "TextBoxSearchLastName";
            TextBoxSearchLastName.Size = new Size(140, 23);
            TextBoxSearchLastName.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(570, 28);
            label10.Name = "label10";
            label10.Size = new Size(23, 17);
            label10.TabIndex = 3;
            label10.Text = "نام";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(883, 31);
            label11.Name = "label11";
            label11.Size = new Size(45, 17);
            label11.TabIndex = 0;
            label11.Text = "کدملی";
            // 
            // TextBoxSearchName
            // 
            TextBoxSearchName.IsNumber = false;
            TextBoxSearchName.IsReal = false;
            TextBoxSearchName.Location = new Point(424, 25);
            TextBoxSearchName.Margin = new Padding(3, 4, 3, 4);
            TextBoxSearchName.Name = "TextBoxSearchName";
            TextBoxSearchName.Size = new Size(140, 23);
            TextBoxSearchName.TabIndex = 4;
            // 
            // TextBoxSearchNationalCode
            // 
            TextBoxSearchNationalCode.IsNumber = true;
            TextBoxSearchNationalCode.IsReal = false;
            TextBoxSearchNationalCode.Location = new Point(737, 26);
            TextBoxSearchNationalCode.Margin = new Padding(3, 4, 3, 4);
            TextBoxSearchNationalCode.Name = "TextBoxSearchNationalCode";
            TextBoxSearchNationalCode.Size = new Size(140, 23);
            TextBoxSearchNationalCode.TabIndex = 1;
            // 
            // ButtonSearchLastName
            // 
            ButtonSearchLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchLastName.Image = Properties.Resources.search_1_;
            ButtonSearchLastName.Location = new Point(-133, 36);
            ButtonSearchLastName.Name = "ButtonSearchLastName";
            ButtonSearchLastName.Size = new Size(33, 29);
            ButtonSearchLastName.TabIndex = 32;
            ButtonSearchLastName.UseVisualStyleBackColor = true;
            // 
            // DgvStudent
            // 
            DgvStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvStudent.BackgroundColor = SystemColors.ButtonHighlight;
            DgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvStudent.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber, ColumnImage });
            DgvStudent.Dock = DockStyle.Fill;
            DgvStudent.Location = new Point(0, 196);
            DgvStudent.Name = "DgvStudent";
            DgvStudent.ReadOnly = true;
            DgvStudent.RowHeadersWidth = 51;
            DgvStudent.Size = new Size(941, 296);
            DgvStudent.TabIndex = 0;
            DgvStudent.CellDoubleClick += DgvStudent_CellDoubleClick;
            DgvStudent.CellFormatting += DgvStudent_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // ColumnImage
            // 
            ColumnImage.HeaderText = "عکس";
            ColumnImage.Name = "ColumnImage";
            ColumnImage.ReadOnly = true;
            ColumnImage.Resizable = DataGridViewTriState.True;
            ColumnImage.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // SearchStudentFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 492);
            Controls.Add(DgvStudent);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SearchStudentFrom";
            Load += SearchStudentFrom_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DgvStudent, 0);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button ButtonSearchLastName;
        private GroupBox groupBox1;
        private Button BtnSearchLastName;
        private Button BtnSearchName;
        private Button BtnSearchNationalCode;
        private Label label9;
        private BaseControl.MyTextBox TextBoxSearchLastName;
        private Label label10;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchName;
        private BaseControl.MyTextBox TextBoxSearchNationalCode;
        private Button button1;
        private Label label5;
        private BaseControl.MyComboBox ComboBoxSearchSex;
        private Button BtnSearchSex;
        private Button BtnSearchDegree;
        private Label label4;
        private BaseControl.MyComboBox ComboBoxSearch_ID_FK_Degree;
        private Button BtnPrint;
        public DataGridView DgvStudent;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private DataGridViewImageColumn ColumnImage;
    }
}