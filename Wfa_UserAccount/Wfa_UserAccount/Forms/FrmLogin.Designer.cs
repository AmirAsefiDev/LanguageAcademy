namespace Wfa_UserAccount.Forms
{
    partial class FrmLogin
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
            panel1 = new Panel();
            BtnLogin = new Button();
            BtnExit = new Button();
            myTextBoxUserName = new BaseControl.MyTextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelForgetPassword = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            errorProviderLogin = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(BtnExit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 317);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 86);
            panel1.TabIndex = 1;
            // 
            // BtnLogin
            // 
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(273, 12);
            BtnLogin.Margin = new Padding(4, 5, 4, 5);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(100, 63);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "ورود";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnExit
            // 
            BtnExit.DialogResult = DialogResult.Cancel;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(97, 12);
            BtnExit.Margin = new Padding(4, 5, 4, 5);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(100, 63);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "خروج";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // myTextBoxUserName
            // 
            myTextBoxUserName.AutoSize = true;
            myTextBoxUserName.IsNumber = false;
            myTextBoxUserName.IsReal = false;
            myTextBoxUserName.Location = new Point(137, 157);
            myTextBoxUserName.Margin = new Padding(4, 6, 4, 6);
            myTextBoxUserName.Name = "myTextBoxUserName";
            myTextBoxUserName.Size = new Size(154, 27);
            myTextBoxUserName.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(137, 202);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.RightToLeft = RightToLeft.Yes;
            textBoxPassword.Size = new Size(204, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 166);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 6;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 7;
            label2.Text = "رمز عبور";
            // 
            // labelForgetPassword
            // 
            labelForgetPassword.AutoSize = true;
            labelForgetPassword.BackColor = Color.White;
            labelForgetPassword.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForgetPassword.ForeColor = Color.Blue;
            labelForgetPassword.Location = new Point(133, 258);
            labelForgetPassword.Margin = new Padding(4, 0, 4, 0);
            labelForgetPassword.Name = "labelForgetPassword";
            labelForgetPassword.Size = new Size(203, 21);
            labelForgetPassword.TabIndex = 8;
            labelForgetPassword.Text = "رمز عبور  را فراموش کرده ام";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.stock_lock;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 403);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.ContainerControl = this;
            errorProviderLogin.RightToLeft = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(460, 403);
            ControlBox = false;
            Controls.Add(labelForgetPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(myTextBoxUserName);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BaseControl.MyTextBox myTextBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelForgetPassword;
        private ErrorProvider errorProviderLogin;
    }
}