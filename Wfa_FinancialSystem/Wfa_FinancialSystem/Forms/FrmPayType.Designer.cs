namespace Wfa_FinancialSystem.Forms
{
    partial class FrmPayType
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
            textBoxDescription = new TextBox();
            label2 = new Label();
            buttonSearchPayType = new Button();
            myTextBoxPayType = new BaseControl.MyTextBox();
            label1 = new Label();
            myToolbarPayType = new BaseControl.MyToolbar();
            PayTypeDataGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderPayType = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PayTypeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPayType).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxDescription);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(buttonSearchPayType);
            panel2.Controls.Add(myTextBoxPayType);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(myToolbarPayType);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(664, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 501);
            panel2.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(91, 117);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(267, 167);
            textBoxDescription.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 117);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 9;
            label2.Text = "توضیحات";
            // 
            // buttonSearchPayType
            // 
            buttonSearchPayType.FlatStyle = FlatStyle.Flat;
            buttonSearchPayType.Image = Properties.Resources.search_1_;
            buttonSearchPayType.Location = new Point(25, 51);
            buttonSearchPayType.Name = "buttonSearchPayType";
            buttonSearchPayType.Size = new Size(35, 30);
            buttonSearchPayType.TabIndex = 8;
            buttonSearchPayType.UseVisualStyleBackColor = true;
            buttonSearchPayType.Click += buttonSearchPayType_Click;
            // 
            // myTextBoxPayType
            // 
            myTextBoxPayType.IsNumber = false;
            myTextBoxPayType.IsReal = false;
            myTextBoxPayType.Location = new Point(91, 52);
            myTextBoxPayType.Margin = new Padding(3, 4, 3, 4);
            myTextBoxPayType.Name = "myTextBoxPayType";
            myTextBoxPayType.Size = new Size(267, 27);
            myTextBoxPayType.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 6;
            label1.Text = "نوع پرداخت";
            // 
            // myToolbarPayType
            // 
            myToolbarPayType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbarPayType.Location = new Point(24, 343);
            myToolbarPayType.Name = "myToolbarPayType";
            myToolbarPayType.RightToLeft = RightToLeft.Yes;
            myToolbarPayType.Size = new Size(434, 142);
            myToolbarPayType.TabIndex = 5;
            myToolbarPayType.Btn_OK += myToolbarPayType_Btn_OK;
            myToolbarPayType.Btn_Cancel += myToolbarPayType_Btn_Cancel;
            myToolbarPayType.Btn_New += myToolbarPayType_Btn_New;
            myToolbarPayType.Btn_Edit += myToolbarPayType_Btn_Edit;
            myToolbarPayType.Btn_Delete += myToolbarPayType_Btn_Delete;
            // 
            // PayTypeDataGridView
            // 
            PayTypeDataGridView.AllowUserToAddRows = false;
            PayTypeDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            PayTypeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PayTypeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PayTypeDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            PayTypeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PayTypeDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            PayTypeDataGridView.Dock = DockStyle.Fill;
            PayTypeDataGridView.Location = new Point(0, 78);
            PayTypeDataGridView.Margin = new Padding(3, 4, 3, 4);
            PayTypeDataGridView.Name = "PayTypeDataGridView";
            PayTypeDataGridView.ReadOnly = true;
            PayTypeDataGridView.RowHeadersWidth = 51;
            PayTypeDataGridView.Size = new Size(664, 501);
            PayTypeDataGridView.TabIndex = 6;
            PayTypeDataGridView.CellClick += PayTypeDataGridView_CellClick;
            PayTypeDataGridView.CellFormatting += PayTypeDataGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderPayType
            // 
            errorProviderPayType.ContainerControl = this;
            errorProviderPayType.RightToLeft = true;
            // 
            // FrmPayType
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 579);
            Controls.Add(PayTypeDataGridView);
            Controls.Add(panel2);
            Name = "FrmPayType";
            Load += FrmPayType_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(PayTypeDataGridView, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PayTypeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPayType).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button buttonSearchPayType;
        private BaseControl.MyTextBox myTextBoxPayType;
        private Label label1;
        private BaseControl.MyToolbar myToolbarPayType;
        private TextBox textBoxDescription;
        private Label label2;
        private DataGridView PayTypeDataGridView;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private ErrorProvider errorProviderPayType;
    }
}