namespace Wfa_ZabanSara.Forms
{
    partial class SearchCourseForm
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
            label3 = new Label();
            label4 = new Label();
            ButtonPrintSearch = new Button();
            label2 = new Label();
            BtnSearchTuition = new Button();
            BtnSearchLevelCount = new Button();
            BtnSearchTitle = new Button();
            TextBoxSearchTuition = new BaseControl.MyTextBox();
            TextBoxSearchLevelCount = new BaseControl.MyTextBox();
            TextBoxSearchTitle = new BaseControl.MyTextBox();
            DataGridViewSearchCourse = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSearchCourse).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ButtonPrintSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnSearchTuition);
            groupBox1.Controls.Add(BtnSearchLevelCount);
            groupBox1.Controls.Add(BtnSearchTitle);
            groupBox1.Controls.Add(TextBoxSearchTuition);
            groupBox1.Controls.Add(TextBoxSearchLevelCount);
            groupBox1.Controls.Add(TextBoxSearchTitle);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 42);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 38;
            label3.Text = "شهریه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(848, 41);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 36;
            label4.Text = "نام درس";
            // 
            // ButtonPrintSearch
            // 
            ButtonPrintSearch.Image = Properties.Resources.PrintImge;
            ButtonPrintSearch.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintSearch.Location = new Point(33, 26);
            ButtonPrintSearch.Name = "ButtonPrintSearch";
            ButtonPrintSearch.Size = new Size(91, 47);
            ButtonPrintSearch.TabIndex = 35;
            ButtonPrintSearch.Text = "پرنیت";
            ButtonPrintSearch.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(593, 41);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 37;
            label2.Text = "تعداد سطح";
            // 
            // BtnSearchTuition
            // 
            BtnSearchTuition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchTuition.Image = Properties.Resources.search_1_;
            BtnSearchTuition.Location = new Point(194, 36);
            BtnSearchTuition.Name = "BtnSearchTuition";
            BtnSearchTuition.Size = new Size(33, 29);
            BtnSearchTuition.TabIndex = 34;
            BtnSearchTuition.UseVisualStyleBackColor = true;
            BtnSearchTuition.Click += BtnSearchTuition_Click;
            // 
            // BtnSearchLevelCount
            // 
            BtnSearchLevelCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchLevelCount.Image = Properties.Resources.search_1_;
            BtnSearchLevelCount.Location = new Point(428, 36);
            BtnSearchLevelCount.Name = "BtnSearchLevelCount";
            BtnSearchLevelCount.Size = new Size(33, 29);
            BtnSearchLevelCount.TabIndex = 31;
            BtnSearchLevelCount.UseVisualStyleBackColor = true;
            BtnSearchLevelCount.Click += BtnSearchLevelCount_Click;
            // 
            // BtnSearchTitle
            // 
            BtnSearchTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchTitle.Image = Properties.Resources.search_1_;
            BtnSearchTitle.Location = new Point(683, 37);
            BtnSearchTitle.Name = "BtnSearchTitle";
            BtnSearchTitle.Size = new Size(33, 29);
            BtnSearchTitle.TabIndex = 28;
            BtnSearchTitle.UseVisualStyleBackColor = true;
            BtnSearchTitle.Click += BtnSearchTitle_Click;
            // 
            // TextBoxSearchTuition
            // 
            TextBoxSearchTuition.IsNumber = false;
            TextBoxSearchTuition.IsReal = false;
            TextBoxSearchTuition.Location = new Point(233, 39);
            TextBoxSearchTuition.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchTuition.Name = "TextBoxSearchTuition";
            TextBoxSearchTuition.Size = new Size(123, 23);
            TextBoxSearchTuition.TabIndex = 33;
            // 
            // TextBoxSearchLevelCount
            // 
            TextBoxSearchLevelCount.IsNumber = false;
            TextBoxSearchLevelCount.IsReal = false;
            TextBoxSearchLevelCount.Location = new Point(464, 39);
            TextBoxSearchLevelCount.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchLevelCount.Name = "TextBoxSearchLevelCount";
            TextBoxSearchLevelCount.Size = new Size(123, 23);
            TextBoxSearchLevelCount.TabIndex = 30;
            // 
            // TextBoxSearchTitle
            // 
            TextBoxSearchTitle.IsNumber = false;
            TextBoxSearchTitle.IsReal = false;
            TextBoxSearchTitle.Location = new Point(719, 39);
            TextBoxSearchTitle.Margin = new Padding(3, 6, 3, 6);
            TextBoxSearchTitle.Name = "TextBoxSearchTitle";
            TextBoxSearchTitle.Size = new Size(123, 23);
            TextBoxSearchTitle.TabIndex = 27;
            // 
            // DataGridViewSearchCourse
            // 
            DataGridViewSearchCourse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DataGridViewSearchCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewSearchCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewSearchCourse.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewSearchCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSearchCourse.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DataGridViewSearchCourse.Dock = DockStyle.Fill;
            DataGridViewSearchCourse.Location = new Point(0, 163);
            DataGridViewSearchCourse.Name = "DataGridViewSearchCourse";
            DataGridViewSearchCourse.ReadOnly = true;
            DataGridViewSearchCourse.Size = new Size(914, 347);
            DataGridViewSearchCourse.TabIndex = 4;
            DataGridViewSearchCourse.CellDoubleClick += DataGridViewSearchCourse_CellDoubleClick;
            DataGridViewSearchCourse.CellFormatting += DataGridViewSearchCourse_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // SearchCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(DataGridViewSearchCourse);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "SearchCourseForm";
            Load += SearchCourseForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(DataGridViewSearchCourse, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSearchCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnSearchTuition;
        private Button BtnSearchLevelCount;
        private Button BtnSearchTitle;
        private Label label9;
        private BaseControl.MyTextBox TextBoxSearchTuition;
        private Label label10;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchLevelCount;
        private BaseControl.MyTextBox TextBoxSearchTitle;
        private Button ButtonPrintSearch;
        private Label label3;
        private Label label4;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        public DataGridView DataGridViewSearchCourse;
    }
}