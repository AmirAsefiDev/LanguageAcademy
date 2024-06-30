namespace Wfa_ZabanSara.Forms
{
    partial class CourseSelectForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label3 = new Label();
            TextBoxActivityScore = new BaseControl.MyTextBox();
            label2 = new Label();
            TextBoxFinalScore = new BaseControl.MyTextBox();
            label1 = new Label();
            TextBoxAttendScore = new BaseControl.MyTextBox();
            ButtonGroupSelection = new Button();
            ButtonDeleteCourseSelect = new Button();
            ButtonNewCourseSelect = new Button();
            ButtonEditCourseSelect = new Button();
            TextBoxStudentCourseSelect = new BaseControl.MyTextBox();
            ButtonPrintCourseSelect = new Button();
            TextBoxCourseGroup = new BaseControl.MyTextBox();
            label10 = new Label();
            label9 = new Label();
            ButtonStudentCourseSelect = new Button();
            ButtonCourseGroup = new Button();
            DgvCourseSelect = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderCourseSelect = new ErrorProvider(components);
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            ButtonSearchMore = new Button();
            ButtonSearchCourseGroupYear = new Button();
            ButtonSearchCourseGroup = new Button();
            ButtonSearchStudent = new Button();
            TextBoxSearchCourseGroupYear = new BaseControl.MyTextBox();
            label11 = new Label();
            TextBoxSearchCourseGroup = new BaseControl.MyTextBox();
            TextBoxSearchStudent = new BaseControl.MyTextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCourseSelect).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TextBoxActivityScore);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TextBoxFinalScore);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TextBoxAttendScore);
            panel2.Controls.Add(ButtonGroupSelection);
            panel2.Controls.Add(ButtonDeleteCourseSelect);
            panel2.Controls.Add(ButtonNewCourseSelect);
            panel2.Controls.Add(ButtonEditCourseSelect);
            panel2.Controls.Add(TextBoxStudentCourseSelect);
            panel2.Controls.Add(ButtonPrintCourseSelect);
            panel2.Controls.Add(TextBoxCourseGroup);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(ButtonStudentCourseSelect);
            panel2.Controls.Add(ButtonCourseGroup);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1175, 137);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 6;
            label3.Text = "نمره فعالیت";
            // 
            // TextBoxActivityScore
            // 
            TextBoxActivityScore.IsNumber = true;
            TextBoxActivityScore.IsReal = false;
            TextBoxActivityScore.Location = new Point(428, 27);
            TextBoxActivityScore.Name = "TextBoxActivityScore";
            TextBoxActivityScore.Size = new Size(84, 23);
            TextBoxActivityScore.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 30);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 10;
            label2.Text = "پایانی";
            // 
            // TextBoxFinalScore
            // 
            TextBoxFinalScore.IsNumber = true;
            TextBoxFinalScore.IsReal = false;
            TextBoxFinalScore.Location = new Point(63, 27);
            TextBoxFinalScore.Name = "TextBoxFinalScore";
            TextBoxFinalScore.Size = new Size(84, 23);
            TextBoxFinalScore.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 30);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 8;
            label1.Text = "نمره حضوروغیاب";
            // 
            // TextBoxAttendScore
            // 
            TextBoxAttendScore.IsNumber = true;
            TextBoxAttendScore.IsReal = false;
            TextBoxAttendScore.Location = new Point(220, 27);
            TextBoxAttendScore.Name = "TextBoxAttendScore";
            TextBoxAttendScore.Size = new Size(84, 23);
            TextBoxAttendScore.TabIndex = 9;
            // 
            // ButtonGroupSelection
            // 
            ButtonGroupSelection.Image = Properties.Resources.InsertImage;
            ButtonGroupSelection.ImageAlign = ContentAlignment.MiddleRight;
            ButtonGroupSelection.Location = new Point(13, 71);
            ButtonGroupSelection.Name = "ButtonGroupSelection";
            ButtonGroupSelection.Size = new Size(138, 53);
            ButtonGroupSelection.TabIndex = 16;
            ButtonGroupSelection.Text = "انتخاب گروهی";
            ButtonGroupSelection.TextAlign = ContentAlignment.MiddleLeft;
            ButtonGroupSelection.UseVisualStyleBackColor = true;
            ButtonGroupSelection.Click += ButtonGroupSelection_Click;
            // 
            // ButtonDeleteCourseSelect
            // 
            ButtonDeleteCourseSelect.Image = Properties.Resources.DeleteImage;
            ButtonDeleteCourseSelect.ImageAlign = ContentAlignment.MiddleRight;
            ButtonDeleteCourseSelect.Location = new Point(249, 71);
            ButtonDeleteCourseSelect.Name = "ButtonDeleteCourseSelect";
            ButtonDeleteCourseSelect.Size = new Size(93, 53);
            ButtonDeleteCourseSelect.TabIndex = 14;
            ButtonDeleteCourseSelect.Text = "حذف";
            ButtonDeleteCourseSelect.TextAlign = ContentAlignment.MiddleLeft;
            ButtonDeleteCourseSelect.UseVisualStyleBackColor = true;
            ButtonDeleteCourseSelect.Click += ButtonDeleteCourseSelect_Click;
            // 
            // ButtonNewCourseSelect
            // 
            ButtonNewCourseSelect.Image = Properties.Resources.InsertImage;
            ButtonNewCourseSelect.ImageAlign = ContentAlignment.MiddleRight;
            ButtonNewCourseSelect.Location = new Point(448, 71);
            ButtonNewCourseSelect.Name = "ButtonNewCourseSelect";
            ButtonNewCourseSelect.Size = new Size(93, 53);
            ButtonNewCourseSelect.TabIndex = 12;
            ButtonNewCourseSelect.Text = "جدید";
            ButtonNewCourseSelect.TextAlign = ContentAlignment.MiddleLeft;
            ButtonNewCourseSelect.UseVisualStyleBackColor = true;
            ButtonNewCourseSelect.Click += ButtonNewCourseSelect_Click;
            // 
            // ButtonEditCourseSelect
            // 
            ButtonEditCourseSelect.Image = Properties.Resources.UpdateImage;
            ButtonEditCourseSelect.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEditCourseSelect.Location = new Point(350, 71);
            ButtonEditCourseSelect.Name = "ButtonEditCourseSelect";
            ButtonEditCourseSelect.Size = new Size(91, 53);
            ButtonEditCourseSelect.TabIndex = 13;
            ButtonEditCourseSelect.Text = "ویرایش";
            ButtonEditCourseSelect.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEditCourseSelect.UseVisualStyleBackColor = true;
            ButtonEditCourseSelect.Click += ButtonEditCourseSelect_Click;
            // 
            // TextBoxStudentCourseSelect
            // 
            TextBoxStudentCourseSelect.IsNumber = true;
            TextBoxStudentCourseSelect.IsReal = false;
            TextBoxStudentCourseSelect.Location = new Point(984, 27);
            TextBoxStudentCourseSelect.Name = "TextBoxStudentCourseSelect";
            TextBoxStudentCourseSelect.Size = new Size(130, 23);
            TextBoxStudentCourseSelect.TabIndex = 1;
            // 
            // ButtonPrintCourseSelect
            // 
            ButtonPrintCourseSelect.Image = Properties.Resources.PrintImge;
            ButtonPrintCourseSelect.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintCourseSelect.Location = new Point(161, 71);
            ButtonPrintCourseSelect.Name = "ButtonPrintCourseSelect";
            ButtonPrintCourseSelect.Size = new Size(79, 53);
            ButtonPrintCourseSelect.TabIndex = 15;
            ButtonPrintCourseSelect.Text = "پرنیت";
            ButtonPrintCourseSelect.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintCourseSelect.UseVisualStyleBackColor = true;
            ButtonPrintCourseSelect.Click += ButtonPrintCourseSelect_Click;
            // 
            // TextBoxCourseGroup
            // 
            TextBoxCourseGroup.IsNumber = false;
            TextBoxCourseGroup.IsReal = false;
            TextBoxCourseGroup.Location = new Point(665, 27);
            TextBoxCourseGroup.Name = "TextBoxCourseGroup";
            TextBoxCourseGroup.Size = new Size(182, 23);
            TextBoxCourseGroup.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(853, 30);
            label10.Name = "label10";
            label10.Size = new Size(67, 17);
            label10.TabIndex = 3;
            label10.Text = "گروه درسی";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1120, 30);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 0;
            label9.Text = "دانشجو";
            // 
            // ButtonStudentCourseSelect
            // 
            ButtonStudentCourseSelect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonStudentCourseSelect.Image = Properties.Resources.search_1_;
            ButtonStudentCourseSelect.Location = new Point(933, 25);
            ButtonStudentCourseSelect.Name = "ButtonStudentCourseSelect";
            ButtonStudentCourseSelect.Size = new Size(33, 29);
            ButtonStudentCourseSelect.TabIndex = 2;
            ButtonStudentCourseSelect.UseVisualStyleBackColor = true;
            ButtonStudentCourseSelect.Click += ButtonStudentCourseSelect_Click;
            // 
            // ButtonCourseGroup
            // 
            ButtonCourseGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonCourseGroup.Image = Properties.Resources.search_1_;
            ButtonCourseGroup.Location = new Point(610, 25);
            ButtonCourseGroup.Name = "ButtonCourseGroup";
            ButtonCourseGroup.Size = new Size(33, 29);
            ButtonCourseGroup.TabIndex = 5;
            ButtonCourseGroup.UseVisualStyleBackColor = true;
            ButtonCourseGroup.Click += ButtonCourseGroup_Click;
            // 
            // DgvCourseSelect
            // 
            DgvCourseSelect.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            DgvCourseSelect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvCourseSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCourseSelect.BackgroundColor = SystemColors.ButtonHighlight;
            DgvCourseSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCourseSelect.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DgvCourseSelect.Dock = DockStyle.Fill;
            DgvCourseSelect.Location = new Point(0, 200);
            DgvCourseSelect.Name = "DgvCourseSelect";
            DgvCourseSelect.ReadOnly = true;
            DgvCourseSelect.Size = new Size(1175, 472);
            DgvCourseSelect.TabIndex = 2;
            DgvCourseSelect.CellClick += DgvCourseSelect_CellClick;
            DgvCourseSelect.CellFormatting += DgvCourseSelect_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderCourseSelect
            // 
            errorProviderCourseSelect.ContainerControl = this;
            errorProviderCourseSelect.RightToLeft = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 590);
            panel3.Name = "panel3";
            panel3.Size = new Size(1175, 82);
            panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ButtonSearchMore);
            groupBox1.Controls.Add(ButtonSearchCourseGroupYear);
            groupBox1.Controls.Add(ButtonSearchCourseGroup);
            groupBox1.Controls.Add(ButtonSearchStudent);
            groupBox1.Controls.Add(TextBoxSearchCourseGroupYear);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TextBoxSearchCourseGroup);
            groupBox1.Controls.Add(TextBoxSearchStudent);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1175, 80);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1092, 36);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 11;
            label5.Text = "دانشجو";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(753, 36);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 10;
            label4.Text = "گروه درسی";
            // 
            // ButtonSearchMore
            // 
            ButtonSearchMore.Location = new Point(45, 25);
            ButtonSearchMore.Name = "ButtonSearchMore";
            ButtonSearchMore.Size = new Size(102, 39);
            ButtonSearchMore.TabIndex = 9;
            ButtonSearchMore.Text = "جستجوی بیشتر";
            ButtonSearchMore.UseVisualStyleBackColor = true;
            ButtonSearchMore.Click += ButtonSearchMore_Click;
            // 
            // ButtonSearchCourseGroupYear
            // 
            ButtonSearchCourseGroupYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseGroupYear.Image = Properties.Resources.search_1_;
            ButtonSearchCourseGroupYear.Location = new Point(204, 32);
            ButtonSearchCourseGroupYear.Name = "ButtonSearchCourseGroupYear";
            ButtonSearchCourseGroupYear.Size = new Size(33, 29);
            ButtonSearchCourseGroupYear.TabIndex = 8;
            ButtonSearchCourseGroupYear.UseVisualStyleBackColor = true;
            ButtonSearchCourseGroupYear.Click += ButtonSearchCourseGroupYear_Click;
            // 
            // ButtonSearchCourseGroup
            // 
            ButtonSearchCourseGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseGroup.Image = Properties.Resources.search_1_;
            ButtonSearchCourseGroup.Location = new Point(538, 32);
            ButtonSearchCourseGroup.Name = "ButtonSearchCourseGroup";
            ButtonSearchCourseGroup.Size = new Size(33, 29);
            ButtonSearchCourseGroup.TabIndex = 5;
            ButtonSearchCourseGroup.UseVisualStyleBackColor = true;
            ButtonSearchCourseGroup.Click += ButtonSearchCourseGroup_Click;
            // 
            // ButtonSearchStudent
            // 
            ButtonSearchStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchStudent.Image = Properties.Resources.search_1_;
            ButtonSearchStudent.Location = new Point(876, 32);
            ButtonSearchStudent.Name = "ButtonSearchStudent";
            ButtonSearchStudent.Size = new Size(33, 29);
            ButtonSearchStudent.TabIndex = 2;
            ButtonSearchStudent.UseVisualStyleBackColor = true;
            ButtonSearchStudent.Click += ButtonSearchStudent_Click;
            // 
            // TextBoxSearchCourseGroupYear
            // 
            TextBoxSearchCourseGroupYear.IsNumber = true;
            TextBoxSearchCourseGroupYear.IsReal = false;
            TextBoxSearchCourseGroupYear.Location = new Point(243, 32);
            TextBoxSearchCourseGroupYear.Name = "TextBoxSearchCourseGroupYear";
            TextBoxSearchCourseGroupYear.Size = new Size(170, 23);
            TextBoxSearchCourseGroupYear.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(419, 35);
            label11.Name = "label11";
            label11.Size = new Size(31, 17);
            label11.TabIndex = 6;
            label11.Text = "سال";
            // 
            // TextBoxSearchCourseGroup
            // 
            TextBoxSearchCourseGroup.IsNumber = false;
            TextBoxSearchCourseGroup.IsReal = false;
            TextBoxSearchCourseGroup.Location = new Point(577, 33);
            TextBoxSearchCourseGroup.Name = "TextBoxSearchCourseGroup";
            TextBoxSearchCourseGroup.Size = new Size(170, 23);
            TextBoxSearchCourseGroup.TabIndex = 4;
            // 
            // TextBoxSearchStudent
            // 
            TextBoxSearchStudent.IsNumber = true;
            TextBoxSearchStudent.IsReal = false;
            TextBoxSearchStudent.Location = new Point(915, 32);
            TextBoxSearchStudent.Name = "TextBoxSearchStudent";
            TextBoxSearchStudent.Size = new Size(171, 23);
            TextBoxSearchStudent.TabIndex = 1;
            // 
            // CourseSelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 672);
            Controls.Add(panel3);
            Controls.Add(DgvCourseSelect);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "CourseSelectForm";
            Load += CourseSelectForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DgvCourseSelect, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCourseSelect).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private BaseControl.MyTextBox TextBoxStudentCourseSelect;
        private Button ButtonPrintCourseSelect;
        private BaseControl.MyTextBox TextBoxCourseGroup;
        private Label label10;
        private Label label9;
        private Button ButtonStudentCourseSelect;
        private Button ButtonCourseGroup;
        public DataGridView DgvCourseSelect;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private Label label3;
        private BaseControl.MyTextBox TextBoxActivityScore;
        private Label label2;
        private BaseControl.MyTextBox TextBoxFinalScore;
        private Label label1;
        private BaseControl.MyTextBox TextBoxAttendScore;
        private Button ButtonGroupSelection;
        private Button ButtonDeleteCourseSelect;
        private Button ButtonNewCourseSelect;
        private Button ButtonEditCourseSelect;
        private ErrorProvider errorProviderCourseSelect;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button ButtonSearchMore;
        private Button ButtonSearchCourseGroupYear;
        private Button ButtonSearchCourseGroup;
        private Button ButtonSearchStudent;
        private BaseControl.MyTextBox TextBoxSearchCourseGroupYear;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchCourseGroup;
        private BaseControl.MyTextBox TextBoxSearchStudent;
        private Label label5;
        private Label label4;
    }
}