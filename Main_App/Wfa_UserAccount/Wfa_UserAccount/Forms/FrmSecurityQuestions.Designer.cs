namespace Wfa_UserAccount.Forms
{
    partial class FrmSecurityQuestions
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
            myToolbarSecurityQuestion = new BaseControl.MyToolbar();
            textBoxDescription = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TextBoxQuestion = new BaseControl.MyTextBox();
            SecurityQuestionDataGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SecurityQuestionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(myToolbarSecurityQuestion);
            panel2.Controls.Add(textBoxDescription);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TextBoxQuestion);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(805, 57);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 468);
            panel2.TabIndex = 9;
            // 
            // myToolbarSecurityQuestion
            // 
            myToolbarSecurityQuestion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbarSecurityQuestion.Location = new Point(31, 291);
            myToolbarSecurityQuestion.Margin = new Padding(4, 5, 4, 5);
            myToolbarSecurityQuestion.Name = "myToolbarSecurityQuestion";
            myToolbarSecurityQuestion.RightToLeft = RightToLeft.Yes;
            myToolbarSecurityQuestion.Size = new Size(434, 122);
            myToolbarSecurityQuestion.TabIndex = 4;
            myToolbarSecurityQuestion.Btn_OK += myToolbarSecurityQuestion_Btn_OK;
            myToolbarSecurityQuestion.Btn_Cancel += myToolbarSecurityQuestion_Btn_Cancel;
            myToolbarSecurityQuestion.Btn_New += myToolbarSecurityQuestion_Btn_New;
            myToolbarSecurityQuestion.Btn_Edit += myToolbarSecurityQuestion_Btn_Edit;
            myToolbarSecurityQuestion.Btn_Delete += myToolbarSecurityQuestion_Btn_Delete;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(41, 146);
            textBoxDescription.Margin = new Padding(4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(367, 60);
            textBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "توضیحات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "متن سوال";
            // 
            // TextBoxQuestion
            // 
            TextBoxQuestion.AutoSize = true;
            TextBoxQuestion.IsNumber = false;
            TextBoxQuestion.IsReal = false;
            TextBoxQuestion.Location = new Point(41, 56);
            TextBoxQuestion.Margin = new Padding(4, 5, 4, 5);
            TextBoxQuestion.Name = "TextBoxQuestion";
            TextBoxQuestion.Size = new Size(367, 27);
            TextBoxQuestion.TabIndex = 0;
            // 
            // SecurityQuestionDataGridView
            // 
            SecurityQuestionDataGridView.AllowUserToAddRows = false;
            SecurityQuestionDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            SecurityQuestionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SecurityQuestionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SecurityQuestionDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            SecurityQuestionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SecurityQuestionDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            SecurityQuestionDataGridView.Dock = DockStyle.Fill;
            SecurityQuestionDataGridView.Location = new Point(0, 57);
            SecurityQuestionDataGridView.Margin = new Padding(4);
            SecurityQuestionDataGridView.Name = "SecurityQuestionDataGridView";
            SecurityQuestionDataGridView.ReadOnly = true;
            SecurityQuestionDataGridView.RightToLeft = RightToLeft.Yes;
            SecurityQuestionDataGridView.RowHeadersWidth = 51;
            SecurityQuestionDataGridView.Size = new Size(805, 468);
            SecurityQuestionDataGridView.TabIndex = 11;
            SecurityQuestionDataGridView.CellClick += SecurityQuestionDataGridView_CellClick;
            SecurityQuestionDataGridView.CellFormatting += SecurityQuestionDataGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // FrmSecurityQuestions
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 525);
            Controls.Add(SecurityQuestionDataGridView);
            Controls.Add(panel2);
            Margin = new Padding(4, 7, 4, 7);
            Name = "FrmSecurityQuestions";
            Load += FrmSecurityQuestions_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(SecurityQuestionDataGridView, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SecurityQuestionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private BaseControl.MyTextBox TextBoxQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SecurityQuestionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private BaseControl.MyToolbar myToolbarSecurityQuestion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}