namespace Wfa_UserAccount.Forms
{
    partial class FrmPermission
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            groupBoxCheckingOut = new GroupBox();
            checkBoxTeachersManage = new CheckBox();
            checkBoxStudentsManage = new CheckBox();
            checkBoxCoursesManage = new CheckBox();
            checkBoxPaymentManage = new CheckBox();
            checkBoxSelectUserPermission = new CheckBox();
            checkBoxEditUserPermission = new CheckBox();
            checkBoxDeleteUserPermission = new CheckBox();
            checkBoxAddUserPermission = new CheckBox();
            textBoxUserName = new TextBox();
            label1 = new Label();
            myToolbarPermission = new BaseControl.MyToolbar();
            PermissionDataGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderPermission = new ErrorProvider(components);
            checkBoxChooseAll = new CheckBox();
            panel2.SuspendLayout();
            groupBoxCheckingOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PermissionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPermission).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(groupBoxCheckingOut);
            panel2.Controls.Add(textBoxUserName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(myToolbarPermission);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1220, 222);
            panel2.TabIndex = 4;
            // 
            // groupBoxCheckingOut
            // 
            groupBoxCheckingOut.BackColor = Color.Azure;
            groupBoxCheckingOut.Controls.Add(checkBoxChooseAll);
            groupBoxCheckingOut.Controls.Add(checkBoxTeachersManage);
            groupBoxCheckingOut.Controls.Add(checkBoxStudentsManage);
            groupBoxCheckingOut.Controls.Add(checkBoxCoursesManage);
            groupBoxCheckingOut.Controls.Add(checkBoxPaymentManage);
            groupBoxCheckingOut.Controls.Add(checkBoxSelectUserPermission);
            groupBoxCheckingOut.Controls.Add(checkBoxEditUserPermission);
            groupBoxCheckingOut.Controls.Add(checkBoxDeleteUserPermission);
            groupBoxCheckingOut.Controls.Add(checkBoxAddUserPermission);
            groupBoxCheckingOut.Location = new Point(641, 58);
            groupBoxCheckingOut.Name = "groupBoxCheckingOut";
            groupBoxCheckingOut.Size = new Size(561, 155);
            groupBoxCheckingOut.TabIndex = 3;
            groupBoxCheckingOut.TabStop = false;
            groupBoxCheckingOut.Text = "مجوز دسترسی";
            // 
            // checkBoxTeachersManage
            // 
            checkBoxTeachersManage.AutoSize = true;
            checkBoxTeachersManage.Location = new Point(51, 68);
            checkBoxTeachersManage.Name = "checkBoxTeachersManage";
            checkBoxTeachersManage.RightToLeft = RightToLeft.Yes;
            checkBoxTeachersManage.Size = new Size(131, 24);
            checkBoxTeachersManage.TabIndex = 7;
            checkBoxTeachersManage.Text = "مدیریت استادان";
            checkBoxTeachersManage.UseVisualStyleBackColor = true;
            // 
            // checkBoxStudentsManage
            // 
            checkBoxStudentsManage.AutoSize = true;
            checkBoxStudentsManage.Location = new Point(32, 26);
            checkBoxStudentsManage.Name = "checkBoxStudentsManage";
            checkBoxStudentsManage.RightToLeft = RightToLeft.Yes;
            checkBoxStudentsManage.Size = new Size(150, 24);
            checkBoxStudentsManage.TabIndex = 6;
            checkBoxStudentsManage.Text = "مدیریت دانشجویان";
            checkBoxStudentsManage.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoursesManage
            // 
            checkBoxCoursesManage.AutoSize = true;
            checkBoxCoursesManage.Location = new Point(234, 111);
            checkBoxCoursesManage.Name = "checkBoxCoursesManage";
            checkBoxCoursesManage.RightToLeft = RightToLeft.Yes;
            checkBoxCoursesManage.Size = new Size(122, 24);
            checkBoxCoursesManage.TabIndex = 5;
            checkBoxCoursesManage.Text = "مدیریت دروس";
            checkBoxCoursesManage.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaymentManage
            // 
            checkBoxPaymentManage.AutoSize = true;
            checkBoxPaymentManage.Location = new Point(211, 69);
            checkBoxPaymentManage.Name = "checkBoxPaymentManage";
            checkBoxPaymentManage.RightToLeft = RightToLeft.Yes;
            checkBoxPaymentManage.Size = new Size(145, 24);
            checkBoxPaymentManage.TabIndex = 4;
            checkBoxPaymentManage.Text = "مدیریت امور مالی";
            checkBoxPaymentManage.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectUserPermission
            // 
            checkBoxSelectUserPermission.AutoSize = true;
            checkBoxSelectUserPermission.Location = new Point(248, 26);
            checkBoxSelectUserPermission.Name = "checkBoxSelectUserPermission";
            checkBoxSelectUserPermission.RightToLeft = RightToLeft.Yes;
            checkBoxSelectUserPermission.Size = new Size(108, 24);
            checkBoxSelectUserPermission.TabIndex = 3;
            checkBoxSelectUserPermission.Text = "دیدن کاربران";
            checkBoxSelectUserPermission.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditUserPermission
            // 
            checkBoxEditUserPermission.AutoSize = true;
            checkBoxEditUserPermission.Location = new Point(365, 111);
            checkBoxEditUserPermission.Name = "checkBoxEditUserPermission";
            checkBoxEditUserPermission.RightToLeft = RightToLeft.Yes;
            checkBoxEditUserPermission.Size = new Size(179, 24);
            checkBoxEditUserPermission.TabIndex = 2;
            checkBoxEditUserPermission.Text = "ویرایش کردن کاربر جدید";
            checkBoxEditUserPermission.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteUserPermission
            // 
            checkBoxDeleteUserPermission.AutoSize = true;
            checkBoxDeleteUserPermission.Location = new Point(379, 69);
            checkBoxDeleteUserPermission.Name = "checkBoxDeleteUserPermission";
            checkBoxDeleteUserPermission.RightToLeft = RightToLeft.Yes;
            checkBoxDeleteUserPermission.Size = new Size(165, 24);
            checkBoxDeleteUserPermission.TabIndex = 1;
            checkBoxDeleteUserPermission.Text = "حذف کردن کاربر جدید";
            checkBoxDeleteUserPermission.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddUserPermission
            // 
            checkBoxAddUserPermission.AutoSize = true;
            checkBoxAddUserPermission.Location = new Point(372, 26);
            checkBoxAddUserPermission.Name = "checkBoxAddUserPermission";
            checkBoxAddUserPermission.RightToLeft = RightToLeft.Yes;
            checkBoxAddUserPermission.Size = new Size(172, 24);
            checkBoxAddUserPermission.TabIndex = 0;
            checkBoxAddUserPermission.Text = "اضافه کردن کاربر جدید";
            checkBoxAddUserPermission.UseVisualStyleBackColor = true;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(833, 14);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(290, 34);
            textBoxUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1129, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "نام کاربری";
            // 
            // myToolbarPermission
            // 
            myToolbarPermission.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbarPermission.Location = new Point(87, 67);
            myToolbarPermission.Name = "myToolbarPermission";
            myToolbarPermission.RightToLeft = RightToLeft.Yes;
            myToolbarPermission.Size = new Size(431, 140);
            myToolbarPermission.TabIndex = 0;
            myToolbarPermission.Btn_OK += myToolbarPermission_Btn_OK;
            myToolbarPermission.Btn_Cancel += myToolbarPermission_Btn_Cancel;
            myToolbarPermission.Btn_New += myToolbarPermission_Btn_New;
            myToolbarPermission.Btn_Edit += myToolbarPermission_Btn_Edit;
            myToolbarPermission.Btn_Delete += myToolbarPermission_Btn_Delete;
            // 
            // PermissionDataGridView
            // 
            PermissionDataGridView.AllowUserToAddRows = false;
            PermissionDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            PermissionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            PermissionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PermissionDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            PermissionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PermissionDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            PermissionDataGridView.Dock = DockStyle.Fill;
            PermissionDataGridView.Location = new Point(0, 282);
            PermissionDataGridView.Margin = new Padding(4);
            PermissionDataGridView.Name = "PermissionDataGridView";
            PermissionDataGridView.ReadOnly = true;
            PermissionDataGridView.RightToLeft = RightToLeft.Yes;
            PermissionDataGridView.RowHeadersWidth = 51;
            PermissionDataGridView.Size = new Size(1220, 437);
            PermissionDataGridView.TabIndex = 12;
            PermissionDataGridView.CellClick += PermissionDataGridView_CellClick;
            PermissionDataGridView.CellFormatting += PermissionDataGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderPermission
            // 
            errorProviderPermission.ContainerControl = this;
            errorProviderPermission.RightToLeft = true;
            // 
            // checkBoxChooseAll
            // 
            checkBoxChooseAll.AutoSize = true;
            checkBoxChooseAll.Location = new Point(79, 111);
            checkBoxChooseAll.Name = "checkBoxChooseAll";
            checkBoxChooseAll.RightToLeft = RightToLeft.Yes;
            checkBoxChooseAll.Size = new Size(103, 24);
            checkBoxChooseAll.TabIndex = 8;
            checkBoxChooseAll.Text = "انتخاب همه";
            checkBoxChooseAll.UseVisualStyleBackColor = true;
            checkBoxChooseAll.CheckedChanged += checkBoxChooseAll_CheckedChanged;
            // 
            // FrmPermission
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 719);
            Controls.Add(PermissionDataGridView);
            Controls.Add(panel2);
            Name = "FrmPermission";
            Load += FrmPermission_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(PermissionDataGridView, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxCheckingOut.ResumeLayout(false);
            groupBoxCheckingOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PermissionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPermission).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView PermissionDataGridView;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private Label label1;
        private BaseControl.MyToolbar myToolbarPermission;
        private GroupBox groupBoxCheckingOut;
        private TextBox textBoxUserName;
        private CheckBox checkBoxAddUserPermission;
        private CheckBox checkBoxEditUserPermission;
        private CheckBox checkBoxDeleteUserPermission;
        private CheckBox checkBoxStudentsManage;
        private CheckBox checkBoxCoursesManage;
        private CheckBox checkBoxPaymentManage;
        private CheckBox checkBoxSelectUserPermission;
        private CheckBox checkBoxTeachersManage;
        private ErrorProvider errorProviderPermission;
        private CheckBox checkBoxChooseAll;
    }
}