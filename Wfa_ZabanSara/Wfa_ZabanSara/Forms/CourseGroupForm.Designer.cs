﻿namespace Wfa_ZabanSara.Forms
{
    partial class CourseGroupForm
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
            label10 = new Label();
            label9 = new Label();
            ButtonSearchMore = new Button();
            ButtonSearchCourseYear = new Button();
            ButtonSearchCourseName = new Button();
            ButtonSearchCourseTeacher = new Button();
            TextBoxSearchCourseYear = new BaseControl.MyTextBox();
            label11 = new Label();
            TextBoxSearchCourseName = new BaseControl.MyTextBox();
            TextBoxSearchCourseTeacher = new BaseControl.MyTextBox();
            panel2 = new Panel();
            TextBoxCourseYear = new BaseControl.MyTextBox();
            ButtonSearchTeacher = new Button();
            ButtonCourseName = new Button();
            TextBoxTerm = new BaseControl.MyTextBox();
            label5 = new Label();
            ButtonPrintCourseGroup = new Button();
            TextBoxWeekPlan = new TextBox();
            label6 = new Label();
            TextBoxCourseName = new BaseControl.MyTextBox();
            TextBoxTeacherCourse = new BaseControl.MyTextBox();
            TextBoxTuition = new BaseControl.MyTextBox();
            ButtonDeleteCourseGroup = new Button();
            ButtonNewCourseGroup = new Button();
            label1 = new Label();
            ButtonEditCourseGroup = new Button();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            ComboBoxLevelCourse = new BaseControl.MyComboBox();
            TextBoxClassNumber = new BaseControl.MyTextBox();
            label3 = new Label();
            DgvCourseGroup = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderCourseGroup = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCourseGroup).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(ButtonSearchMore);
            groupBox1.Controls.Add(ButtonSearchCourseYear);
            groupBox1.Controls.Add(ButtonSearchCourseName);
            groupBox1.Controls.Add(ButtonSearchCourseTeacher);
            groupBox1.Controls.Add(TextBoxSearchCourseYear);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TextBoxSearchCourseName);
            groupBox1.Controls.Add(TextBoxSearchCourseTeacher);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 724);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1360, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(881, 46);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 3;
            label10.Text = "نام درس";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1254, 46);
            label9.Name = "label9";
            label9.Size = new Size(47, 23);
            label9.TabIndex = 0;
            label9.Text = "استاد";
            // 
            // ButtonSearchMore
            // 
            ButtonSearchMore.Location = new Point(48, 33);
            ButtonSearchMore.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchMore.Name = "ButtonSearchMore";
            ButtonSearchMore.Size = new Size(135, 48);
            ButtonSearchMore.TabIndex = 9;
            ButtonSearchMore.Text = "جستجوی بیشتر";
            ButtonSearchMore.UseVisualStyleBackColor = true;
            ButtonSearchMore.Click += ButtonSearchMore_Click;
            // 
            // ButtonSearchCourseYear
            // 
            ButtonSearchCourseYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseYear.Image = Properties.Resources.search_1_;
            ButtonSearchCourseYear.Location = new Point(278, 40);
            ButtonSearchCourseYear.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchCourseYear.Name = "ButtonSearchCourseYear";
            ButtonSearchCourseYear.Size = new Size(37, 36);
            ButtonSearchCourseYear.TabIndex = 8;
            ButtonSearchCourseYear.UseVisualStyleBackColor = true;
            ButtonSearchCourseYear.Click += ButtonSearchCourseYear_Click;
            // 
            // ButtonSearchCourseName
            // 
            ButtonSearchCourseName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseName.Image = Properties.Resources.search_1_;
            ButtonSearchCourseName.Location = new Point(640, 40);
            ButtonSearchCourseName.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchCourseName.Name = "ButtonSearchCourseName";
            ButtonSearchCourseName.Size = new Size(37, 36);
            ButtonSearchCourseName.TabIndex = 5;
            ButtonSearchCourseName.UseVisualStyleBackColor = true;
            ButtonSearchCourseName.Click += ButtonSearchCourseName_Click;
            // 
            // ButtonSearchCourseTeacher
            // 
            ButtonSearchCourseTeacher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseTeacher.Image = Properties.Resources.search_1_;
            ButtonSearchCourseTeacher.Location = new Point(1014, 40);
            ButtonSearchCourseTeacher.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchCourseTeacher.Name = "ButtonSearchCourseTeacher";
            ButtonSearchCourseTeacher.Size = new Size(37, 36);
            ButtonSearchCourseTeacher.TabIndex = 2;
            ButtonSearchCourseTeacher.UseVisualStyleBackColor = true;
            ButtonSearchCourseTeacher.Click += ButtonSearchCourseTeacher_Click;
            // 
            // TextBoxSearchCourseYear
            // 
            TextBoxSearchCourseYear.IsNumber = true;
            TextBoxSearchCourseYear.IsReal = false;
            TextBoxSearchCourseYear.Location = new Point(322, 40);
            TextBoxSearchCourseYear.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchCourseYear.Name = "TextBoxSearchCourseYear";
            TextBoxSearchCourseYear.Size = new Size(170, 29);
            TextBoxSearchCourseYear.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(520, 44);
            label11.Name = "label11";
            label11.Size = new Size(39, 23);
            label11.TabIndex = 6;
            label11.Text = "سال";
            // 
            // TextBoxSearchCourseName
            // 
            TextBoxSearchCourseName.IsNumber = false;
            TextBoxSearchCourseName.IsReal = false;
            TextBoxSearchCourseName.Location = new Point(684, 41);
            TextBoxSearchCourseName.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchCourseName.Name = "TextBoxSearchCourseName";
            TextBoxSearchCourseName.Size = new Size(170, 29);
            TextBoxSearchCourseName.TabIndex = 4;
            // 
            // TextBoxSearchCourseTeacher
            // 
            TextBoxSearchCourseTeacher.IsNumber = true;
            TextBoxSearchCourseTeacher.IsReal = false;
            TextBoxSearchCourseTeacher.Location = new Point(1057, 40);
            TextBoxSearchCourseTeacher.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchCourseTeacher.Name = "TextBoxSearchCourseTeacher";
            TextBoxSearchCourseTeacher.Size = new Size(171, 29);
            TextBoxSearchCourseTeacher.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(TextBoxCourseYear);
            panel2.Controls.Add(ButtonSearchTeacher);
            panel2.Controls.Add(ButtonCourseName);
            panel2.Controls.Add(TextBoxTerm);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ButtonPrintCourseGroup);
            panel2.Controls.Add(TextBoxWeekPlan);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TextBoxCourseName);
            panel2.Controls.Add(TextBoxTeacherCourse);
            panel2.Controls.Add(TextBoxTuition);
            panel2.Controls.Add(ButtonDeleteCourseGroup);
            panel2.Controls.Add(ButtonNewCourseGroup);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ButtonEditCourseGroup);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ComboBoxLevelCourse);
            panel2.Controls.Add(TextBoxClassNumber);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(968, 78);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 646);
            panel2.TabIndex = 1;
            // 
            // TextBoxCourseYear
            // 
            TextBoxCourseYear.IsNumber = true;
            TextBoxCourseYear.IsReal = false;
            TextBoxCourseYear.Location = new Point(80, 224);
            TextBoxCourseYear.Margin = new Padding(3, 5, 3, 5);
            TextBoxCourseYear.Name = "TextBoxCourseYear";
            TextBoxCourseYear.Size = new Size(170, 29);
            TextBoxCourseYear.TabIndex = 13;
            // 
            // ButtonSearchTeacher
            // 
            ButtonSearchTeacher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchTeacher.Image = Properties.Resources.search_1_;
            ButtonSearchTeacher.Location = new Point(23, 172);
            ButtonSearchTeacher.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchTeacher.Name = "ButtonSearchTeacher";
            ButtonSearchTeacher.Size = new Size(37, 36);
            ButtonSearchTeacher.TabIndex = 11;
            ButtonSearchTeacher.UseVisualStyleBackColor = true;
            ButtonSearchTeacher.Click += ButtonSearchTeacher_Click;
            // 
            // ButtonCourseName
            // 
            ButtonCourseName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonCourseName.Image = Properties.Resources.search_1_;
            ButtonCourseName.Location = new Point(23, 17);
            ButtonCourseName.Margin = new Padding(3, 4, 3, 4);
            ButtonCourseName.Name = "ButtonCourseName";
            ButtonCourseName.Size = new Size(37, 36);
            ButtonCourseName.TabIndex = 2;
            ButtonCourseName.UseVisualStyleBackColor = true;
            ButtonCourseName.Click += ButtonCourseName_Click;
            // 
            // TextBoxTerm
            // 
            TextBoxTerm.IsNumber = true;
            TextBoxTerm.IsReal = false;
            TextBoxTerm.Location = new Point(80, 274);
            TextBoxTerm.Margin = new Padding(3, 5, 3, 5);
            TextBoxTerm.Name = "TextBoxTerm";
            TextBoxTerm.Size = new Size(172, 29);
            TextBoxTerm.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 274);
            label5.Name = "label5";
            label5.Size = new Size(32, 23);
            label5.TabIndex = 14;
            label5.Text = "ترم";
            // 
            // ButtonPrintCourseGroup
            // 
            ButtonPrintCourseGroup.Image = Properties.Resources.PrintImge;
            ButtonPrintCourseGroup.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintCourseGroup.Location = new Point(84, 562);
            ButtonPrintCourseGroup.Margin = new Padding(3, 4, 3, 4);
            ButtonPrintCourseGroup.Name = "ButtonPrintCourseGroup";
            ButtonPrintCourseGroup.Size = new Size(102, 65);
            ButtonPrintCourseGroup.TabIndex = 1;
            ButtonPrintCourseGroup.Text = "پرنیت";
            ButtonPrintCourseGroup.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintCourseGroup.UseVisualStyleBackColor = true;
            ButtonPrintCourseGroup.Click += ButtonPrintCourseGroup_Click;
            // 
            // TextBoxWeekPlan
            // 
            TextBoxWeekPlan.Location = new Point(80, 367);
            TextBoxWeekPlan.Margin = new Padding(3, 4, 3, 4);
            TextBoxWeekPlan.Multiline = true;
            TextBoxWeekPlan.Name = "TextBoxWeekPlan";
            TextBoxWeekPlan.Size = new Size(194, 94);
            TextBoxWeekPlan.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 224);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 12;
            label6.Text = "سال";
            // 
            // TextBoxCourseName
            // 
            TextBoxCourseName.Enabled = false;
            TextBoxCourseName.IsNumber = false;
            TextBoxCourseName.IsReal = false;
            TextBoxCourseName.Location = new Point(80, 25);
            TextBoxCourseName.Margin = new Padding(3, 5, 3, 5);
            TextBoxCourseName.Name = "TextBoxCourseName";
            TextBoxCourseName.Size = new Size(172, 29);
            TextBoxCourseName.TabIndex = 3;
            // 
            // TextBoxTeacherCourse
            // 
            TextBoxTeacherCourse.Enabled = false;
            TextBoxTeacherCourse.IsNumber = false;
            TextBoxTeacherCourse.IsReal = false;
            TextBoxTeacherCourse.Location = new Point(80, 174);
            TextBoxTeacherCourse.Margin = new Padding(3, 5, 3, 5);
            TextBoxTeacherCourse.Name = "TextBoxTeacherCourse";
            TextBoxTeacherCourse.Size = new Size(172, 29);
            TextBoxTeacherCourse.TabIndex = 10;
            // 
            // TextBoxTuition
            // 
            TextBoxTuition.IsNumber = true;
            TextBoxTuition.IsReal = false;
            TextBoxTuition.Location = new Point(80, 72);
            TextBoxTuition.Margin = new Padding(3, 5, 3, 5);
            TextBoxTuition.Name = "TextBoxTuition";
            TextBoxTuition.Size = new Size(172, 29);
            TextBoxTuition.TabIndex = 6;
            // 
            // ButtonDeleteCourseGroup
            // 
            ButtonDeleteCourseGroup.Image = Properties.Resources.DeleteImage;
            ButtonDeleteCourseGroup.ImageAlign = ContentAlignment.MiddleRight;
            ButtonDeleteCourseGroup.Location = new Point(199, 562);
            ButtonDeleteCourseGroup.Margin = new Padding(3, 4, 3, 4);
            ButtonDeleteCourseGroup.Name = "ButtonDeleteCourseGroup";
            ButtonDeleteCourseGroup.Size = new Size(105, 65);
            ButtonDeleteCourseGroup.TabIndex = 0;
            ButtonDeleteCourseGroup.Text = "حذف";
            ButtonDeleteCourseGroup.TextAlign = ContentAlignment.MiddleLeft;
            ButtonDeleteCourseGroup.UseVisualStyleBackColor = true;
            ButtonDeleteCourseGroup.Click += ButtonDeleteCourseGroup_Click;
            // 
            // ButtonNewCourseGroup
            // 
            ButtonNewCourseGroup.Image = Properties.Resources.InsertImage;
            ButtonNewCourseGroup.ImageAlign = ContentAlignment.MiddleRight;
            ButtonNewCourseGroup.Location = new Point(199, 483);
            ButtonNewCourseGroup.Margin = new Padding(3, 4, 3, 4);
            ButtonNewCourseGroup.Name = "ButtonNewCourseGroup";
            ButtonNewCourseGroup.Size = new Size(105, 65);
            ButtonNewCourseGroup.TabIndex = 20;
            ButtonNewCourseGroup.Text = "جدید";
            ButtonNewCourseGroup.TextAlign = ContentAlignment.MiddleLeft;
            ButtonNewCourseGroup.UseVisualStyleBackColor = true;
            ButtonNewCourseGroup.Click += ButtonNewCourseGroup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 4;
            label1.Text = "نام درس";
            // 
            // ButtonEditCourseGroup
            // 
            ButtonEditCourseGroup.Image = Properties.Resources.UpdateImage;
            ButtonEditCourseGroup.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEditCourseGroup.Location = new Point(84, 483);
            ButtonEditCourseGroup.Margin = new Padding(3, 4, 3, 4);
            ButtonEditCourseGroup.Name = "ButtonEditCourseGroup";
            ButtonEditCourseGroup.Size = new Size(102, 65);
            ButtonEditCourseGroup.TabIndex = 21;
            ButtonEditCourseGroup.Text = "ویرایش";
            ButtonEditCourseGroup.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEditCourseGroup.UseVisualStyleBackColor = true;
            ButtonEditCourseGroup.Click += ButtonEditCourseGroup_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 367);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 18;
            label8.Text = "برنامه هفتگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 180);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 9;
            label4.Text = "استاد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 72);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 5;
            label2.Text = "شهریه";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 320);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 16;
            label7.Text = "شماره کلاس";
            // 
            // ComboBoxLevelCourse
            // 
            ComboBoxLevelCourse.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxLevelCourse.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxLevelCourse.DataSource = null;
            ComboBoxLevelCourse.DisplayMember = "";
            ComboBoxLevelCourse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxLevelCourse.Location = new Point(80, 124);
            ComboBoxLevelCourse.Margin = new Padding(3, 5, 3, 5);
            ComboBoxLevelCourse.Name = "ComboBoxLevelCourse";
            ComboBoxLevelCourse.SelectedIndex = -1;
            ComboBoxLevelCourse.SelectedValue = null;
            ComboBoxLevelCourse.Size = new Size(172, 29);
            ComboBoxLevelCourse.TabIndex = 8;
            ComboBoxLevelCourse.ValueMember = "";
            // 
            // TextBoxClassNumber
            // 
            TextBoxClassNumber.IsNumber = true;
            TextBoxClassNumber.IsReal = false;
            TextBoxClassNumber.Location = new Point(80, 320);
            TextBoxClassNumber.Margin = new Padding(3, 5, 3, 5);
            TextBoxClassNumber.Name = "TextBoxClassNumber";
            TextBoxClassNumber.Size = new Size(172, 29);
            TextBoxClassNumber.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 124);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 7;
            label3.Text = "سطح";
            // 
            // DgvCourseGroup
            // 
            DgvCourseGroup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DgvCourseGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvCourseGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCourseGroup.BackgroundColor = SystemColors.ButtonHighlight;
            DgvCourseGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCourseGroup.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DgvCourseGroup.Dock = DockStyle.Fill;
            DgvCourseGroup.Location = new Point(0, 78);
            DgvCourseGroup.Margin = new Padding(3, 4, 3, 4);
            DgvCourseGroup.Name = "DgvCourseGroup";
            DgvCourseGroup.ReadOnly = true;
            DgvCourseGroup.RowHeadersWidth = 51;
            DgvCourseGroup.Size = new Size(968, 646);
            DgvCourseGroup.TabIndex = 3;
            DgvCourseGroup.CellClick += DgvCourseGroup_CellClick;
            DgvCourseGroup.CellFormatting += DgvCourseGroup_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderCourseGroup
            // 
            errorProviderCourseGroup.ContainerControl = this;
            errorProviderCourseGroup.RightToLeft = true;
            // 
            // CourseGroupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 823);
            Controls.Add(DgvCourseGroup);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CourseGroupForm";
            Load += CourseGroupForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DgvCourseGroup, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCourseGroup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private TextBox TextBoxWeekPlan;
        private Button ButtonDeleteCourseGroup;
        private Button ButtonNewCourseGroup;
        private Button ButtonEditCourseGroup;
        private Label label8;
        private Label label7;
        private BaseControl.MyTextBox TextBoxClassNumber;
        private Label label6;
        private BaseControl.MyTextBox TextBoxCourseName;
        private BaseControl.MyTextBox TextBoxTuition;
        private Label label1;
        private Label label2;
        private BaseControl.MyTextBox TextBoxTeacherCourse;
        private Label label3;
        private BaseControl.MyComboBox ComboBoxLevelCourse;
        private Label label4;
        private Button ButtonPrintCourseGroup;
        private BaseControl.MyTextBox TextBoxTerm;
        private Label label5;
        private Button ButtonSearchMore;
        private Button ButtonSearchCourseYear;
        private Button ButtonSearchCourseName;
        private Button ButtonSearchCourseTeacher;
        private BaseControl.MyTextBox TextBoxSearchCourseYear;
        private BaseControl.MyTextBox TextBoxSearchCourseName;
        private BaseControl.MyTextBox TextBoxSearchCourseTeacher;
        private Button ButtonSearchTeacher;
        private Button ButtonCourseName;
        private Label label10;
        private Label label9;
        private Label label11;
        private DataGridView DgvCourseGroup;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private BaseControl.MyTextBox TextBoxCourseYear;
        private ErrorProvider errorProviderCourseGroup;
    }
}