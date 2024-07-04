namespace Wfa_ZabanSara.Forms
{
    partial class SearchTeacherForm
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
            groupBox1 = new GroupBox();
            BtnPrint = new Button();
            BtnSearchDegree = new Button();
            label4 = new Label();
            ComboBoxSearch_ID_FK_Degree = new BaseControl.MyComboBox();
            BtnSearchSex = new Button();
            label5 = new Label();
            ComboBoxSearchSex = new BaseControl.MyComboBox();
            BtnSearchLastName = new Button();
            BtnSearchName = new Button();
            BtnSearchNationalCode = new Button();
            label9 = new Label();
            TextBoxSearchLastName = new BaseControl.MyTextBox();
            label10 = new Label();
            label11 = new Label();
            TextBoxSearchName = new BaseControl.MyTextBox();
            TextBoxSearchNationalCode = new BaseControl.MyTextBox();
            DataGridViewTeacher = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            ColumnImage = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTeacher).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnPrint);
            groupBox1.Controls.Add(BtnSearchDegree);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ComboBoxSearch_ID_FK_Degree);
            groupBox1.Controls.Add(BtnSearchSex);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ComboBoxSearchSex);
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
            groupBox1.Location = new Point(0, 78);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1046, 177);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // BtnPrint
            // 
            BtnPrint.Image = Properties.Resources.PrintImge;
            BtnPrint.ImageAlign = ContentAlignment.MiddleRight;
            BtnPrint.Location = new Point(173, 94);
            BtnPrint.Margin = new Padding(3, 4, 3, 4);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(102, 58);
            BtnPrint.TabIndex = 32;
            BtnPrint.Text = "پرنیت";
            BtnPrint.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnSearchDegree
            // 
            BtnSearchDegree.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchDegree.Image = Properties.Resources.search_1_;
            BtnSearchDegree.Location = new Point(765, 106);
            BtnSearchDegree.Margin = new Padding(3, 4, 3, 4);
            BtnSearchDegree.Name = "BtnSearchDegree";
            BtnSearchDegree.Size = new Size(37, 36);
            BtnSearchDegree.TabIndex = 28;
            BtnSearchDegree.UseVisualStyleBackColor = true;
            BtnSearchDegree.Click += BtnSearchDegree_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(962, 112);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 26;
            label4.Text = "مدرک";
            // 
            // ComboBoxSearch_ID_FK_Degree
            // 
            ComboBoxSearch_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSearch_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSearch_ID_FK_Degree.DataSource = null;
            ComboBoxSearch_ID_FK_Degree.DisplayMember = "";
            ComboBoxSearch_ID_FK_Degree.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSearch_ID_FK_Degree.Location = new Point(809, 107);
            ComboBoxSearch_ID_FK_Degree.Margin = new Padding(3, 5, 3, 5);
            ComboBoxSearch_ID_FK_Degree.Name = "ComboBoxSearch_ID_FK_Degree";
            ComboBoxSearch_ID_FK_Degree.SelectedIndex = -1;
            ComboBoxSearch_ID_FK_Degree.SelectedValue = null;
            ComboBoxSearch_ID_FK_Degree.Size = new Size(130, 29);
            ComboBoxSearch_ID_FK_Degree.TabIndex = 27;
            ComboBoxSearch_ID_FK_Degree.ValueMember = "";
            // 
            // BtnSearchSex
            // 
            BtnSearchSex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchSex.Image = Properties.Resources.search_1_;
            BtnSearchSex.Location = new Point(413, 101);
            BtnSearchSex.Margin = new Padding(3, 4, 3, 4);
            BtnSearchSex.Name = "BtnSearchSex";
            BtnSearchSex.Size = new Size(37, 36);
            BtnSearchSex.TabIndex = 31;
            BtnSearchSex.UseVisualStyleBackColor = true;
            BtnSearchSex.Click += BtnSearchSex_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 110);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 29;
            label5.Text = "جنسیت";
            // 
            // ComboBoxSearchSex
            // 
            ComboBoxSearchSex.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSearchSex.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSearchSex.DataSource = null;
            ComboBoxSearchSex.DisplayMember = "";
            ComboBoxSearchSex.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSearchSex.Location = new Point(457, 106);
            ComboBoxSearchSex.Margin = new Padding(3, 5, 3, 5);
            ComboBoxSearchSex.Name = "ComboBoxSearchSex";
            ComboBoxSearchSex.SelectedIndex = -1;
            ComboBoxSearchSex.SelectedValue = null;
            ComboBoxSearchSex.Size = new Size(130, 29);
            ComboBoxSearchSex.TabIndex = 30;
            ComboBoxSearchSex.ValueMember = "";
            // 
            // BtnSearchLastName
            // 
            BtnSearchLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchLastName.Image = Properties.Resources.search_1_;
            BtnSearchLastName.Location = new Point(4, 37);
            BtnSearchLastName.Margin = new Padding(3, 4, 3, 4);
            BtnSearchLastName.Name = "BtnSearchLastName";
            BtnSearchLastName.Size = new Size(37, 36);
            BtnSearchLastName.TabIndex = 25;
            BtnSearchLastName.UseVisualStyleBackColor = true;
            BtnSearchLastName.Click += BtnSearchLastName_Click;
            // 
            // BtnSearchName
            // 
            BtnSearchName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchName.Image = Properties.Resources.search_1_;
            BtnSearchName.Location = new Point(413, 41);
            BtnSearchName.Margin = new Padding(3, 4, 3, 4);
            BtnSearchName.Name = "BtnSearchName";
            BtnSearchName.Size = new Size(37, 36);
            BtnSearchName.TabIndex = 22;
            BtnSearchName.UseVisualStyleBackColor = true;
            BtnSearchName.Click += BtnSearchName_Click;
            // 
            // BtnSearchNationalCode
            // 
            BtnSearchNationalCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchNationalCode.Image = Properties.Resources.search_1_;
            BtnSearchNationalCode.Location = new Point(765, 40);
            BtnSearchNationalCode.Margin = new Padding(3, 4, 3, 4);
            BtnSearchNationalCode.Name = "BtnSearchNationalCode";
            BtnSearchNationalCode.Size = new Size(37, 36);
            BtnSearchNationalCode.TabIndex = 19;
            BtnSearchNationalCode.UseVisualStyleBackColor = true;
            BtnSearchNationalCode.Click += BtnSearchNationalCode_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 46);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 23;
            label9.Text = "نام خانوادگی";
            // 
            // TextBoxSearchLastName
            // 
            TextBoxSearchLastName.IsNumber = false;
            TextBoxSearchLastName.IsReal = false;
            TextBoxSearchLastName.Location = new Point(48, 41);
            TextBoxSearchLastName.Margin = new Padding(3, 6, 3, 6);
            TextBoxSearchLastName.Name = "TextBoxSearchLastName";
            TextBoxSearchLastName.Size = new Size(123, 29);
            TextBoxSearchLastName.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(621, 44);
            label10.Name = "label10";
            label10.Size = new Size(30, 23);
            label10.TabIndex = 20;
            label10.Text = "نام";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(973, 48);
            label11.Name = "label11";
            label11.Size = new Size(58, 23);
            label11.TabIndex = 17;
            label11.Text = "کدملی";
            // 
            // TextBoxSearchName
            // 
            TextBoxSearchName.IsNumber = false;
            TextBoxSearchName.IsReal = false;
            TextBoxSearchName.Location = new Point(457, 41);
            TextBoxSearchName.Margin = new Padding(3, 6, 3, 6);
            TextBoxSearchName.Name = "TextBoxSearchName";
            TextBoxSearchName.Size = new Size(123, 29);
            TextBoxSearchName.TabIndex = 21;
            // 
            // TextBoxSearchNationalCode
            // 
            TextBoxSearchNationalCode.IsNumber = true;
            TextBoxSearchNationalCode.IsReal = false;
            TextBoxSearchNationalCode.Location = new Point(809, 42);
            TextBoxSearchNationalCode.Margin = new Padding(3, 7, 3, 7);
            TextBoxSearchNationalCode.Name = "TextBoxSearchNationalCode";
            TextBoxSearchNationalCode.Size = new Size(123, 29);
            TextBoxSearchNationalCode.TabIndex = 18;
            // 
            // DataGridViewTeacher
            // 
            DataGridViewTeacher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DataGridViewTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTeacher.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTeacher.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber, ColumnImage });
            DataGridViewTeacher.Dock = DockStyle.Fill;
            DataGridViewTeacher.Location = new Point(0, 255);
            DataGridViewTeacher.Margin = new Padding(3, 4, 3, 4);
            DataGridViewTeacher.Name = "DataGridViewTeacher";
            DataGridViewTeacher.ReadOnly = true;
            DataGridViewTeacher.RowHeadersWidth = 51;
            DataGridViewTeacher.Size = new Size(1046, 375);
            DataGridViewTeacher.TabIndex = 3;
            DataGridViewTeacher.CellDoubleClick += DataGridViewTeacher_CellDoubleClick;
            DataGridViewTeacher.CellFormatting += DataGridViewTeacher_CellFormatting;
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
            ColumnImage.MinimumWidth = 6;
            ColumnImage.Name = "ColumnImage";
            ColumnImage.ReadOnly = true;
            ColumnImage.Resizable = DataGridViewTriState.True;
            ColumnImage.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // SearchTeacherForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 630);
            Controls.Add(DataGridViewTeacher);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "SearchTeacherForm";
            Load += SearchTeacherForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(DataGridViewTeacher, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnPrint;
        private Button BtnSearchDegree;
        private Label label4;
        private BaseControl.MyComboBox ComboBoxSearch_ID_FK_Degree;
        private Button BtnSearchSex;
        private Label label5;
        private BaseControl.MyComboBox ComboBoxSearchSex;
        private Button BtnSearchLastName;
        private Button BtnSearchName;
        private Button BtnSearchNationalCode;
        private Label label9;
        private BaseControl.MyTextBox TextBoxSearchLastName;
        private Label label10;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchName;
        private BaseControl.MyTextBox TextBoxSearchNationalCode;
        public DataGridView DataGridViewTeacher;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private DataGridViewImageColumn ColumnImage;
    }
}