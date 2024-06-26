namespace Wfa_ZabanSara.Forms
{
    partial class TeacherForm
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
            TeacherGroupBox = new GroupBox();
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
            StudentPanel = new Panel();
            ButtonSaveImage = new Button();
            ButtonChooseImage = new Button();
            PictureBoxTeacher = new PictureBox();
            ButtonDelete = new Button();
            ButtonPrint = new Button();
            ButtonNew = new Button();
            ButtonUpdate = new Button();
            label8 = new Label();
            TextBoxAddress = new TextBox();
            label6 = new Label();
            DatePickerDateOfBirth = new BaseControl.Dropdown();
            label5 = new Label();
            ComboBoxSex = new BaseControl.MyComboBox();
            label4 = new Label();
            ComboBox_ID_FK_Degree = new BaseControl.MyComboBox();
            label7 = new Label();
            label3 = new Label();
            TextBoxPhone = new BaseControl.MyTextBox();
            TextBoxLastName = new BaseControl.MyTextBox();
            label2 = new Label();
            TextBoxName = new BaseControl.MyTextBox();
            label1 = new Label();
            TextBoxNationalCode = new BaseControl.MyTextBox();
            DataGridViewTeacher = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderTeacher = new ErrorProvider(components);
            TeacherGroupBox.SuspendLayout();
            StudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTeacher).BeginInit();
            SuspendLayout();
            // 
            // TeacherGroupBox
            // 
            TeacherGroupBox.Controls.Add(ButtonSearchMore);
            TeacherGroupBox.Controls.Add(ButtonSearchLastName);
            TeacherGroupBox.Controls.Add(ButtonSearchName);
            TeacherGroupBox.Controls.Add(ButtonSearchNationalCode);
            TeacherGroupBox.Controls.Add(label9);
            TeacherGroupBox.Controls.Add(TextBoxSearchLastName);
            TeacherGroupBox.Controls.Add(label10);
            TeacherGroupBox.Controls.Add(label11);
            TeacherGroupBox.Controls.Add(TextBoxSearchName);
            TeacherGroupBox.Controls.Add(TextBoxSearchNationalCode);
            TeacherGroupBox.Dock = DockStyle.Bottom;
            TeacherGroupBox.Location = new Point(0, 543);
            TeacherGroupBox.Name = "TeacherGroupBox";
            TeacherGroupBox.Size = new Size(1212, 94);
            TeacherGroupBox.TabIndex = 3;
            TeacherGroupBox.TabStop = false;
            TeacherGroupBox.Text = "جستجو";
            // 
            // ButtonSearchMore
            // 
            ButtonSearchMore.Location = new Point(39, 28);
            ButtonSearchMore.Name = "ButtonSearchMore";
            ButtonSearchMore.Size = new Size(124, 39);
            ButtonSearchMore.TabIndex = 9;
            ButtonSearchMore.Text = "جستجوی بیشتر";
            ButtonSearchMore.UseVisualStyleBackColor = true;
            ButtonSearchMore.Click += ButtonSearchMore_Click;
            // 
            // ButtonSearchLastName
            // 
            ButtonSearchLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchLastName.Image = Properties.Resources.search_1_;
            ButtonSearchLastName.Location = new Point(209, 35);
            ButtonSearchLastName.Name = "ButtonSearchLastName";
            ButtonSearchLastName.Size = new Size(33, 29);
            ButtonSearchLastName.TabIndex = 8;
            ButtonSearchLastName.UseVisualStyleBackColor = true;
            ButtonSearchLastName.Click += ButtonSearchLastName_Click;
            // 
            // ButtonSearchName
            // 
            ButtonSearchName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchName.Image = Properties.Resources.search_1_;
            ButtonSearchName.Location = new Point(580, 36);
            ButtonSearchName.Name = "ButtonSearchName";
            ButtonSearchName.Size = new Size(33, 29);
            ButtonSearchName.TabIndex = 5;
            ButtonSearchName.UseVisualStyleBackColor = true;
            ButtonSearchName.Click += ButtonSearchName_Click;
            // 
            // ButtonSearchNationalCode
            // 
            ButtonSearchNationalCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchNationalCode.Image = Properties.Resources.search_1_;
            ButtonSearchNationalCode.Location = new Point(897, 36);
            ButtonSearchNationalCode.Name = "ButtonSearchNationalCode";
            ButtonSearchNationalCode.Size = new Size(33, 29);
            ButtonSearchNationalCode.TabIndex = 2;
            ButtonSearchNationalCode.UseVisualStyleBackColor = true;
            ButtonSearchNationalCode.Click += ButtonSearchNationalCode_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(448, 40);
            label9.Name = "label9";
            label9.Size = new Size(77, 17);
            label9.TabIndex = 6;
            label9.Text = "نام خانوادگی";
            // 
            // TextBoxSearchLastName
            // 
            TextBoxSearchLastName.IsNumber = false;
            TextBoxSearchLastName.IsReal = false;
            TextBoxSearchLastName.Location = new Point(247, 38);
            TextBoxSearchLastName.Name = "TextBoxSearchLastName";
            TextBoxSearchLastName.Size = new Size(200, 23);
            TextBoxSearchLastName.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(826, 39);
            label10.Name = "label10";
            label10.Size = new Size(23, 17);
            label10.TabIndex = 3;
            label10.Text = "نام";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1144, 38);
            label11.Name = "label11";
            label11.Size = new Size(45, 17);
            label11.TabIndex = 0;
            label11.Text = "کدملی";
            // 
            // TextBoxSearchName
            // 
            TextBoxSearchName.IsNumber = false;
            TextBoxSearchName.IsReal = false;
            TextBoxSearchName.Location = new Point(619, 38);
            TextBoxSearchName.Name = "TextBoxSearchName";
            TextBoxSearchName.Size = new Size(200, 23);
            TextBoxSearchName.TabIndex = 4;
            // 
            // TextBoxSearchNationalCode
            // 
            TextBoxSearchNationalCode.IsNumber = true;
            TextBoxSearchNationalCode.IsReal = false;
            TextBoxSearchNationalCode.Location = new Point(937, 38);
            TextBoxSearchNationalCode.Name = "TextBoxSearchNationalCode";
            TextBoxSearchNationalCode.Size = new Size(200, 23);
            TextBoxSearchNationalCode.TabIndex = 1;
            // 
            // StudentPanel
            // 
            StudentPanel.Controls.Add(ButtonSaveImage);
            StudentPanel.Controls.Add(ButtonChooseImage);
            StudentPanel.Controls.Add(PictureBoxTeacher);
            StudentPanel.Controls.Add(ButtonDelete);
            StudentPanel.Controls.Add(ButtonPrint);
            StudentPanel.Controls.Add(ButtonNew);
            StudentPanel.Controls.Add(ButtonUpdate);
            StudentPanel.Controls.Add(label8);
            StudentPanel.Controls.Add(TextBoxAddress);
            StudentPanel.Controls.Add(label6);
            StudentPanel.Controls.Add(DatePickerDateOfBirth);
            StudentPanel.Controls.Add(label5);
            StudentPanel.Controls.Add(ComboBoxSex);
            StudentPanel.Controls.Add(label4);
            StudentPanel.Controls.Add(ComboBox_ID_FK_Degree);
            StudentPanel.Controls.Add(label7);
            StudentPanel.Controls.Add(label3);
            StudentPanel.Controls.Add(TextBoxPhone);
            StudentPanel.Controls.Add(TextBoxLastName);
            StudentPanel.Controls.Add(label2);
            StudentPanel.Controls.Add(TextBoxName);
            StudentPanel.Controls.Add(label1);
            StudentPanel.Controls.Add(TextBoxNationalCode);
            StudentPanel.Dock = DockStyle.Right;
            StudentPanel.Location = new Point(758, 63);
            StudentPanel.Name = "StudentPanel";
            StudentPanel.Size = new Size(454, 480);
            StudentPanel.TabIndex = 0;
            // 
            // ButtonSaveImage
            // 
            ButtonSaveImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSaveImage.Location = new Point(20, 144);
            ButtonSaveImage.Name = "ButtonSaveImage";
            ButtonSaveImage.Size = new Size(51, 23);
            ButtonSaveImage.TabIndex = 21;
            ButtonSaveImage.Text = "ذخیره";
            ButtonSaveImage.UseVisualStyleBackColor = true;
            ButtonSaveImage.Click += ButtonSaveImage_Click;
            // 
            // ButtonChooseImage
            // 
            ButtonChooseImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonChooseImage.Location = new Point(72, 143);
            ButtonChooseImage.Name = "ButtonChooseImage";
            ButtonChooseImage.Size = new Size(83, 24);
            ButtonChooseImage.TabIndex = 20;
            ButtonChooseImage.Text = "انتخاب تصویر";
            ButtonChooseImage.UseVisualStyleBackColor = true;
            ButtonChooseImage.Click += ButtonChooseImage_Click;
            // 
            // PictureBoxTeacher
            // 
            PictureBoxTeacher.BackColor = Color.White;
            PictureBoxTeacher.BorderStyle = BorderStyle.Fixed3D;
            PictureBoxTeacher.Location = new Point(20, 16);
            PictureBoxTeacher.Name = "PictureBoxTeacher";
            PictureBoxTeacher.Size = new Size(135, 125);
            PictureBoxTeacher.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxTeacher.TabIndex = 26;
            PictureBoxTeacher.TabStop = false;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Image = Properties.Resources.DeleteImage;
            ButtonDelete.ImageAlign = ContentAlignment.MiddleRight;
            ButtonDelete.Location = new Point(129, 412);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(91, 53);
            ButtonDelete.TabIndex = 18;
            ButtonDelete.Text = "حذف";
            ButtonDelete.TextAlign = ContentAlignment.MiddleLeft;
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonPrint
            // 
            ButtonPrint.Image = Properties.Resources.PrintImge;
            ButtonPrint.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrint.Location = new Point(24, 412);
            ButtonPrint.Name = "ButtonPrint";
            ButtonPrint.Size = new Size(91, 53);
            ButtonPrint.TabIndex = 19;
            ButtonPrint.Text = "پرنیت";
            ButtonPrint.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrint.UseVisualStyleBackColor = true;
            // 
            // ButtonNew
            // 
            ButtonNew.Image = Properties.Resources.InsertImage;
            ButtonNew.ImageAlign = ContentAlignment.MiddleRight;
            ButtonNew.Location = new Point(339, 412);
            ButtonNew.Name = "ButtonNew";
            ButtonNew.Size = new Size(91, 53);
            ButtonNew.TabIndex = 16;
            ButtonNew.Text = "جدید";
            ButtonNew.TextAlign = ContentAlignment.MiddleLeft;
            ButtonNew.UseVisualStyleBackColor = true;
            ButtonNew.Click += ButtonNew_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Image = Properties.Resources.UpdateImage;
            ButtonUpdate.ImageAlign = ContentAlignment.MiddleRight;
            ButtonUpdate.Location = new Point(235, 412);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(91, 53);
            ButtonUpdate.TabIndex = 17;
            ButtonUpdate.Text = "ویرایش";
            ButtonUpdate.TextAlign = ContentAlignment.MiddleLeft;
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 330);
            label8.Name = "label8";
            label8.Size = new Size(37, 17);
            label8.TabIndex = 14;
            label8.Text = "آدرس";
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.Location = new Point(177, 330);
            TextBoxAddress.Multiline = true;
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(173, 67);
            TextBoxAddress.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 241);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 10;
            label6.Text = "تاریخ تولد";
            // 
            // DatePickerDateOfBirth
            // 
            DatePickerDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePickerDateOfBirth.InputMask = "";
            DatePickerDateOfBirth.Location = new Point(177, 235);
            DatePickerDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            DatePickerDateOfBirth.Name = "DatePickerDateOfBirth";
            DatePickerDateOfBirth.Size = new Size(172, 29);
            DatePickerDateOfBirth.TabIndex = 11;
            DatePickerDateOfBirth.Value = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 194);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 8;
            label5.Text = "جنسیت";
            // 
            // ComboBoxSex
            // 
            ComboBoxSex.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSex.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSex.DataSource = null;
            ComboBoxSex.DisplayMember = "";
            ComboBoxSex.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSex.Location = new Point(177, 190);
            ComboBoxSex.Name = "ComboBoxSex";
            ComboBoxSex.SelectedIndex = -1;
            ComboBoxSex.SelectedValue = null;
            ComboBoxSex.Size = new Size(173, 25);
            ComboBoxSex.TabIndex = 9;
            ComboBoxSex.ValueMember = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 148);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 6;
            label4.Text = "مدرک";
            // 
            // ComboBox_ID_FK_Degree
            // 
            ComboBox_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.None;
            ComboBox_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.None;
            ComboBox_ID_FK_Degree.DataSource = null;
            ComboBox_ID_FK_Degree.DisplayMember = "";
            ComboBox_ID_FK_Degree.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBox_ID_FK_Degree.Location = new Point(177, 144);
            ComboBox_ID_FK_Degree.Name = "ComboBox_ID_FK_Degree";
            ComboBox_ID_FK_Degree.SelectedIndex = -1;
            ComboBox_ID_FK_Degree.SelectedValue = null;
            ComboBox_ID_FK_Degree.Size = new Size(173, 25);
            ComboBox_ID_FK_Degree.TabIndex = 7;
            ComboBox_ID_FK_Degree.ValueMember = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 286);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 12;
            label7.Text = "تلفن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 103);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 4;
            label3.Text = "نام خانوادگی";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.IsNumber = true;
            TextBoxPhone.IsReal = false;
            TextBoxPhone.Location = new Point(176, 283);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(173, 23);
            TextBoxPhone.TabIndex = 13;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.IsNumber = false;
            TextBoxLastName.IsReal = false;
            TextBoxLastName.Location = new Point(177, 100);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(173, 23);
            TextBoxLastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 59);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 2;
            label2.Text = "نام";
            // 
            // TextBoxName
            // 
            TextBoxName.IsNumber = false;
            TextBoxName.IsReal = false;
            TextBoxName.Location = new Point(177, 56);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(173, 23);
            TextBoxName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 0;
            label1.Text = "کدملی";
            // 
            // TextBoxNationalCode
            // 
            TextBoxNationalCode.IsNumber = true;
            TextBoxNationalCode.IsReal = false;
            TextBoxNationalCode.Location = new Point(177, 16);
            TextBoxNationalCode.Name = "TextBoxNationalCode";
            TextBoxNationalCode.Size = new Size(173, 23);
            TextBoxNationalCode.TabIndex = 1;
            // 
            // DataGridViewTeacher
            // 
            DataGridViewTeacher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DataGridViewTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTeacher.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTeacher.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DataGridViewTeacher.Dock = DockStyle.Fill;
            DataGridViewTeacher.Location = new Point(0, 63);
            DataGridViewTeacher.Name = "DataGridViewTeacher";
            DataGridViewTeacher.ReadOnly = true;
            DataGridViewTeacher.Size = new Size(758, 480);
            DataGridViewTeacher.TabIndex = 5;
            DataGridViewTeacher.CellClick += DataGridViewTeacher_CellClick;
            DataGridViewTeacher.CellFormatting += DataGridViewTeacher_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderTeacher
            // 
            errorProviderTeacher.ContainerControl = this;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 637);
            Controls.Add(DataGridViewTeacher);
            Controls.Add(StudentPanel);
            Controls.Add(TeacherGroupBox);
            Margin = new Padding(5);
            Name = "TeacherForm";
            Load += TeacherForm_Load;
            Controls.SetChildIndex(TeacherGroupBox, 0);
            Controls.SetChildIndex(StudentPanel, 0);
            Controls.SetChildIndex(DataGridViewTeacher, 0);
            TeacherGroupBox.ResumeLayout(false);
            TeacherGroupBox.PerformLayout();
            StudentPanel.ResumeLayout(false);
            StudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox TeacherGroupBox;
        private Panel StudentPanel;
        private DataGridView DataGridViewTeacher;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private BaseControl.MyTextBox TextBoxNationalCode;
        private Label label3;
        private BaseControl.MyTextBox TextBoxLastName;
        private Label label2;
        private BaseControl.MyTextBox TextBoxName;
        private Label label1;
        private Label label8;
        private TextBox TextBoxAddress;
        private Label label6;
        private BaseControl.Dropdown DatePickerDateOfBirth;
        private Label label5;
        private BaseControl.MyComboBox ComboBoxSex;
        private Label label4;
        private BaseControl.MyComboBox ComboBox_ID_FK_Degree;
        private Label label7;
        private BaseControl.MyTextBox TextBoxPhone;
        private Button ButtonDelete;
        private Button ButtonPrint;
        private Button ButtonNew;
        private Button ButtonUpdate;
        private PictureBox PictureBoxTeacher;
        private Button ButtonSaveImage;
        private Button ButtonChooseImage;
        private ErrorProvider errorProviderTeacher;
        private Button ButtonSearchMore;
        private Button ButtonSearchLastName;
        private Button ButtonSearchName;
        private Button ButtonSearchNationalCode;
        private Label label9;
        private BaseControl.MyTextBox TextBoxSearchLastName;
        private Label label10;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchName;
        private BaseControl.MyTextBox TextBoxSearchNationalCode;
    }
}