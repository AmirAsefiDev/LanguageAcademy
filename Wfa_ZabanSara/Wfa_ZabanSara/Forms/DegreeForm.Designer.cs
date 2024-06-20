namespace Wfa_ZabanSara.Forms
{
    partial class DegreeForm
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
            myTextBox1 = new BaseControl.MyTextBox();
            BtnDelete = new Button();
            BtnPrint = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            label2 = new Label();
            TxtTitle = new TextBox();
            panel3 = new Panel();
            DgvDgree = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProvider = new ErrorProvider(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDgree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(myTextBox1);
            panel2.Controls.Add(BtnDelete);
            panel2.Controls.Add(BtnPrint);
            panel2.Controls.Add(BtnNew);
            panel2.Controls.Add(BtnEdit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TxtTitle);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(310, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 413);
            panel2.TabIndex = 2;
            // 
            // myTextBox1
            // 
            myTextBox1.IsNumber = true;
            myTextBox1.IsReal = false;
            myTextBox1.Location = new Point(20, 138);
            myTextBox1.Name = "myTextBox1";
            myTextBox1.Size = new Size(222, 23);
            myTextBox1.TabIndex = 8;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.DeleteImage;
            BtnDelete.ImageAlign = ContentAlignment.MiddleRight;
            BtnDelete.Location = new Point(151, 320);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(91, 53);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "حذف";
            BtnDelete.TextAlign = ContentAlignment.MiddleLeft;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Image = Properties.Resources.PrintImge;
            BtnPrint.ImageAlign = ContentAlignment.MiddleRight;
            BtnPrint.Location = new Point(30, 320);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(91, 53);
            BtnPrint.TabIndex = 6;
            BtnPrint.Text = "پرنیت";
            BtnPrint.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.InsertImage;
            BtnNew.ImageAlign = ContentAlignment.MiddleRight;
            BtnNew.Location = new Point(151, 247);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(91, 53);
            BtnNew.TabIndex = 5;
            BtnNew.Text = "جدید";
            BtnNew.TextAlign = ContentAlignment.MiddleLeft;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.UpdateImage;
            BtnEdit.ImageAlign = ContentAlignment.MiddleRight;
            BtnEdit.Location = new Point(30, 247);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(91, 53);
            BtnEdit.TabIndex = 4;
            BtnEdit.Text = "ویرایش";
            BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 3;
            label2.Text = "عنوان";
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(30, 78);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(170, 25);
            TxtTitle.TabIndex = 1;
            TxtTitle.Leave += TxtTitle_Leave;
            TxtTitle.MouseEnter += TxtTitle_MouseEnter;
            // 
            // panel3
            // 
            panel3.Controls.Add(DgvDgree);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 413);
            panel3.TabIndex = 3;
            // 
            // DgvDgree
            // 
            DgvDgree.AllowUserToAddRows = false;
            DgvDgree.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            DgvDgree.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvDgree.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDgree.BackgroundColor = SystemColors.ButtonHighlight;
            DgvDgree.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDgree.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DgvDgree.Dock = DockStyle.Fill;
            DgvDgree.Location = new Point(0, 0);
            DgvDgree.Name = "DgvDgree";
            DgvDgree.ReadOnly = true;
            DgvDgree.Size = new Size(310, 413);
            DgvDgree.TabIndex = 0;
            DgvDgree.CellClick += DgvDgree_CellClick;
            DgvDgree.CellFormatting += DgvDgree_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.RightToLeft = true;
            // 
            // DegreeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 476);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "DegreeForm";
            Load += DegreeForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDgree).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgvDgree;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private BaseControl.MyTextBox myTextBox1;
    }
}