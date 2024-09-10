namespace Wfa_UserAccount.Forms
{
    partial class FrmMain
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
            panel2 = new Panel();
            panel3 = new Panel();
            BtnLoginTest = new Button();
            BtnUsers = new Button();
            BtnPermission = new Button();
            BtnSecurityQuestions = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1403, 117);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(BtnLoginTest);
            panel3.Controls.Add(BtnUsers);
            panel3.Controls.Add(BtnPermission);
            panel3.Controls.Add(BtnSecurityQuestions);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1403, 117);
            panel3.TabIndex = 10;
            // 
            // BtnLoginTest
            // 
            BtnLoginTest.FlatStyle = FlatStyle.Flat;
            BtnLoginTest.Image = Properties.Resources.login;
            BtnLoginTest.ImageAlign = ContentAlignment.MiddleRight;
            BtnLoginTest.Location = new Point(696, 10);
            BtnLoginTest.Margin = new Padding(4);
            BtnLoginTest.Name = "BtnLoginTest";
            BtnLoginTest.Size = new Size(193, 98);
            BtnLoginTest.TabIndex = 3;
            BtnLoginTest.Text = "تست ورود";
            BtnLoginTest.TextAlign = ContentAlignment.MiddleLeft;
            BtnLoginTest.UseVisualStyleBackColor = true;
            BtnLoginTest.Click += BtnloginTest_Click;
            // 
            // BtnUsers
            // 
            BtnUsers.FlatStyle = FlatStyle.Flat;
            BtnUsers.Image = Properties.Resources.user_group;
            BtnUsers.ImageAlign = ContentAlignment.MiddleRight;
            BtnUsers.Location = new Point(476, 9);
            BtnUsers.Margin = new Padding(4);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Size = new Size(212, 98);
            BtnUsers.TabIndex = 2;
            BtnUsers.Text = "کاربران";
            BtnUsers.TextAlign = ContentAlignment.MiddleLeft;
            BtnUsers.UseVisualStyleBackColor = true;
            BtnUsers.Click += BtnUsers_Click;
            // 
            // BtnPermission
            // 
            BtnPermission.FlatStyle = FlatStyle.Flat;
            BtnPermission.Image = Properties.Resources._lock;
            BtnPermission.ImageAlign = ContentAlignment.MiddleRight;
            BtnPermission.Location = new Point(264, 9);
            BtnPermission.Margin = new Padding(4);
            BtnPermission.Name = "BtnPermission";
            BtnPermission.Size = new Size(204, 98);
            BtnPermission.TabIndex = 1;
            BtnPermission.Text = "سطح دسترسی";
            BtnPermission.TextAlign = ContentAlignment.MiddleLeft;
            BtnPermission.UseVisualStyleBackColor = true;
            BtnPermission.Click += BtnPermission_Click;
            // 
            // BtnSecurityQuestions
            // 
            BtnSecurityQuestions.FlatStyle = FlatStyle.Flat;
            BtnSecurityQuestions.Image = Properties.Resources.question1;
            BtnSecurityQuestions.ImageAlign = ContentAlignment.MiddleRight;
            BtnSecurityQuestions.Location = new Point(31, 10);
            BtnSecurityQuestions.Margin = new Padding(4);
            BtnSecurityQuestions.Name = "BtnSecurityQuestions";
            BtnSecurityQuestions.Size = new Size(225, 98);
            BtnSecurityQuestions.TabIndex = 0;
            BtnSecurityQuestions.Text = "سوالات امنیتی";
            BtnSecurityQuestions.TextAlign = ContentAlignment.MiddleLeft;
            BtnSecurityQuestions.UseVisualStyleBackColor = true;
            BtnSecurityQuestions.Click += BtnSecurityQuestions_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 180);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1403, 4);
            panel4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.mobile_security_laptop_fingerprint;
            pictureBox1.Location = new Point(0, 184);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1403, 565);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 749);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Margin = new Padding(4, 7, 4, 7);
            Name = "FrmMain";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSecurityQuestions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnPermission;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLoginTest;
    }
}