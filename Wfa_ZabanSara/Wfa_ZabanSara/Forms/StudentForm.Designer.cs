namespace Wfa_ZabanSara.Forms
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudent).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderStudent).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 549);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1166, 137);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // panel2
            // 
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
            panel2.Location = new Point(707, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 486);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(6, 152);
            button1.Name = "button1";
            button1.Size = new Size(47, 28);
            button1.TabIndex = 21;
            button1.Text = "ذخیره";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DatePickerDateOfBirth
            // 
            DatePickerDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePickerDateOfBirth.InputMask = "";
            DatePickerDateOfBirth.Location = new Point(159, 229);
            DatePickerDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            DatePickerDateOfBirth.Name = "DatePickerDateOfBirth";
            DatePickerDateOfBirth.Size = new Size(201, 29);
            DatePickerDateOfBirth.TabIndex = 11;
            DatePickerDateOfBirth.Value = "";
            // 
            // ButtonOpenImage
            // 
            ButtonOpenImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonOpenImage.ImageAlign = ContentAlignment.TopCenter;
            ButtonOpenImage.Location = new Point(56, 152);
            ButtonOpenImage.Name = "ButtonOpenImage";
            ButtonOpenImage.Size = new Size(94, 28);
            ButtonOpenImage.TabIndex = 0;
            ButtonOpenImage.Text = "انتخاب تصویر";
            ButtonOpenImage.UseVisualStyleBackColor = true;
            ButtonOpenImage.Click += ButtonOpenImage_Click;
            // 
            // pictureBoxStudent
            // 
            pictureBoxStudent.BackColor = Color.White;
            pictureBoxStudent.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxStudent.Location = new Point(7, 19);
            pictureBoxStudent.Name = "pictureBoxStudent";
            pictureBoxStudent.Size = new Size(142, 131);
            pictureBoxStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudent.TabIndex = 20;
            pictureBoxStudent.TabStop = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.DeleteImage;
            BtnDelete.ImageAlign = ContentAlignment.MiddleRight;
            BtnDelete.Location = new Point(131, 408);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(91, 53);
            BtnDelete.TabIndex = 19;
            BtnDelete.Text = "حذف";
            BtnDelete.TextAlign = ContentAlignment.MiddleLeft;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Image = Properties.Resources.PrintImge;
            BtnPrint.ImageAlign = ContentAlignment.MiddleRight;
            BtnPrint.Location = new Point(26, 408);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(91, 53);
            BtnPrint.TabIndex = 20;
            BtnPrint.Text = "پرنیت";
            BtnPrint.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.InsertImage;
            BtnNew.ImageAlign = ContentAlignment.MiddleRight;
            BtnNew.Location = new Point(341, 408);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(91, 53);
            BtnNew.TabIndex = 17;
            BtnNew.Text = "جدید";
            BtnNew.TextAlign = ContentAlignment.MiddleLeft;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.UpdateImage;
            BtnEdit.ImageAlign = ContentAlignment.MiddleRight;
            BtnEdit.Location = new Point(237, 408);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(91, 53);
            BtnEdit.TabIndex = 18;
            BtnEdit.Text = "ویرایش";
            BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 312);
            label8.Name = "label8";
            label8.Size = new Size(37, 17);
            label8.TabIndex = 16;
            label8.Text = "آدرس";
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.Location = new Point(159, 312);
            TextBoxAddress.Multiline = true;
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(201, 77);
            TextBoxAddress.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 274);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 14;
            label7.Text = "تلفن";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.IsNumber = true;
            TextBoxPhone.IsReal = false;
            TextBoxPhone.Location = new Point(159, 274);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(200, 23);
            TextBoxPhone.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 233);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 12;
            label6.Text = "تاریخ تولد";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 192);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 10;
            label5.Text = "جنسیت";
            // 
            // ComboBoxSex
            // 
            ComboBoxSex.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxSex.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxSex.DataSource = null;
            ComboBoxSex.DisplayMember = "";
            ComboBoxSex.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSex.Location = new Point(159, 192);
            ComboBoxSex.Name = "ComboBoxSex";
            ComboBoxSex.SelectedIndex = -1;
            ComboBoxSex.SelectedValue = null;
            ComboBoxSex.Size = new Size(200, 25);
            ComboBoxSex.TabIndex = 9;
            ComboBoxSex.ValueMember = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 150);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 8;
            label4.Text = "مدرک";
            // 
            // ComboBox_ID_FK_Degree
            // 
            ComboBox_ID_FK_Degree.AutoCompleteMode = AutoCompleteMode.None;
            ComboBox_ID_FK_Degree.AutoCompleteSource = AutoCompleteSource.None;
            ComboBox_ID_FK_Degree.DataSource = null;
            ComboBox_ID_FK_Degree.DisplayMember = "";
            ComboBox_ID_FK_Degree.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBox_ID_FK_Degree.Location = new Point(159, 150);
            ComboBox_ID_FK_Degree.Name = "ComboBox_ID_FK_Degree";
            ComboBox_ID_FK_Degree.SelectedIndex = -1;
            ComboBox_ID_FK_Degree.SelectedValue = null;
            ComboBox_ID_FK_Degree.Size = new Size(200, 25);
            ComboBox_ID_FK_Degree.TabIndex = 7;
            ComboBox_ID_FK_Degree.ValueMember = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 106);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 6;
            label3.Text = "نام خانوادگی";
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.IsNumber = false;
            TextBoxLastName.IsReal = false;
            TextBoxLastName.Location = new Point(159, 106);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(200, 23);
            TextBoxLastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 61);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 4;
            label2.Text = "نام";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 2;
            label1.Text = "کدملی";
            // 
            // TextBoxName
            // 
            TextBoxName.IsNumber = false;
            TextBoxName.IsReal = false;
            TextBoxName.Location = new Point(159, 61);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(200, 23);
            TextBoxName.TabIndex = 3;
            // 
            // TextBoxNationalCode
            // 
            TextBoxNationalCode.IsNumber = true;
            TextBoxNationalCode.IsReal = false;
            TextBoxNationalCode.Location = new Point(159, 19);
            TextBoxNationalCode.Name = "TextBoxNationalCode";
            TextBoxNationalCode.Size = new Size(200, 23);
            TextBoxNationalCode.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(DgvStudent);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(707, 486);
            panel3.TabIndex = 4;
            // 
            // DgvStudent
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvStudent.BackgroundColor = SystemColors.ButtonHighlight;
            DgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvStudent.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DgvStudent.Dock = DockStyle.Fill;
            DgvStudent.Location = new Point(0, 0);
            DgvStudent.Name = "DgvStudent";
            DgvStudent.Size = new Size(707, 486);
            DgvStudent.TabIndex = 0;
            DgvStudent.CellClick += DgvStudent_CellClick;
            DgvStudent.CellFormatting += DgvStudent_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            // 
            // errorProviderStudent
            // 
            errorProviderStudent.ContainerControl = this;
            errorProviderStudent.RightToLeft = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 686);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "StudentForm";
            WindowState = FormWindowState.Maximized;
            Load += StudentForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
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
        private DataGridViewTextBoxColumn ColumnRowNumber;
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
    }
}