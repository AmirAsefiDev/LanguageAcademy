namespace Wfa_FinancialSystem.Forms
{
    partial class FrmPayment
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
            labelDocumentNumber = new LinkLabel();
            labelStudentInfo = new LinkLabel();
            label7 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            ComboBoxID_FK_Bank = new BaseControl.MyComboBox();
            label5 = new Label();
            ComboBoxID_FK_PayType = new BaseControl.MyComboBox();
            label4 = new Label();
            txtAmount = new BaseControl.MyTextBox();
            txtDocumentNumber = new BaseControl.MyTextBox();
            buttonSearchDocumentNumber = new Button();
            label2 = new Label();
            txtTracingID = new BaseControl.MyTextBox();
            buttonSearchStudent = new Button();
            txtStudentInfo = new BaseControl.MyTextBox();
            myToolbarPayment = new BaseControl.MyToolbar();
            PaymentDataGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderPayment = new ErrorProvider(components);
            panel3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            labelTotalBedehi = new Label();
            labeltotalPay = new Label();
            labelTotalTuition = new Label();
            label8 = new Label();
            label3 = new Label();
            label345 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPayment).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(labelDocumentNumber);
            panel2.Controls.Add(labelStudentInfo);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ComboBoxID_FK_Bank);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ComboBoxID_FK_PayType);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAmount);
            panel2.Controls.Add(txtDocumentNumber);
            panel2.Controls.Add(buttonSearchDocumentNumber);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTracingID);
            panel2.Controls.Add(buttonSearchStudent);
            panel2.Controls.Add(txtStudentInfo);
            panel2.Controls.Add(myToolbarPayment);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1112, 69);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 704);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // labelDocumentNumber
            // 
            labelDocumentNumber.AutoSize = true;
            labelDocumentNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelDocumentNumber.Location = new Point(357, 148);
            labelDocumentNumber.Name = "labelDocumentNumber";
            labelDocumentNumber.Size = new Size(87, 23);
            labelDocumentNumber.TabIndex = 19;
            labelDocumentNumber.TabStop = true;
            labelDocumentNumber.Text = "شماره سند";
            labelDocumentNumber.LinkClicked += labelDocumentNumber_LinkClicked;
            // 
            // labelStudentInfo
            // 
            labelStudentInfo.AutoSize = true;
            labelStudentInfo.Location = new Point(357, 28);
            labelStudentInfo.Name = "labelStudentInfo";
            labelStudentInfo.Size = new Size(87, 23);
            labelStudentInfo.TabIndex = 18;
            labelStudentInfo.TabStop = true;
            labelStudentInfo.Text = "نام دانشجو";
            labelStudentInfo.Click += labelStudentInfo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 386);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 17;
            label7.Text = "توضیحات";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(82, 383);
            txtDescription.Margin = new Padding(2, 3, 2, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(266, 139);
            txtDescription.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 331);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 23);
            label6.TabIndex = 15;
            label6.Text = "بانک";
            // 
            // ComboBoxID_FK_Bank
            // 
            ComboBoxID_FK_Bank.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxID_FK_Bank.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxID_FK_Bank.DataSource = null;
            ComboBoxID_FK_Bank.DisplayMember = "";
            ComboBoxID_FK_Bank.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxID_FK_Bank.Location = new Point(82, 328);
            ComboBoxID_FK_Bank.Margin = new Padding(3, 4, 3, 4);
            ComboBoxID_FK_Bank.Name = "ComboBoxID_FK_Bank";
            ComboBoxID_FK_Bank.SelectedIndex = -1;
            ComboBoxID_FK_Bank.SelectedValue = null;
            ComboBoxID_FK_Bank.Size = new Size(267, 31);
            ComboBoxID_FK_Bank.TabIndex = 14;
            ComboBoxID_FK_Bank.ValueMember = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 269);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 13;
            label5.Text = "نوع پرداخت";
            // 
            // ComboBoxID_FK_PayType
            // 
            ComboBoxID_FK_PayType.AutoCompleteMode = AutoCompleteMode.None;
            ComboBoxID_FK_PayType.AutoCompleteSource = AutoCompleteSource.None;
            ComboBoxID_FK_PayType.DataSource = null;
            ComboBoxID_FK_PayType.DisplayMember = "";
            ComboBoxID_FK_PayType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxID_FK_PayType.Location = new Point(82, 267);
            ComboBoxID_FK_PayType.Margin = new Padding(3, 4, 3, 4);
            ComboBoxID_FK_PayType.Name = "ComboBoxID_FK_PayType";
            ComboBoxID_FK_PayType.SelectedIndex = -1;
            ComboBoxID_FK_PayType.SelectedValue = null;
            ComboBoxID_FK_PayType.Size = new Size(267, 31);
            ComboBoxID_FK_PayType.TabIndex = 12;
            ComboBoxID_FK_PayType.ValueMember = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 211);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 11;
            label4.Text = "مبلغ";
            // 
            // txtAmount
            // 
            txtAmount.IsNumber = false;
            txtAmount.IsReal = false;
            txtAmount.Location = new Point(82, 210);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(267, 27);
            txtAmount.TabIndex = 10;
            // 
            // txtDocumentNumber
            // 
            txtDocumentNumber.IsNumber = false;
            txtDocumentNumber.IsReal = false;
            txtDocumentNumber.Location = new Point(82, 148);
            txtDocumentNumber.Margin = new Padding(4, 5, 4, 5);
            txtDocumentNumber.Name = "txtDocumentNumber";
            txtDocumentNumber.Size = new Size(267, 27);
            txtDocumentNumber.TabIndex = 8;
            // 
            // buttonSearchDocumentNumber
            // 
            buttonSearchDocumentNumber.FlatStyle = FlatStyle.Flat;
            buttonSearchDocumentNumber.Image = Properties.Resources.search_1_;
            buttonSearchDocumentNumber.Location = new Point(22, 145);
            buttonSearchDocumentNumber.Margin = new Padding(2, 3, 2, 3);
            buttonSearchDocumentNumber.Name = "buttonSearchDocumentNumber";
            buttonSearchDocumentNumber.Size = new Size(32, 33);
            buttonSearchDocumentNumber.TabIndex = 7;
            buttonSearchDocumentNumber.UseVisualStyleBackColor = true;
            buttonSearchDocumentNumber.Click += buttonSearchDocumentNumber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 6;
            label2.Text = "شماره واریز";
            // 
            // txtTracingID
            // 
            txtTracingID.IsNumber = false;
            txtTracingID.IsReal = false;
            txtTracingID.Location = new Point(82, 86);
            txtTracingID.Margin = new Padding(4, 5, 4, 5);
            txtTracingID.Name = "txtTracingID";
            txtTracingID.Size = new Size(267, 27);
            txtTracingID.TabIndex = 5;
            // 
            // buttonSearchStudent
            // 
            buttonSearchStudent.FlatStyle = FlatStyle.Flat;
            buttonSearchStudent.Image = Properties.Resources.search_1_;
            buttonSearchStudent.Location = new Point(22, 25);
            buttonSearchStudent.Margin = new Padding(2, 3, 2, 3);
            buttonSearchStudent.Name = "buttonSearchStudent";
            buttonSearchStudent.Size = new Size(32, 33);
            buttonSearchStudent.TabIndex = 4;
            buttonSearchStudent.UseVisualStyleBackColor = true;
            buttonSearchStudent.Click += buttonSearchStudent_Click;
            // 
            // txtStudentInfo
            // 
            txtStudentInfo.Enabled = false;
            txtStudentInfo.IsNumber = false;
            txtStudentInfo.IsReal = false;
            txtStudentInfo.Location = new Point(82, 27);
            txtStudentInfo.Margin = new Padding(4, 5, 4, 5);
            txtStudentInfo.Name = "txtStudentInfo";
            txtStudentInfo.Size = new Size(267, 27);
            txtStudentInfo.TabIndex = 3;
            // 
            // myToolbarPayment
            // 
            myToolbarPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbarPayment.Location = new Point(14, 543);
            myToolbarPayment.Name = "myToolbarPayment";
            myToolbarPayment.RightToLeft = RightToLeft.Yes;
            myToolbarPayment.Size = new Size(432, 131);
            myToolbarPayment.TabIndex = 0;
            myToolbarPayment.Btn_OK += myToolbarPayment_Btn_OK;
            myToolbarPayment.Btn_Cancel += myToolbarPayment_Btn_Cancel;
            myToolbarPayment.Btn_New += myToolbarPayment_Btn_New;
            myToolbarPayment.Btn_Edit += myToolbarPayment_Btn_Edit;
            myToolbarPayment.Btn_Delete += myToolbarPayment_Btn_Delete;
            // 
            // PaymentDataGridView
            // 
            PaymentDataGridView.AllowUserToAddRows = false;
            PaymentDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            PaymentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PaymentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PaymentDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            PaymentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            PaymentDataGridView.Dock = DockStyle.Fill;
            PaymentDataGridView.Location = new Point(0, 69);
            PaymentDataGridView.Margin = new Padding(2, 3, 2, 3);
            PaymentDataGridView.Name = "PaymentDataGridView";
            PaymentDataGridView.ReadOnly = true;
            PaymentDataGridView.RowHeadersWidth = 51;
            PaymentDataGridView.Size = new Size(1112, 704);
            PaymentDataGridView.TabIndex = 4;
            PaymentDataGridView.CellFormatting += PaymentDataGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderPayment
            // 
            errorProviderPayment.ContainerControl = this;
            errorProviderPayment.RightToLeft = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(labelTotalBedehi);
            panel3.Controls.Add(labeltotalPay);
            panel3.Controls.Add(labelTotalTuition);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label345);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 620);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 153);
            panel3.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(698, 63);
            label13.Name = "label13";
            label13.Size = new Size(39, 23);
            label13.TabIndex = 26;
            label13.Text = "ریال";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(698, 108);
            label12.Name = "label12";
            label12.Size = new Size(39, 23);
            label12.TabIndex = 25;
            label12.Text = "ریال";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(698, 17);
            label11.Name = "label11";
            label11.Size = new Size(39, 23);
            label11.TabIndex = 24;
            label11.Text = "ریال";
            // 
            // labelTotalBedehi
            // 
            labelTotalBedehi.AutoSize = true;
            labelTotalBedehi.ForeColor = Color.Red;
            labelTotalBedehi.Location = new Point(742, 108);
            labelTotalBedehi.Margin = new Padding(2, 0, 2, 0);
            labelTotalBedehi.Name = "labelTotalBedehi";
            labelTotalBedehi.Size = new Size(17, 23);
            labelTotalBedehi.TabIndex = 23;
            labelTotalBedehi.Text = "0";
            // 
            // labeltotalPay
            // 
            labeltotalPay.AutoSize = true;
            labeltotalPay.Location = new Point(742, 17);
            labeltotalPay.Margin = new Padding(2, 0, 2, 0);
            labeltotalPay.Name = "labeltotalPay";
            labeltotalPay.Size = new Size(17, 23);
            labeltotalPay.TabIndex = 22;
            labeltotalPay.Text = "0";
            // 
            // labelTotalTuition
            // 
            labelTotalTuition.AutoSize = true;
            labelTotalTuition.Location = new Point(742, 63);
            labelTotalTuition.Margin = new Padding(2, 0, 2, 0);
            labelTotalTuition.Name = "labelTotalTuition";
            labelTotalTuition.Size = new Size(17, 23);
            labelTotalTuition.TabIndex = 21;
            labelTotalTuition.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(870, 108);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 20;
            label8.Text = "مقدار بدهی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(870, 63);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 19;
            label3.Text = "جمع کل شهریه ها";
            // 
            // label345
            // 
            label345.AutoSize = true;
            label345.Location = new Point(870, 17);
            label345.Margin = new Padding(2, 0, 2, 0);
            label345.Name = "label345";
            label345.Size = new Size(145, 23);
            label345.TabIndex = 18;
            label345.Text = "جمع کل پرداختی ها";
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 773);
            Controls.Add(panel3);
            Controls.Add(PaymentDataGridView);
            Controls.Add(panel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPayment";
            Load += FrmPayment_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(PaymentDataGridView, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPayment).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonSearchStudent;
        private BaseControl.MyTextBox txtStudentInfo;
        private BaseControl.MyToolbar myToolbarPayment;
        private DataGridView PaymentDataGridView;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private BaseControl.MyTextBox txtTracingID;
        private Label label5;
        private BaseControl.MyComboBox ComboBoxID_FK_PayType;
        private Label label4;
        private BaseControl.MyTextBox txtAmount;
        private BaseControl.MyTextBox txtDocumentNumber;
        private Button buttonSearchDocumentNumber;
        private Label label2;
        private Label label7;
        private TextBox txtDescription;
        private Label label6;
        private BaseControl.MyComboBox ComboBoxID_FK_Bank;
        private ErrorProvider errorProviderPayment;
        private Panel panel3;
        private Label label8;
        private Label label3;
        private Label label345;
        private LinkLabel labelStudentInfo;
        private LinkLabel labelDocumentNumber;
        private Label labelTotalTuition;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label labelTotalBedehi;
        private Label labeltotalPay;
    }
}