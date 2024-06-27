﻿namespace Wfa_ZabanSara.Forms
{
    partial class CourseForm
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
            ButtonSearchTitle = new Button();
            TextBoxSearchTitle = new BaseControl.MyTextBox();
            label1 = new Label();
            panel2 = new Panel();
            ButtonDeleteCourse = new Button();
            ButtonPrintCourse = new Button();
            TextBoxTitle = new BaseControl.MyTextBox();
            label4 = new Label();
            ButtonNewCource = new Button();
            ButtonEditCourse = new Button();
            label3 = new Label();
            TextBoxTuition = new BaseControl.MyTextBox();
            label2 = new Label();
            TextBoxLevelCount = new BaseControl.MyTextBox();
            DataGridViewCourse = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderCourse = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCourse).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonSearchMore);
            groupBox1.Controls.Add(ButtonSearchTitle);
            groupBox1.Controls.Add(TextBoxSearchTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 356);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 94);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // ButtonSearchMore
            // 
            ButtonSearchMore.Location = new Point(129, 27);
            ButtonSearchMore.Name = "ButtonSearchMore";
            ButtonSearchMore.Size = new Size(124, 39);
            ButtonSearchMore.TabIndex = 3;
            ButtonSearchMore.Text = "جستجوی بیشتر";
            ButtonSearchMore.UseVisualStyleBackColor = true;
            ButtonSearchMore.Click += ButtonSearchMore_Click;
            // 
            // ButtonSearchTitle
            // 
            ButtonSearchTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ButtonSearchTitle.Image = Properties.Resources.search_1_;
            ButtonSearchTitle.Location = new Point(415, 33);
            ButtonSearchTitle.Name = "ButtonSearchTitle";
            ButtonSearchTitle.Size = new Size(33, 29);
            ButtonSearchTitle.TabIndex = 2;
            ButtonSearchTitle.UseVisualStyleBackColor = true;
            ButtonSearchTitle.Click += ButtonSearchTitle_Click;
            // 
            // TextBoxSearchTitle
            // 
            TextBoxSearchTitle.IsNumber = false;
            TextBoxSearchTitle.IsReal = false;
            TextBoxSearchTitle.Location = new Point(454, 35);
            TextBoxSearchTitle.Name = "TextBoxSearchTitle";
            TextBoxSearchTitle.Size = new Size(173, 23);
            TextBoxSearchTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(633, 38);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 0;
            label1.Text = "نام درس";
            // 
            // panel2
            // 
            panel2.Controls.Add(ButtonDeleteCourse);
            panel2.Controls.Add(ButtonPrintCourse);
            panel2.Controls.Add(TextBoxTitle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ButtonNewCource);
            panel2.Controls.Add(ButtonEditCourse);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TextBoxTuition);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TextBoxLevelCount);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(541, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 293);
            panel2.TabIndex = 1;
            // 
            // ButtonDeleteCourse
            // 
            ButtonDeleteCourse.Image = Properties.Resources.DeleteImage;
            ButtonDeleteCourse.ImageAlign = ContentAlignment.MiddleRight;
            ButtonDeleteCourse.Location = new Point(139, 221);
            ButtonDeleteCourse.Name = "ButtonDeleteCourse";
            ButtonDeleteCourse.Size = new Size(91, 53);
            ButtonDeleteCourse.TabIndex = 8;
            ButtonDeleteCourse.Text = "حذف";
            ButtonDeleteCourse.TextAlign = ContentAlignment.MiddleLeft;
            ButtonDeleteCourse.UseVisualStyleBackColor = true;
            ButtonDeleteCourse.Click += ButtonDeleteCourse_Click;
            // 
            // ButtonPrintCourse
            // 
            ButtonPrintCourse.Image = Properties.Resources.PrintImge;
            ButtonPrintCourse.ImageAlign = ContentAlignment.MiddleRight;
            ButtonPrintCourse.Location = new Point(42, 221);
            ButtonPrintCourse.Name = "ButtonPrintCourse";
            ButtonPrintCourse.Size = new Size(91, 53);
            ButtonPrintCourse.TabIndex = 9;
            ButtonPrintCourse.Text = "پرنیت";
            ButtonPrintCourse.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPrintCourse.UseVisualStyleBackColor = true;
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.IsNumber = false;
            TextBoxTitle.IsReal = false;
            TextBoxTitle.Location = new Point(22, 20);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(173, 23);
            TextBoxTitle.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 20);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 0;
            label4.Text = "نام درس";
            // 
            // ButtonNewCource
            // 
            ButtonNewCource.Image = Properties.Resources.InsertImage;
            ButtonNewCource.ImageAlign = ContentAlignment.MiddleRight;
            ButtonNewCource.Location = new Point(139, 162);
            ButtonNewCource.Name = "ButtonNewCource";
            ButtonNewCource.Size = new Size(91, 53);
            ButtonNewCource.TabIndex = 6;
            ButtonNewCource.Text = "جدید";
            ButtonNewCource.TextAlign = ContentAlignment.MiddleLeft;
            ButtonNewCource.UseVisualStyleBackColor = true;
            ButtonNewCource.Click += ButtonNewCource_Click;
            // 
            // ButtonEditCourse
            // 
            ButtonEditCourse.Image = Properties.Resources.UpdateImage;
            ButtonEditCourse.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEditCourse.Location = new Point(42, 162);
            ButtonEditCourse.Name = "ButtonEditCourse";
            ButtonEditCourse.Size = new Size(91, 53);
            ButtonEditCourse.TabIndex = 7;
            ButtonEditCourse.Text = "ویرایش";
            ButtonEditCourse.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEditCourse.UseVisualStyleBackColor = true;
            ButtonEditCourse.Click += ButtonEditCourse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 119);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 4;
            label3.Text = "شهریه";
            // 
            // TextBoxTuition
            // 
            TextBoxTuition.IsNumber = true;
            TextBoxTuition.IsReal = false;
            TextBoxTuition.Location = new Point(22, 117);
            TextBoxTuition.Name = "TextBoxTuition";
            TextBoxTuition.Size = new Size(173, 23);
            TextBoxTuition.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 70);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 2;
            label2.Text = "تعداد سطح";
            // 
            // TextBoxLevelCount
            // 
            TextBoxLevelCount.IsNumber = true;
            TextBoxLevelCount.IsReal = false;
            TextBoxLevelCount.Location = new Point(22, 68);
            TextBoxLevelCount.Name = "TextBoxLevelCount";
            TextBoxLevelCount.Size = new Size(173, 23);
            TextBoxLevelCount.TabIndex = 3;
            // 
            // DataGridViewCourse
            // 
            DataGridViewCourse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DataGridViewCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCourse.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCourse.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DataGridViewCourse.Dock = DockStyle.Fill;
            DataGridViewCourse.Location = new Point(0, 63);
            DataGridViewCourse.Name = "DataGridViewCourse";
            DataGridViewCourse.ReadOnly = true;
            DataGridViewCourse.Size = new Size(541, 293);
            DataGridViewCourse.TabIndex = 3;
            DataGridViewCourse.CellClick += DataGridViewCourse_CellClick;
            DataGridViewCourse.CellFormatting += DataGridViewCourse_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderCourse
            // 
            errorProviderCourse.ContainerControl = this;
            errorProviderCourse.RightToLeft = true;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(DataGridViewCourse);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Name = "CourseForm";
            Load += CourseForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DataGridViewCourse, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridView DataGridViewCourse;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private Label label3;
        private BaseControl.MyTextBox TextBoxTuition;
        private Label label2;
        private BaseControl.MyTextBox TextBoxLevelCount;
        private Label label1;
        private BaseControl.MyTextBox TextBoxSearchTitle;
        private Button ButtonDeleteCourse;
        private Button ButtonPrintCourse;
        private Button ButtonNewCource;
        private Button ButtonEditCourse;
        private Button ButtonSearchTitle;
        private Button ButtonSearchMore;
        private BaseControl.MyTextBox TextBoxTitle;
        private Label label4;
        private ErrorProvider errorProviderCourse;
    }
}