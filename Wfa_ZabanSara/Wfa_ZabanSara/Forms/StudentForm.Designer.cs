﻿namespace Wfa_ZabanSara.Forms
{
    partial class StudentForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            ButtonSearchMore = new Button();
            ButtonSearchLastName = new Button();
            ButtonSearchName = new Button();
            ButtonSearchNationalCode = new Button();
            label9 = new Label();
            TextBoxSearchLastName = new BaseControl.MyTextBox();
            label10 = new Label();
            label11 = new Label();
            TextBoxSearchName = new BaseControl.MyTextBox();
            TextBoxSearchNationalCode = new BaseControl.MyTextBox();
            panel2 = new Panel();
            button1 = new Button();
            DatePickerDateOfBirth = new BaseControl.Dropdown();
            ButtonOpenImage = new Button();
            pictureBoxStudent = new PictureBox();
            BtnDelete = new Button();
            BtnPrint = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            label8 = new Label();
            TextBoxAddress = new TextBox();
            label7 = new Label();
            TextBoxPhone = new BaseControl.MyTextBox();
            label6 = new Label();
            label5 = new Label();
            ComboBoxSex = new BaseControl.MyComboBox();
            label4 = new Label();
            ComboBox_ID_FK_Degree = new BaseControl.MyComboBox();
            label3 = new Label();
            TextBoxLastName = new BaseControl.MyTextBox();
            label2 = new Label();
            label1 = new Label();
            TextBoxName = new BaseControl.MyTextBox();
            TextBoxNationalCode = new BaseControl.MyTextBox();
            panel3 = new Panel();
            DgvStudent = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderStudent = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudent).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderStudent).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(ButtonSearchMore);
            groupBox1.Controls.Add(ButtonSearchLastName);
            groupBox1.Controls.Add(ButtonSearchName);
            groupBox1.Controls.Add(ButtonSearchNationalCode);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TextBoxSearchLastName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TextBoxSearchName);
            groupBox1.Controls.Add(TextBoxSearchNationalCode);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 678);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1472, 169);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // ButtonSearchMore
            // 
            ButtonSearchMore.Location = new Point(76, 63);
            ButtonSearchMore.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchMore.Name = "ButtonSearchMore";
            ButtonSearchMore.Size = new Size(140, 48);
            ButtonSearchMore.TabIndex = 9;
            ButtonSearchMore.Text = "جستجوی بیشتر";
            ButtonSearchMore.UseVisualStyleBackColor = true;
            ButtonSearchMore.Click += ButtonSearchMore_Click;
            // 
            // ButtonSearchLastName
            // 
            ButtonSearchLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchLastName.Image = Properties.Resources.search_1_;
            ButtonSearchLastName.Location = new Point(280, 70);
            ButtonSearchLastName.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchLastName.Name = "ButtonSearchLastName";
            ButtonSearchLastName.Size = new Size(37, 36);
            ButtonSearchLastName.TabIndex = 8;
            ButtonSearchLastName.UseVisualStyleBackColor = true;
            ButtonSearchLastName.Click += ButtonSearchLastName_Click;
            // 
            // ButtonSearchName
            // 
            ButtonSearchName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchName.Image = Properties.Resources.search_1_;
            ButtonSearchName.Location = new Point(730, 69);
            ButtonSearchName.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchName.Name = "ButtonSearchName";
            ButtonSearchName.Size = new Size(37, 36);
            ButtonSearchName.TabIndex = 5;
            ButtonSearchName.UseVisualStyleBackColor = true;
            ButtonSearchName.Click += ButtonSearchName_Click;
            // 
            // ButtonSearchNationalCode
            // 
            ButtonSearchNationalCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchNationalCode.Image = Properties.Resources.search_1_;
            ButtonSearchNationalCode.Location = new Point(1106, 73);
            ButtonSearchNationalCode.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchNationalCode.Name = "ButtonSearchNationalCode";
            ButtonSearchNationalCode.Size = new Size(37, 36);
            ButtonSearchNationalCode.TabIndex = 2;
            ButtonSearchNationalCode.UseVisualStyleBackColor = true;
            ButtonSearchNationalCode.Click += ButtonSearchNationalCode_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(556, 77);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 6;
            label9.Text = "نام خانوادگی";
            // 
            // TextBoxSearchLastName
            // 
            TextBoxSearchLastName.IsNumber = false;
            TextBoxSearchLastName.IsReal = false;
            TextBoxSearchLastName.Location = new Point(324, 73);
            TextBoxSearchLastName.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchLastName.Name = "TextBoxSearchLastName";
            TextBoxSearchLastName.Size = new Size(200, 27);
            TextBoxSearchLastName.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1007, 75);
            label10.Name = "label10";
            label10.Size = new Size(30, 23);
            label10.TabIndex = 3;
            label10.Text = "نام";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1384, 75);
            label11.Name = "label11";
            label11.Size = new Size(58, 23);
            label11.TabIndex = 0;
            label11.Text = "کدملی";
            // 
            // TextBoxSearchName
            // 
            TextBoxSearchName.IsNumber = false;
            TextBoxSearchName.IsReal = false;
            TextBoxSearchName.Location = new Point(774, 75);
            TextBoxSearchName.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchName.Name = "TextBoxSearchName";
            TextBoxSearchName.Size = new Size(200, 27);
            TextBoxSearchName.TabIndex = 4;
            // 
            // TextBoxSearchNationalCode
            // 
            TextBoxSearchNationalCode.IsNumber = true;
            TextBoxSearchNationalCode.IsReal = false;
            TextBoxSearchNationalCode.Location = new Point(1151, 75);
            TextBoxSearchNationalCode.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchNationalCode.Name = "TextBoxSearchNationalCode";
            TextBoxSearchNationalCode.Size = new Size(200, 27);
            TextBoxSearchNationalCode.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(DatePickerDateOfBirth);
            panel2.Controls.Add(ButtonOpenImage);
            panel2.Controls.Add(pictureBoxStudent);
            panel2.Controls.Add(BtnDelete);
            panel2.Controls.Add(BtnPrint);
            panel2.Controls.Add(BtnNew);
            panel2.Controls.Add(BtnEdit);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(TextBoxAddress);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TextBoxPhone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ComboBoxSex);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ComboBox_ID_FK_Degree);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TextBoxLastName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TextBoxName);
            panel2.Controls.Add(TextBoxNationalCode);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(932, 78);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 600);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(9, 188);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(53, 35);
            button1.TabIndex = 17;
            button1.Text = "ذخیره";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DatePickerDateOfBirth
            // 
            DatePickerDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePickerDateOfBirth.InputMask = "";
            DatePickerDateOfBirth.Location = new Point(180, 285);
            DatePickerDateOfBirth.Margin = new Padding(4);
            DatePickerDateOfBirth.Name = "DatePickerDateOfBirth";
            DatePickerDateOfBirth.Size = new Size(245, 30);
            DatePickerDateOfBirth.TabIndex = 10;
            DatePickerDateOfBirth.Value = "";
            // 
            // ButtonOpenImage
            // 
            ButtonOpenImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonOpenImage.ImageAlign = ContentAlignment.TopCenter;
            ButtonOpenImage.Location = new Point(65, 188);
            ButtonOpenImage.Margin = new Padding(3, 4, 3, 4);
            ButtonOpenImage.Name = "ButtonOpenImage";
            ButtonOpenImage.Size = new Size(106, 35);
            ButtonOpenImage.TabIndex = 16;
            ButtonOpenImage.Text = "انتخاب تصویر";
            ButtonOpenImage.UseVisualStyleBackColor = true;
            ButtonOpenImage.Click += ButtonOpenImage_Click;
            // 
            // pictureBoxStudent
            // 
            pictureBoxStudent.BackColor = Color.White;
            pictureBoxStudent.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxStudent.Location = new Point(10, 23);
            pictureBoxStudent.Margin = new Padding(3, 4, 3, 4);
            pictureBoxStudent.Name = "pictureBoxStudent";
            pictureBoxStudent.Size = new Size(159, 161);
            pictureBoxStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudent.TabIndex = 20;
            pictureBoxStudent.TabStop = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.DeleteImage;
            BtnDelete.ImageAlign = ContentAlignment.MiddleRight;
            BtnDelete.Location = new Point(147, 504);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(102, 65);
            BtnDelete.TabIndex = 20;
            BtnDelete.Text = "حذف";
            BtnDelete.TextAlign = ContentAlignment.MiddleLeft;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Image = Properties.Resources.PrintImge;
            BtnPrint.ImageAlign = ContentAlignment.MiddleRight;
            BtnPrint.Location = new Point(29, 504);
            BtnPrint.Margin = new Padding(3, 4, 3, 4);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(102, 65);
            BtnPrint.TabIndex = 21;
            BtnPrint.Text = "پرنیت";
            BtnPrint.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.InsertImage;
            BtnNew.ImageAlign = ContentAlignment.MiddleRight;
            BtnNew.Location = new Point(384, 504);
            BtnNew.Margin = new Padding(3, 4, 3, 4);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(102, 65);
            BtnNew.TabIndex = 18;
            BtnNew.Text = "جدید";
            BtnNew.TextAlign = ContentAlignment.MiddleLeft;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.UpdateImage;
            BtnEdit.ImageAlign = ContentAlignment.MiddleRight;
            BtnEdit.Location = new Point(267, 504);
            BtnEdit.Margin = new Padding(3, 4, 3, 4);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(102, 65);
            BtnEdit.TabIndex = 19;
            BtnEdit.Text = "ویرایش";
            BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(432, 385);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 15;
            label8.Text = "آدرس";
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.Location = new Point(180, 385);
            TextBoxAddress.Margin = new Padding(3, 4, 3, 4);
            TextBoxAddress.Multiline = true;
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(245, 94);
            TextBoxAddress.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 338);
            label7.Name = "label7";
            label7.Size = new Size(42, 23);
            label7.TabIndex = 13;
            label7.Text = "تلفن";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.IsNumber = true;
            TextBoxPhone.IsReal = false;
            TextBoxPhone.Location = new Point(180, 338);
            TextBoxPhone.Margin = new Padding(3, 5, 3, 5);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(219, 27);
            TextBoxPhone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 288);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 11;
            label6.Text = "تاریخ تولد";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 237);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 9;
            label5.Text = "جنسیت";
            // 
            // ComboBoxSex
            // 
            ComboBoxSex.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSex.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSex.DataSource = null;
            ComboBoxSex.DisplayMember = "";
            ComboBoxSex.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSex.Location = new Point(180, 237);
            ComboBoxSex.Margin = new Padding(3, 5, 3, 5);
            ComboBoxSex.Name = "ComboBoxSex";
            ComboBoxSex.SelectedIndex = -1;
            ComboBoxSex.SelectedValue = null;
            ComboBoxSex.Size = new Size(219, 31);
            ComboBoxSex.TabIndex = 8;
            ComboBoxSex.ValueMember = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 185);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 7;
            label4.Text = "مدرک";
            // 
            // ComboBox_ID_FK_Degree
            // 
            ComboBox_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.None;
            ComboBox_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.None;
            ComboBox_ID_FK_Degree.DataSource = null;
            ComboBox_ID_FK_Degree.DisplayMember = "";
            ComboBox_ID_FK_Degree.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBox_ID_FK_Degree.Location = new Point(180, 185);
            ComboBox_ID_FK_Degree.Margin = new Padding(3, 5, 3, 5);
            ComboBox_ID_FK_Degree.Name = "ComboBox_ID_FK_Degree";
            ComboBox_ID_FK_Degree.SelectedIndex = -1;
            ComboBox_ID_FK_Degree.SelectedValue = null;
            ComboBox_ID_FK_Degree.Size = new Size(219, 31);
            ComboBox_ID_FK_Degree.TabIndex = 6;
            ComboBox_ID_FK_Degree.ValueMember = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 131);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "نام خانوادگی";
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.IsNumber = false;
            TextBoxLastName.IsReal = false;
            TextBoxLastName.Location = new Point(180, 131);
            TextBoxLastName.Margin = new Padding(3, 5, 3, 5);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(219, 27);
            TextBoxLastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 75);
            label2.Name = "label2";
            label2.Size = new Size(30, 23);
            label2.TabIndex = 3;
            label2.Text = "نام";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "کدملی";
            // 
            // TextBoxName
            // 
            TextBoxName.IsNumber = false;
            TextBoxName.IsReal = false;
            TextBoxName.Location = new Point(180, 75);
            TextBoxName.Margin = new Padding(3, 5, 3, 5);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(219, 27);
            TextBoxName.TabIndex = 2;
            // 
            // TextBoxNationalCode
            // 
            TextBoxNationalCode.IsNumber = true;
            TextBoxNationalCode.IsReal = false;
            TextBoxNationalCode.Location = new Point(180, 23);
            TextBoxNationalCode.Margin = new Padding(3, 5, 3, 5);
            TextBoxNationalCode.Name = "TextBoxNationalCode";
            TextBoxNationalCode.Size = new Size(219, 27);
            TextBoxNationalCode.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(DgvStudent);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 78);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 600);
            panel3.TabIndex = 4;
            // 
            // DgvStudent
            // 
            DgvStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvStudent.BackgroundColor = SystemColors.ButtonHighlight;
            DgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvStudent.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DgvStudent.Dock = DockStyle.Fill;
            DgvStudent.Location = new Point(0, 0);
            DgvStudent.Margin = new Padding(3, 4, 3, 4);
            DgvStudent.Name = "DgvStudent";
            DgvStudent.ReadOnly = true;
            DgvStudent.RowHeadersWidth = 51;
            DgvStudent.Size = new Size(932, 600);
            DgvStudent.TabIndex = 0;
            DgvStudent.CellClick += DgvStudent_CellClick;
            DgvStudent.CellFormatting += DgvStudent_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderStudent
            // 
            errorProviderStudent.ContainerControl = this;
            errorProviderStudent.RightToLeft = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 847);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Margin = new Padding(6);
            Name = "StudentForm";
            Load += StudentForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudent).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView DgvStudent;
        private Label label1;
        private BaseControl.MyTextBox TextBoxNationalCode;
        private Label label2;
        private BaseControl.MyTextBox TextBoxName;
        private Label label4;
        private BaseControl.MyComboBox ComboBox_ID_FK_Degree;
        private Label label3;
        private BaseControl.MyTextBox TextBoxLastName;
        private Label label5;
        private BaseControl.MyComboBox ComboBoxSex;
        private Label label7;
        private BaseControl.MyTextBox TextBoxPhone;
        private Label label6;
        private Label label8;
        private TextBox TextBoxAddress;
        private Button BtnDelete;
        private Button BtnPrint;
        private Button BtnNew;
        private Button BtnEdit;
        private PictureBox pictureBoxStudent;
        private Button ButtonOpenImage;
        private BaseControl.Dropdown DatePickerDateOfBirth;
        private ErrorProvider errorProviderStudent;
        private Button button1;
        private Label label9;
        private BaseControl.MyTextBox TextBoxSearchLastName;
        private Label label10;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchName;
        private BaseControl.MyTextBox TextBoxSearchNationalCode;
        private Button ButtonSearchNationalCode;
        private Button ButtonSearchLastName;
        private Button ButtonSearchName;
        private Button ButtonSearchMore;
        private DataGridViewTextBoxColumn ColumnRowNumber;
    }
}