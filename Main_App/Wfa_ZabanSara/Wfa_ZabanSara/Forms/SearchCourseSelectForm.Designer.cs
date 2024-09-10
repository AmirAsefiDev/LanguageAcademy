namespace Wfa_ZabanSara.Forms
{
    partial class SearchCourseSelectForm
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
            ButtonPrintCourseSelect = new Button();
            label5 = new Label();
            label4 = new Label();
            ButtonSearchCourseGroupYear = new Button();
            ButtonSearchCourseGroup = new Button();
            ButtonSearchStudent = new Button();
            TextBoxSearchCourseGroupYear = new BaseControl.MyTextBox();
            label11 = new Label();
            TextBoxSearchCourseGroup = new BaseControl.MyTextBox();
            TextBoxSearchStudent = new BaseControl.MyTextBox();
            DgvCourseSelect = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseSelect).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(ButtonPrintCourseSelect);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ButtonSearchCourseGroupYear);
            panel2.Controls.Add(ButtonSearchCourseGroup);
            panel2.Controls.Add(ButtonSearchStudent);
            panel2.Controls.Add(TextBoxSearchCourseGroupYear);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(TextBoxSearchCourseGroup);
            panel2.Controls.Add(TextBoxSearchStudent);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 78);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 124);
            panel2.TabIndex = 2;
            // 
            // ButtonPrintCourseSelect
            // 
            ButtonPrintCourseSelect.Image = Properties.Resources.PrintImge;
            ButtonPrintCourseSelect.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintCourseSelect.Location = new Point(36, 26);
            ButtonPrintCourseSelect.Margin = new Padding(3, 4, 3, 4);
            ButtonPrintCourseSelect.Name = "ButtonPrintCourseSelect";
            ButtonPrintCourseSelect.Size = new Size(97, 65);
            ButtonPrintCourseSelect.TabIndex = 21;
            ButtonPrintCourseSelect.Text = "پرنیت";
            ButtonPrintCourseSelect.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintCourseSelect.UseVisualStyleBackColor = true;
            ButtonPrintCourseSelect.Click += ButtonPrintCourseSelect_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1059, 49);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 20;
            label5.Text = "دانشجو";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(713, 48);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 19;
            label4.Text = "گروه درسی";
            // 
            // ButtonSearchCourseGroupYear
            // 
            ButtonSearchCourseGroupYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseGroupYear.Image = Properties.Resources.search_1_;
            ButtonSearchCourseGroupYear.Location = new Point(210, 44);
            ButtonSearchCourseGroupYear.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchCourseGroupYear.Name = "ButtonSearchCourseGroupYear";
            ButtonSearchCourseGroupYear.Size = new Size(37, 36);
            ButtonSearchCourseGroupYear.TabIndex = 18;
            ButtonSearchCourseGroupYear.UseVisualStyleBackColor = true;
            ButtonSearchCourseGroupYear.Click += ButtonSearchCourseGroupYear_Click;
            // 
            // ButtonSearchCourseGroup
            // 
            ButtonSearchCourseGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchCourseGroup.Image = Properties.Resources.search_1_;
            ButtonSearchCourseGroup.Location = new Point(465, 42);
            ButtonSearchCourseGroup.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchCourseGroup.Name = "ButtonSearchCourseGroup";
            ButtonSearchCourseGroup.Size = new Size(37, 36);
            ButtonSearchCourseGroup.TabIndex = 15;
            ButtonSearchCourseGroup.UseVisualStyleBackColor = true;
            ButtonSearchCourseGroup.Click += ButtonSearchCourseGroup_Click;
            // 
            // ButtonSearchStudent
            // 
            ButtonSearchStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchStudent.Image = Properties.Resources.search_1_;
            ButtonSearchStudent.Location = new Point(843, 43);
            ButtonSearchStudent.Margin = new Padding(3, 4, 3, 4);
            ButtonSearchStudent.Name = "ButtonSearchStudent";
            ButtonSearchStudent.Size = new Size(37, 36);
            ButtonSearchStudent.TabIndex = 13;
            ButtonSearchStudent.UseVisualStyleBackColor = true;
            ButtonSearchStudent.Click += ButtonSearchStudent_Click;
            // 
            // TextBoxSearchCourseGroupYear
            // 
            TextBoxSearchCourseGroupYear.IsNumber = true;
            TextBoxSearchCourseGroupYear.IsReal = false;
            TextBoxSearchCourseGroupYear.Location = new Point(261, 47);
            TextBoxSearchCourseGroupYear.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchCourseGroupYear.Name = "TextBoxSearchCourseGroupYear";
            TextBoxSearchCourseGroupYear.Size = new Size(68, 29);
            TextBoxSearchCourseGroupYear.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(344, 51);
            label11.Name = "label11";
            label11.Size = new Size(39, 23);
            label11.TabIndex = 16;
            label11.Text = "سال";
            // 
            // TextBoxSearchCourseGroup
            // 
            TextBoxSearchCourseGroup.IsNumber = false;
            TextBoxSearchCourseGroup.IsReal = false;
            TextBoxSearchCourseGroup.Location = new Point(515, 44);
            TextBoxSearchCourseGroup.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchCourseGroup.Name = "TextBoxSearchCourseGroup";
            TextBoxSearchCourseGroup.Size = new Size(170, 29);
            TextBoxSearchCourseGroup.TabIndex = 14;
            // 
            // TextBoxSearchStudent
            // 
            TextBoxSearchStudent.IsNumber = true;
            TextBoxSearchStudent.IsReal = false;
            TextBoxSearchStudent.Location = new Point(893, 44);
            TextBoxSearchStudent.Margin = new Padding(3, 5, 3, 5);
            TextBoxSearchStudent.Name = "TextBoxSearchStudent";
            TextBoxSearchStudent.Size = new Size(141, 29);
            TextBoxSearchStudent.TabIndex = 12;
            // 
            // DgvCourseSelect
            // 
            DgvCourseSelect.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DgvCourseSelect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvCourseSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCourseSelect.BackgroundColor = SystemColors.ButtonHighlight;
            DgvCourseSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCourseSelect.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DgvCourseSelect.Dock = DockStyle.Fill;
            DgvCourseSelect.Location = new Point(0, 202);
            DgvCourseSelect.Margin = new Padding(3, 4, 3, 4);
            DgvCourseSelect.Name = "DgvCourseSelect";
            DgvCourseSelect.ReadOnly = true;
            DgvCourseSelect.RowHeadersWidth = 51;
            DgvCourseSelect.Size = new Size(1164, 428);
            DgvCourseSelect.TabIndex = 3;
            DgvCourseSelect.CellDoubleClick += DgvCourseSelect_CellDoubleClick;
            DgvCourseSelect.CellFormatting += DgvCourseSelect_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // SearchCourseSelectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 630);
            Controls.Add(DgvCourseSelect);
            Controls.Add(panel2);
            Margin = new Padding(6, 6, 6, 6);
            Name = "SearchCourseSelectForm";
            Load += SearchCourseSelectForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DgvCourseSelect, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseSelect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private Label label4;
        private Button ButtonSearchCourseGroupYear;
        private Button ButtonSearchCourseGroup;
        private Button ButtonSearchStudent;
        private BaseControl.MyTextBox TextBoxSearchCourseGroupYear;
        private Label label11;
        private BaseControl.MyTextBox TextBoxSearchCourseGroup;
        private BaseControl.MyTextBox TextBoxSearchStudent;
        private Button ButtonPrintCourseSelect;
        public DataGridView DgvCourseSelect;
        private DataGridViewTextBoxColumn ColumnRowNumber;
    }
}