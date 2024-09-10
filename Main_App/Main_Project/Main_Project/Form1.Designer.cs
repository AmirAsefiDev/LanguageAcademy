namespace Main_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ButtonStudentManage = new Button();
            ButtonFinancial = new Button();
            ButtonUsersManage = new Button();
            ButtonClose = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonStudentManage
            // 
            ButtonStudentManage.BackColor = Color.White;
            ButtonStudentManage.Image = Properties.Resources.Graduate_female_icon;
            ButtonStudentManage.Location = new Point(130, 137);
            ButtonStudentManage.Margin = new Padding(4, 3, 4, 3);
            ButtonStudentManage.Name = "ButtonStudentManage";
            ButtonStudentManage.Size = new Size(229, 196);
            ButtonStudentManage.TabIndex = 0;
            ButtonStudentManage.Text = "مدیریت دانشجویان";
            ButtonStudentManage.TextAlign = ContentAlignment.BottomCenter;
            ButtonStudentManage.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonStudentManage.UseVisualStyleBackColor = false;
            ButtonStudentManage.Click += ButtonStudentManage_Click;
            // 
            // ButtonFinancial
            // 
            ButtonFinancial.BackColor = Color.White;
            ButtonFinancial.Image = Properties.Resources.coins_icon;
            ButtonFinancial.Location = new Point(372, 137);
            ButtonFinancial.Margin = new Padding(4, 3, 4, 3);
            ButtonFinancial.Name = "ButtonFinancial";
            ButtonFinancial.Size = new Size(235, 196);
            ButtonFinancial.TabIndex = 1;
            ButtonFinancial.Text = "امور مالی";
            ButtonFinancial.TextAlign = ContentAlignment.BottomCenter;
            ButtonFinancial.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonFinancial.UseVisualStyleBackColor = false;
            ButtonFinancial.Click += ButtonFinancial_Click;
            // 
            // ButtonUsersManage
            // 
            ButtonUsersManage.BackColor = Color.White;
            ButtonUsersManage.Image = Properties.Resources.Admin_icon;
            ButtonUsersManage.Location = new Point(621, 137);
            ButtonUsersManage.Margin = new Padding(4, 3, 4, 3);
            ButtonUsersManage.Name = "ButtonUsersManage";
            ButtonUsersManage.Size = new Size(234, 196);
            ButtonUsersManage.TabIndex = 2;
            ButtonUsersManage.Text = "مدیریت کاربران";
            ButtonUsersManage.TextAlign = ContentAlignment.BottomCenter;
            ButtonUsersManage.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonUsersManage.UseVisualStyleBackColor = false;
            ButtonUsersManage.Click += ButtonUsersManage_Click;
            // 
            // ButtonClose
            // 
            ButtonClose.AutoSize = true;
            ButtonClose.BackColor = Color.White;
            ButtonClose.Image = Properties.Resources.BackImage;
            ButtonClose.Location = new Point(914, 425);
            ButtonClose.Margin = new Padding(4, 3, 4, 3);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(73, 64);
            ButtonClose.TabIndex = 3;
            ButtonClose.TextAlign = ContentAlignment.BottomCenter;
            ButtonClose.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 492);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(70, 20);
            toolStripStatusLabel2.Text = "نام کاربری";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(133, 20);
            toolStripStatusLabel3.Text = "                               ";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(151, 20);
            toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1000, 518);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(ButtonClose);
            Controls.Add(ButtonUsersManage);
            Controls.Add(ButtonFinancial);
            Controls.Add(ButtonStudentManage);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonStudentManage;
        private Button ButtonFinancial;
        private Button ButtonUsersManage;
        private Button ButtonClose;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
