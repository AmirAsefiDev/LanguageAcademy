namespace Wfa_ZabanSara.Forms.MasterForm
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
            this.panelMaster = new System.Windows.Forms.Panel();
            this.labFormName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMaster.Controls.Add(this.labFormName);
            this.panelMaster.Controls.Add(this.picExit);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Margin = new System.Windows.Forms.Padding(4);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(860, 56);
            this.panelMaster.TabIndex = 0;
            // 
            // labFormName
            // 
            this.labFormName.AutoSize = true;
            this.labFormName.Location = new System.Drawing.Point(419, 12);
            this.labFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFormName.Name = "labFormName";
            this.labFormName.Size = new System.Drawing.Size(41, 17);
            this.labFormName.TabIndex = 1;
            this.labFormName.Text = "label1";
            // 
            // picExit
            // 
            this.picExit.Image = global::Wfa_ZabanSara.Properties.Resources.exit;
            this.picExit.Location = new System.Drawing.Point(815, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(33, 33);
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 7);
            this.panel1.TabIndex = 1;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMaster);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaster";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMaster_Load);
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Label labFormName;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel1;
    }
}