namespace Wfa_ZabanSara.Forms
{
    partial class SearchCourseGroupForm
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
            label10 = new Label();
            label9 = new Label();
            ButtonSearchCourseYear = new Button();
            ButtonSearchCourseName = new Button();
            ButtonSearchCourseTeacher = new Button();
            TextBoxSearchCourseYear = new BaseControl.MyTextBox();
            label11 = new Label();
            TextBoxSearchCourseName = new BaseControl.MyTextBox();
            TextBoxSearchCourseTeacher = new BaseControl.MyTextBox();
            ButtonPrintCourseGroup = new Button();
            panel2 = new Panel();
            DgvCourseGroup = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseGroup).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(570, 38);
            label10.Name = "label10";
            label10.Size = new Size(53, 17);
            label10.TabIndex = 12;
            label10.Text = "نام درس";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(862, 38);
            label9.Name = "label9";
            label9.Size = new Size(36, 17);
            label9.TabIndex = 9;
            label9.Text = "استاد";
            // 
            // ButtonSearchCourseYear
            // 
            ButtonSearchCourseYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseYear.Image = Properties.Resources.search_1_;
            ButtonSearchCourseYear.Location = new Point(125, 33);
            ButtonSearchCourseYear.Name = "ButtonSearchCourseYear";
            ButtonSearchCourseYear.Size = new Size(33, 29);
            ButtonSearchCourseYear.TabIndex = 17;
            ButtonSearchCourseYear.UseVisualStyleBackColor = true;
            ButtonSearchCourseYear.Click += ButtonSearchCourseYear_Click;
            // 
            // ButtonSearchCourseName
            // 
            ButtonSearchCourseName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseName.Image = Properties.Resources.search_1_;
            ButtonSearchCourseName.Location = new Point(356, 33);
            ButtonSearchCourseName.Name = "ButtonSearchCourseName";
            ButtonSearchCourseName.Size = new Size(33, 29);
            ButtonSearchCourseName.TabIndex = 14;
            ButtonSearchCourseName.UseVisualStyleBackColor = true;
            ButtonSearchCourseName.Click += ButtonSearchCourseName_Click;
            // 
            // ButtonSearchCourseTeacher
            // 
            ButtonSearchCourseTeacher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseTeacher.Image = Properties.Resources.search_1_;
            ButtonSearchCourseTeacher.Location = new Point(648, 33);
            ButtonSearchCourseTeacher.Name = "ButtonSearchCourseTeacher";
            ButtonSearchCourseTeacher.Size = new Size(33, 29);
            ButtonSearchCourseTeacher.TabIndex = 11;
            ButtonSearchCourseTeacher.UseVisualStyleBackColor = true;
            ButtonSearchCourseTeacher.Click += ButtonSearchCourseTeacher_Click;
            // 
            // TextBoxSearchCourseYear
            // 
            TextBoxSearchCourseYear.IsNumber = true;
            TextBoxSearchCourseYear.IsReal = false;
            TextBoxSearchCourseYear.Location = new Point(164, 35);
            TextBoxSearchCourseYear.Name = "TextBoxSearchCourseYear";
            TextBoxSearchCourseYear.Size = new Size(133, 23);
            TextBoxSearchCourseYear.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(303, 37);
            label11.Name = "label11";
            label11.Size = new Size(31, 17);
            label11.TabIndex = 15;
            label11.Text = "سال";
            // 
            // TextBoxSearchCourseName
            // 
            TextBoxSearchCourseName.IsNumber = false;
            TextBoxSearchCourseName.IsReal = false;
            TextBoxSearchCourseName.Location = new Point(395, 36);
            TextBoxSearchCourseName.Name = "TextBoxSearchCourseName";
            TextBoxSearchCourseName.Size = new Size(170, 23);
            TextBoxSearchCourseName.TabIndex = 13;
            // 
            // TextBoxSearchCourseTeacher
            // 
            TextBoxSearchCourseTeacher.IsNumber = true;
            TextBoxSearchCourseTeacher.IsReal = false;
            TextBoxSearchCourseTeacher.Location = new Point(687, 35);
            TextBoxSearchCourseTeacher.Name = "TextBoxSearchCourseTeacher";
            TextBoxSearchCourseTeacher.Size = new Size(171, 23);
            TextBoxSearchCourseTeacher.TabIndex = 10;
            // 
            // ButtonPrintCourseGroup
            // 
            ButtonPrintCourseGroup.Image = Properties.Resources.PrintImge;
            ButtonPrintCourseGroup.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintCourseGroup.Location = new Point(23, 19);
            ButtonPrintCourseGroup.Name = "ButtonPrintCourseGroup";
            ButtonPrintCourseGroup.Size = new Size(79, 53);
            ButtonPrintCourseGroup.TabIndex = 18;
            ButtonPrintCourseGroup.Text = "پرنیت";
            ButtonPrintCourseGroup.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintCourseGroup.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(TextBoxSearchCourseTeacher);
            panel2.Controls.Add(ButtonPrintCourseGroup);
            panel2.Controls.Add(TextBoxSearchCourseName);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(TextBoxSearchCourseYear);
            panel2.Controls.Add(ButtonSearchCourseYear);
            panel2.Controls.Add(ButtonSearchCourseTeacher);
            panel2.Controls.Add(ButtonSearchCourseName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 100);
            panel2.TabIndex = 19;
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
            DgvCourseGroup.Location = new Point(0, 163);
            DgvCourseGroup.Name = "DgvCourseGroup";
            DgvCourseGroup.ReadOnly = true;
            DgvCourseGroup.Size = new Size(914, 347);
            DgvCourseGroup.TabIndex = 20;
            DgvCourseGroup.CellFormatting += DgvCourseGroup_CellFormatting;
            DgvCourseGroup.DoubleClick += DgvCourseGroup_DoubleClick;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // SearchCourseGroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(DgvCourseGroup);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "SearchCourseGroupForm";
            Load += SearchCourseGroupForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DgvCourseGroup, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseGroup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label10;
        private Label label9;
        private Button ButtonSearchCourseYear;
        private Button ButtonSearchCourseName;
        private Button ButtonSearchCourseTeacher;
        private BaseControl.MyTextBox TextBoxSearchCourseYear;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchCourseName;
        private BaseControl.MyTextBox TextBoxSearchCourseTeacher;
        private Button ButtonPrintCourseGroup;
        private Panel panel2;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        public DataGridView DgvCourseGroup;
    }
}