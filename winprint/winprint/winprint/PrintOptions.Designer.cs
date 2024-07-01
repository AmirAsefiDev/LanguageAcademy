namespace winprint
{
    partial class PrintOptions
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.gboxRowsToPrint = new System.Windows.Forms.GroupBox();
            this.rdoSelectedRows = new System.Windows.Forms.RadioButton();
            this.rdoAllRows = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r_landscape = new System.Windows.Forms.RadioButton();
            this.r_portrait = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblColumnsToPrint = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_landscape = new System.Windows.Forms.PictureBox();
            this.pic_portrait = new System.Windows.Forms.PictureBox();
            this.chkFitToPageWidth = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxRowsToPrint.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_landscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_portrait)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(24, 53);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(513, 80);
            this.txtTitle.TabIndex = 36;
            // 
            // gboxRowsToPrint
            // 
            this.gboxRowsToPrint.BackColor = System.Drawing.Color.Transparent;
            this.gboxRowsToPrint.Controls.Add(this.rdoSelectedRows);
            this.gboxRowsToPrint.Controls.Add(this.rdoAllRows);
            this.gboxRowsToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRowsToPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gboxRowsToPrint.Location = new System.Drawing.Point(107, 369);
            this.gboxRowsToPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxRowsToPrint.Name = "gboxRowsToPrint";
            this.gboxRowsToPrint.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxRowsToPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gboxRowsToPrint.Size = new System.Drawing.Size(163, 118);
            this.gboxRowsToPrint.TabIndex = 34;
            this.gboxRowsToPrint.TabStop = false;
            this.gboxRowsToPrint.Text = "چاپ کن رکورد های";
            // 
            // rdoSelectedRows
            // 
            this.rdoSelectedRows.AutoSize = true;
            this.rdoSelectedRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSelectedRows.Location = new System.Drawing.Point(52, 79);
            this.rdoSelectedRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoSelectedRows.Name = "rdoSelectedRows";
            this.rdoSelectedRows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoSelectedRows.Size = new System.Drawing.Size(105, 17);
            this.rdoSelectedRows.TabIndex = 1;
            this.rdoSelectedRows.TabStop = true;
            this.rdoSelectedRows.Text = "انتخاب شده ها";
            this.rdoSelectedRows.UseVisualStyleBackColor = true;
            this.rdoSelectedRows.CheckedChanged += new System.EventHandler(this.rdoSelectedRows_CheckedChanged);
            // 
            // rdoAllRows
            // 
            this.rdoAllRows.AutoSize = true;
            this.rdoAllRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllRows.Location = new System.Drawing.Point(52, 44);
            this.rdoAllRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoAllRows.Name = "rdoAllRows";
            this.rdoAllRows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoAllRows.Size = new System.Drawing.Size(45, 17);
            this.rdoAllRows.TabIndex = 0;
            this.rdoAllRows.TabStop = true;
            this.rdoAllRows.Text = "همه";
            this.rdoAllRows.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.gboxRowsToPrint);
            this.panel1.Controls.Add(this.chklst);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblColumnsToPrint);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chkFitToPageWidth);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 586);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::winprint.Properties.Resources.con_21;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(295, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 39;
            this.button3.Text = "انصراف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::winprint.Properties.Resources.HP_Printer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(623, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 45);
            this.button2.TabIndex = 38;
            this.button2.Text = "چاپ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::winprint.Properties.Resources.updateok;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(436, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 45);
            this.button1.TabIndex = 37;
            this.button1.Text = "تنظیمات بیشتر";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chklst
            // 
            this.chklst.CheckOnClick = true;
            this.chklst.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(558, 52);
            this.chklst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chklst.Name = "chklst";
            this.chklst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklst.Size = new System.Drawing.Size(221, 378);
            this.chklst.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(302, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "چاپ به صورت تمام عرض";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.r_landscape);
            this.groupBox2.Controls.Add(this.r_portrait);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(335, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(146, 220);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نحوه چاپ";
            // 
            // r_landscape
            // 
            this.r_landscape.AutoSize = true;
            this.r_landscape.BackColor = System.Drawing.Color.Transparent;
            this.r_landscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.r_landscape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.r_landscape.Location = new System.Drawing.Point(38, 102);
            this.r_landscape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r_landscape.Name = "r_landscape";
            this.r_landscape.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.r_landscape.Size = new System.Drawing.Size(78, 28);
            this.r_landscape.TabIndex = 1;
            this.r_landscape.TabStop = true;
            this.r_landscape.Text = "عرضی";
            this.r_landscape.UseVisualStyleBackColor = false;
            this.r_landscape.CheckedChanged += new System.EventHandler(this.r_landscape_CheckedChanged);
            // 
            // r_portrait
            // 
            this.r_portrait.AutoSize = true;
            this.r_portrait.BackColor = System.Drawing.Color.Transparent;
            this.r_portrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.r_portrait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.r_portrait.Location = new System.Drawing.Point(50, 60);
            this.r_portrait.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.r_portrait.Name = "r_portrait";
            this.r_portrait.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.r_portrait.Size = new System.Drawing.Size(66, 28);
            this.r_portrait.TabIndex = 0;
            this.r_portrait.TabStop = true;
            this.r_portrait.Text = "طولی";
            this.r_portrait.UseVisualStyleBackColor = false;
            this.r_portrait.CheckedChanged += new System.EventHandler(this.r_portrait_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(415, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 24);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = ":  عنوان گزارش ";
            // 
            // lblColumnsToPrint
            // 
            this.lblColumnsToPrint.AutoSize = true;
            this.lblColumnsToPrint.BackColor = System.Drawing.Color.Transparent;
            this.lblColumnsToPrint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColumnsToPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblColumnsToPrint.Location = new System.Drawing.Point(586, 25);
            this.lblColumnsToPrint.Name = "lblColumnsToPrint";
            this.lblColumnsToPrint.Size = new System.Drawing.Size(181, 23);
            this.lblColumnsToPrint.TabIndex = 17;
            this.lblColumnsToPrint.Text = "ستون های انتخابی";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pic_landscape);
            this.groupBox1.Controls.Add(this.pic_portrait);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(107, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(222, 220);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پیش نمایش";
            // 
            // pic_landscape
            // 
            this.pic_landscape.BackColor = System.Drawing.Color.DarkRed;
            this.pic_landscape.Image = global::winprint.Properties.Resources._0154;
            this.pic_landscape.Location = new System.Drawing.Point(45, 60);
            this.pic_landscape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_landscape.Name = "pic_landscape";
            this.pic_landscape.Size = new System.Drawing.Size(131, 99);
            this.pic_landscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_landscape.TabIndex = 1;
            this.pic_landscape.TabStop = false;
            this.pic_landscape.Visible = false;
            // 
            // pic_portrait
            // 
            this.pic_portrait.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_portrait.Image = global::winprint.Properties.Resources._0120;
            this.pic_portrait.Location = new System.Drawing.Point(46, 30);
            this.pic_portrait.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_portrait.Name = "pic_portrait";
            this.pic_portrait.Size = new System.Drawing.Size(130, 132);
            this.pic_portrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_portrait.TabIndex = 0;
            this.pic_portrait.TabStop = false;
            // 
            // chkFitToPageWidth
            // 
            this.chkFitToPageWidth.AutoSize = true;
            this.chkFitToPageWidth.BackColor = System.Drawing.Color.Transparent;
            this.chkFitToPageWidth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFitToPageWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFitToPageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkFitToPageWidth.Location = new System.Drawing.Point(250, 369);
            this.chkFitToPageWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFitToPageWidth.Name = "chkFitToPageWidth";
            this.chkFitToPageWidth.Size = new System.Drawing.Size(46, 29);
            this.chkFitToPageWidth.TabIndex = 2;
            this.chkFitToPageWidth.Text = "0";
            this.chkFitToPageWidth.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 40);
            this.panel2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(351, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "پنجره تنظیمات چاپ";
            // 
            // PrintOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(805, 588);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrintOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PrintOptions_Load);
            this.gboxRowsToPrint.ResumeLayout(false);
            this.gboxRowsToPrint.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_landscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_portrait)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.GroupBox gboxRowsToPrint;
        internal System.Windows.Forms.RadioButton rdoSelectedRows;
        internal System.Windows.Forms.RadioButton rdoAllRows;
        private System.Windows.Forms.PictureBox pic_landscape;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.CheckedListBox chklst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton r_landscape;
        private System.Windows.Forms.RadioButton r_portrait;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblColumnsToPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_portrait;
        internal System.Windows.Forms.CheckBox chkFitToPageWidth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}