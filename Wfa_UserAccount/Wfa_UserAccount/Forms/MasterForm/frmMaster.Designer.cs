namespace Wfa_UserAccount.Forms.MasterForm
{
    partial class frmMaster
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
            panelMaster = new Panel();
            labFormName = new Label();
            picExit = new PictureBox();
            panel1 = new Panel();
            panelMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // panelMaster
            // 
            panelMaster.BackColor = Color.DodgerBlue;
            panelMaster.Controls.Add(labFormName);
            panelMaster.Controls.Add(picExit);
            panelMaster.Dock = DockStyle.Top;
            panelMaster.Location = new Point(0, 0);
            panelMaster.Margin = new Padding(4);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(867, 53);
            panelMaster.TabIndex = 2;
            // 
            // labFormName
            // 
            labFormName.AutoSize = true;
            labFormName.Location = new Point(419, 11);
            labFormName.Margin = new Padding(4, 0, 4, 0);
            labFormName.Name = "labFormName";
            labFormName.Size = new Size(51, 20);
            labFormName.TabIndex = 1;
            labFormName.Text = "label1";
            // 
            // picExit
            // 
            picExit.Image = Properties.Resources.exit;
            picExit.Location = new Point(815, 11);
            picExit.Name = "picExit";
            picExit.Size = new Size(33, 31);
            picExit.TabIndex = 0;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 7);
            panel1.TabIndex = 3;
            // 
            // frmMaster
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(867, 529);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panelMaster);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmMaster";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMaster_Load;
            panelMaster.ResumeLayout(false);
            panelMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelMaster;
        private Label labFormName;
        private PictureBox picExit;
        private Panel panel1;
    }
}