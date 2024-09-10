namespace Wfa_UserAccount.Forms
{
    partial class FrmUsers
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
            panel2 = new Panel();
            textBoxPassword = new TextBox();
            label7 = new Label();
            myTextBoxUsername = new BaseControl.MyTextBox();
            label6 = new Label();
            myComboBoxID_FK_SecurityQuestion = new BaseControl.MyComboBox();
            label5 = new Label();
            myComboBoxID_FK_Permission = new BaseControl.MyComboBox();
            label4 = new Label();
            myTextBoxAnswer = new BaseControl.MyTextBox();
            label3 = new Label();
            label2 = new Label();
            myTextBoxLastName = new BaseControl.MyTextBox();
            label1 = new Label();
            myToolbarUsers = new BaseControl.MyToolbar();
            myTextBoxName = new BaseControl.MyTextBox();
            usersDataGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderUsers = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsers).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(myTextBoxUsername);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(myComboBoxID_FK_SecurityQuestion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(myComboBoxID_FK_Permission);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(myTextBoxAnswer);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(myTextBoxLastName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(myToolbarUsers);
            panel2.Controls.Add(myTextBoxName);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(903, 60);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 557);
            panel2.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(33, 207);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(301, 27);
            textBoxPassword.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 117);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 14;
            label7.Text = "نام کاربری";
            // 
            // myTextBoxUsername
            // 
            myTextBoxUsername.AutoSize = true;
            myTextBoxUsername.IsNumber = false;
            myTextBoxUsername.IsReal = false;
            myTextBoxUsername.Location = new Point(33, 116);
            myTextBoxUsername.Margin = new Padding(4, 8, 4, 8);
            myTextBoxUsername.Name = "myTextBoxUsername";
            myTextBoxUsername.Size = new Size(275, 27);
            myTextBoxUsername.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 162);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 12;
            label6.Text = "سطح دسترسی";
            // 
            // myComboBoxID_FK_SecurityQuestion
            // 
            myComboBoxID_FK_SecurityQuestion.AutoCompleteMode = AutoCompleteMode.None;
            myComboBoxID_FK_SecurityQuestion.AutoCompleteSource = AutoCompleteSource.None;
            myComboBoxID_FK_SecurityQuestion.AutoSize = true;
            myComboBoxID_FK_SecurityQuestion.DataSource = null;
            myComboBoxID_FK_SecurityQuestion.DisplayMember = "";
            myComboBoxID_FK_SecurityQuestion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myComboBoxID_FK_SecurityQuestion.Location = new Point(33, 251);
            myComboBoxID_FK_SecurityQuestion.Margin = new Padding(4, 6, 4, 6);
            myComboBoxID_FK_SecurityQuestion.Name = "myComboBoxID_FK_SecurityQuestion";
            myComboBoxID_FK_SecurityQuestion.SelectedIndex = -1;
            myComboBoxID_FK_SecurityQuestion.SelectedValue = null;
            myComboBoxID_FK_SecurityQuestion.Size = new Size(275, 31);
            myComboBoxID_FK_SecurityQuestion.TabIndex = 11;
            myComboBoxID_FK_SecurityQuestion.ValueMember = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 252);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "سوال امنیتی";
            // 
            // myComboBoxID_FK_Permission
            // 
            myComboBoxID_FK_Permission.AutoCompleteMode = AutoCompleteMode.None;
            myComboBoxID_FK_Permission.AutoCompleteSource = AutoCompleteSource.None;
            myComboBoxID_FK_Permission.AutoSize = true;
            myComboBoxID_FK_Permission.DataSource = null;
            myComboBoxID_FK_Permission.DisplayMember = "";
            myComboBoxID_FK_Permission.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myComboBoxID_FK_Permission.Location = new Point(33, 159);
            myComboBoxID_FK_Permission.Margin = new Padding(4, 5, 4, 5);
            myComboBoxID_FK_Permission.Name = "myComboBoxID_FK_Permission";
            myComboBoxID_FK_Permission.SelectedIndex = -1;
            myComboBoxID_FK_Permission.SelectedValue = null;
            myComboBoxID_FK_Permission.Size = new Size(275, 31);
            myComboBoxID_FK_Permission.TabIndex = 9;
            myComboBoxID_FK_Permission.ValueMember = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 298);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 8;
            label4.Text = "جواب سوال امنیتی";
            // 
            // myTextBoxAnswer
            // 
            myTextBoxAnswer.AutoSize = true;
            myTextBoxAnswer.IsNumber = false;
            myTextBoxAnswer.IsReal = false;
            myTextBoxAnswer.Location = new Point(33, 298);
            myTextBoxAnswer.Margin = new Padding(4, 9, 4, 9);
            myTextBoxAnswer.Name = "myTextBoxAnswer";
            myTextBoxAnswer.Size = new Size(275, 27);
            myTextBoxAnswer.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "رمز ورود";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "نام خانوادگی";
            // 
            // myTextBoxLastName
            // 
            myTextBoxLastName.AutoSize = true;
            myTextBoxLastName.IsNumber = false;
            myTextBoxLastName.IsReal = false;
            myTextBoxLastName.Location = new Point(33, 71);
            myTextBoxLastName.Margin = new Padding(4, 6, 4, 6);
            myTextBoxLastName.Name = "myTextBoxLastName";
            myTextBoxLastName.Size = new Size(275, 27);
            myTextBoxLastName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 2;
            label1.Text = "نام";
            // 
            // myToolbarUsers
            // 
            myToolbarUsers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbarUsers.Location = new Point(17, 395);
            myToolbarUsers.Margin = new Padding(4, 5, 4, 5);
            myToolbarUsers.Name = "myToolbarUsers";
            myToolbarUsers.RightToLeft = RightToLeft.Yes;
            myToolbarUsers.Size = new Size(430, 132);
            myToolbarUsers.TabIndex = 1;
            myToolbarUsers.Btn_OK += myToolbar1_Btn_OK;
            myToolbarUsers.Btn_Cancel += myToolbar1_Btn_Cancel;
            myToolbarUsers.Btn_New += myToolbar1_Btn_New;
            myToolbarUsers.Btn_Edit += myToolbar1_Btn_Edit;
            myToolbarUsers.Btn_Delete += myToolbar1_Btn_Delete;
            // 
            // myTextBoxName
            // 
            myTextBoxName.AutoSize = true;
            myTextBoxName.IsNumber = false;
            myTextBoxName.IsReal = false;
            myTextBoxName.Location = new Point(33, 29);
            myTextBoxName.Margin = new Padding(4, 5, 4, 5);
            myTextBoxName.Name = "myTextBoxName";
            myTextBoxName.Size = new Size(275, 27);
            myTextBoxName.TabIndex = 0;
            // 
            // usersDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            usersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            usersDataGridView.Dock = DockStyle.Fill;
            usersDataGridView.Location = new Point(0, 60);
            usersDataGridView.Margin = new Padding(4);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.RightToLeft = RightToLeft.Yes;
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.Size = new Size(903, 557);
            usersDataGridView.TabIndex = 12;
            usersDataGridView.CellClick += usersDataGridView_CellClick;
            usersDataGridView.CellFormatting += usersDataGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            // 
            // errorProviderUsers
            // 
            errorProviderUsers.ContainerControl = this;
            errorProviderUsers.RightToLeft = true;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 617);
            Controls.Add(usersDataGridView);
            Controls.Add(panel2);
            Margin = new Padding(4, 6, 4, 6);
            Name = "FrmUsers";
            Load += FrmUsers_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(usersDataGridView, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private System.Windows.Forms.Panel panel2;
        private BaseControl.MyTextBox myTextBoxName;
        private BaseControl.MyToolbar myToolbarUsers;
        private System.Windows.Forms.Label label2;
        private BaseControl.MyTextBox myTextBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Label label6;
        private BaseControl.MyComboBox myComboBoxID_FK_SecurityQuestion;
        private System.Windows.Forms.Label label5;
        private BaseControl.MyComboBox myComboBoxID_FK_Permission;
        private System.Windows.Forms.Label label4;
        private BaseControl.MyTextBox myTextBoxAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label7;
        private BaseControl.MyTextBox myTextBoxUsername;
        private System.Windows.Forms.ErrorProvider errorProviderUsers;
    }
}