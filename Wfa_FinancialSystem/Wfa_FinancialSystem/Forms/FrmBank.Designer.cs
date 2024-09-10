namespace Wfa_FinancialSystem.Forms
{
    partial class FrmBank
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
            buttonSearchBank = new Button();
            myTextBoxBankName = new BaseControl.MyTextBox();
            label1 = new Label();
            myToolbarBank = new BaseControl.MyToolbar();
            DataGridViewBank = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            errorProviderBank = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBank).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonSearchBank);
            panel2.Controls.Add(myTextBoxBankName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(myToolbarBank);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(596, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 372);
            panel2.TabIndex = 2;
            // 
            // buttonSearchBank
            // 
            buttonSearchBank.FlatStyle = FlatStyle.Flat;
            buttonSearchBank.Image = Properties.Resources.search_1_;
            buttonSearchBank.Location = new Point(22, 35);
            buttonSearchBank.Name = "buttonSearchBank";
            buttonSearchBank.Size = new Size(35, 30);
            buttonSearchBank.TabIndex = 4;
            buttonSearchBank.UseVisualStyleBackColor = true;
            buttonSearchBank.Click += buttonSearchBank_Click;
            // 
            // myTextBoxBankName
            // 
            myTextBoxBankName.IsNumber = false;
            myTextBoxBankName.IsReal = false;
            myTextBoxBankName.Location = new Point(86, 36);
            myTextBoxBankName.Margin = new Padding(3, 4, 3, 4);
            myTextBoxBankName.Name = "myTextBoxBankName";
            myTextBoxBankName.Size = new Size(267, 27);
            myTextBoxBankName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 1;
            label1.Text = "نام :";
            // 
            // myToolbarBank
            // 
            myToolbarBank.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbarBank.Location = new Point(0, 218);
            myToolbarBank.Name = "myToolbarBank";
            myToolbarBank.RightToLeft = RightToLeft.Yes;
            myToolbarBank.Size = new Size(415, 142);
            myToolbarBank.TabIndex = 0;
            myToolbarBank.Btn_OK += myToolbar1_Btn_OK;
            myToolbarBank.Btn_Cancel += myToolbar1_Btn_Cancel;
            myToolbarBank.Btn_New += myToolbar1_Btn_New;
            myToolbarBank.Btn_Edit += myToolbar1_Btn_Edit;
            myToolbarBank.Btn_Delete += myToolbar1_Btn_Delete;
            // 
            // DataGridViewBank
            // 
            DataGridViewBank.AllowUserToAddRows = false;
            DataGridViewBank.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            DataGridViewBank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewBank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewBank.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewBank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBank.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber });
            DataGridViewBank.Dock = DockStyle.Fill;
            DataGridViewBank.Location = new Point(0, 78);
            DataGridViewBank.Margin = new Padding(3, 4, 3, 4);
            DataGridViewBank.Name = "DataGridViewBank";
            DataGridViewBank.ReadOnly = true;
            DataGridViewBank.RowHeadersWidth = 51;
            DataGridViewBank.Size = new Size(596, 372);
            DataGridViewBank.TabIndex = 3;
            DataGridViewBank.CellClick += DataGridViewBank_CellClick;
            DataGridViewBank.CellFormatting += DateGridViewBank_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.MinimumWidth = 6;
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // errorProviderBank
            // 
            errorProviderBank.ContainerControl = this;
            errorProviderBank.RightToLeft = true;
            // 
            // FrmBank
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 450);
            Controls.Add(DataGridViewBank);
            Controls.Add(panel2);
            Name = "FrmBank";
            Load += FrmBank_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(DataGridViewBank, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBank).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBank).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView DataGridViewBank;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private BaseControl.MyToolbar myToolbarBank;
        private Label label1;
        private ErrorProvider errorProviderBank;
        private BaseControl.MyTextBox myTextBoxBankName;
        private Button buttonSearchBank;
    }
}