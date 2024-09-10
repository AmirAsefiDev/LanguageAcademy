namespace Wfa_FinancialSystem
{
    partial class FrmMain
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
            panel2 = new Panel();
            ButtonPayment = new Button();
            ButtonPayType = new Button();
            ButtonBank = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ButtonPayment);
            panel2.Controls.Add(ButtonPayType);
            panel2.Controls.Add(ButtonBank);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 145);
            panel2.TabIndex = 2;
            // 
            // ButtonPayment
            // 
            ButtonPayment.BackColor = Color.WhiteSmoke;
            ButtonPayment.BackgroundImageLayout = ImageLayout.None;
            ButtonPayment.FlatStyle = FlatStyle.Flat;
            ButtonPayment.Image = Properties.Resources.payment;
            ButtonPayment.Location = new Point(290, 21);
            ButtonPayment.Margin = new Padding(3, 4, 3, 4);
            ButtonPayment.Name = "ButtonPayment";
            ButtonPayment.Size = new Size(119, 102);
            ButtonPayment.TabIndex = 4;
            ButtonPayment.Text = " پرداخت ها";
            ButtonPayment.TextAlign = ContentAlignment.BottomCenter;
            ButtonPayment.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonPayment.UseVisualStyleBackColor = false;
            ButtonPayment.Click += ButtonPayment_Click;
            // 
            // ButtonPayType
            // 
            ButtonPayType.BackColor = Color.WhiteSmoke;
            ButtonPayType.BackgroundImageLayout = ImageLayout.None;
            ButtonPayType.FlatStyle = FlatStyle.Flat;
            ButtonPayType.Image = Properties.Resources.medical_invoice_information;
            ButtonPayType.Location = new Point(151, 21);
            ButtonPayType.Margin = new Padding(3, 4, 3, 4);
            ButtonPayType.Name = "ButtonPayType";
            ButtonPayType.Size = new Size(119, 102);
            ButtonPayType.TabIndex = 3;
            ButtonPayType.Text = "نوع پرداخت";
            ButtonPayType.TextAlign = ContentAlignment.BottomCenter;
            ButtonPayType.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonPayType.UseVisualStyleBackColor = false;
            ButtonPayType.Click += ButtonPayType_Click;
            // 
            // ButtonBank
            // 
            ButtonBank.BackColor = Color.WhiteSmoke;
            ButtonBank.BackgroundImageLayout = ImageLayout.None;
            ButtonBank.FlatStyle = FlatStyle.Flat;
            ButtonBank.Image = Properties.Resources.Graphicloads_100_Flat_2_Bank_64;
            ButtonBank.Location = new Point(12, 20);
            ButtonBank.Margin = new Padding(3, 4, 3, 4);
            ButtonBank.Name = "ButtonBank";
            ButtonBank.Size = new Size(119, 102);
            ButtonBank.TabIndex = 2;
            ButtonBank.Text = "بانک ها";
            ButtonBank.TextAlign = ContentAlignment.BottomCenter;
            ButtonBank.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonBank.UseVisualStyleBackColor = false;
            ButtonBank.Click += ButtonBank_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BackgroundImage = Properties.Resources._666;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(962, 373);
            panel3.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 596);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FrmMain";
            Load += Form1_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button ButtonBank;
        private Panel panel3;
        private Button ButtonPayment;
        private Button ButtonPayType;
    }
}
