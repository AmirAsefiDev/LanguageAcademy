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
            groupBox1.Location = new Point(0, 78);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1028, 124);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 52);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 38;
            label3.Text = "شهریه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(954, 51);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 36;
            label4.Text = "نام درس";
            // 
            // ButtonPrintSearch
            // 
            ButtonPrintSearch.Image = Properties.Resources.PrintImge;
            ButtonPrintSearch.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintSearch.Location = new Point(37, 32);
            ButtonPrintSearch.Margin = new Padding(3, 4, 3, 4);
            ButtonPrintSearch.Name = "ButtonPrintSearch";
            ButtonPrintSearch.Size = new Size(102, 58);
            ButtonPrintSearch.TabIndex = 35;
            ButtonPrintSearch.Text = "پرنیت";
            ButtonPrintSearch.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintSearch.UseVisualStyleBackColor = true;
            ButtonPrintSearch.Click += ButtonPrintSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 51);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 37;
            label2.Text = "تعداد سطح";
            // 
            // BtnSearchTuition
            // 
            BtnSearchTuition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchTuition.Image = Properties.Resources.search_1_;
            BtnSearchTuition.Location = new Point(218, 44);
            BtnSearchTuition.Margin = new Padding(3, 4, 3, 4);
            BtnSearchTuition.Name = "BtnSearchTuition";
            BtnSearchTuition.Size = new Size(37, 36);
            BtnSearchTuition.TabIndex = 34;
            BtnSearchTuition.UseVisualStyleBackColor = true;
            BtnSearchTuition.Click += BtnSearchTuition_Click;
            // 
            // BtnSearchLevelCount
            // 
            BtnSearchLevelCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchLevelCount.Image = Properties.Resources.search_1_;
            BtnSearchLevelCount.Location = new Point(482, 44);
            BtnSearchLevelCount.Margin = new Padding(3, 4, 3, 4);
            BtnSearchLevelCount.Name = "BtnSearchLevelCount";
            BtnSearchLevelCount.Size = new Size(37, 36);
            BtnSearchLevelCount.TabIndex = 31;
            BtnSearchLevelCount.UseVisualStyleBackColor = true;
            BtnSearchLevelCount.Click += BtnSearchLevelCount_Click;
            // 
            // BtnSearchTitle
            // 
            BtnSearchTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSearchTitle.Image = Properties.Resources.search_1_;
            BtnSearchTitle.Location = new Point(768, 46);
            BtnSearchTitle.Margin = new Padding(3, 4, 3, 4);
            BtnSearchTitle.Name = "BtnSearchTitle";
            BtnSearchTitle.Size = new Size(37, 36);
            BtnSearchTitle.TabIndex = 28;
            BtnSearchTitle.UseVisualStyleBackColor = true;
            BtnSearchTitle.Click += BtnSearchTitle_Click;
            // 
            // TextBoxSearchTuition
            // 
            TextBoxSearchTuition.IsNumber = false;
            TextBoxSearchTuition.IsReal = false;
            TextBoxSearchTuition.Location = new Point(262, 48);
            TextBoxSearchTuition.Margin = new Padding(3, 6, 3, 6);
            TextBoxSearchTuition.Name = "TextBoxSearchTuition";
            TextBoxSearchTuition.Size = new Size(123, 29);
            TextBoxSearchTuition.TabIndex = 33;
            // 
            // TextBoxSearchLevelCount
            // 
            TextBoxSearchLevelCount.IsNumber = false;
            TextBoxSearchLevelCount.IsReal = false;
            TextBoxSearchLevelCount.Location = new Point(522, 48);
            TextBoxSearchLevelCount.Margin = new Padding(3, 6, 3, 6);
            TextBoxSearchLevelCount.Name = "TextBoxSearchLevelCount";
            TextBoxSearchLevelCount.Size = new Size(123, 29);
            TextBoxSearchLevelCount.TabIndex = 30;
            // 
            // TextBoxSearchTitle
            // 
            TextBoxSearchTitle.IsNumber = false;
            TextBoxSearchTitle.IsReal = false;
            TextBoxSearchTitle.Location = new Point(809, 48);
            TextBoxSearchTitle.Margin = new Padding(3, 7, 3, 7);
            TextBoxSearchTitle.Name = "TextBoxSearchTitle";
            TextBoxSearchTitle.Size = new Size(123, 29);
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
            DataGridViewSearchCourse.Location = new Point(0, 202);
            DataGridViewSearchCourse.Margin = new Padding(3, 4, 3, 4);
            DataGridViewSearchCourse.Name = "DataGridViewSearchCourse";
            DataGridViewSearchCourse.ReadOnly = true;
            DataGridViewSearchCourse.RowHeadersWidth = 51;
            DataGridViewSearchCourse.Size = new Size(1028, 428);
            DataGridViewSearchCourse.TabIndex = 4;
            DataGridViewSearchCourse.CellDoubleClick += DataGridViewSearchCourse_CellDoubleClick;
            DataGridViewSearchCourse.CellFormatting += DataGridViewSearchCourse_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // SearchCourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 630);
            Controls.Add(DataGridViewSearchCourse);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 6, 6, 6);
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