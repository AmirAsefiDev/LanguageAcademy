namespace Wfa_ZabanSara.Forms
{
    partial class frmMsg
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
            this.ButtonOk = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(138, 186);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(103, 48);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "تایید";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(159, 105);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(41, 17);
            this.labelMsg.TabIndex = 3;
            this.labelMsg.Text = "label1";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(247, 186);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(103, 48);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "لغو";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // frmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 257);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.ButtonOk);
            this.Name = "frmMsg";
            this.Load += new System.EventHandler(this.frmMsg_Load);
            this.Controls.SetChildIndex(this.ButtonOk, 0);
            this.Controls.SetChildIndex(this.labelMsg, 0);
            this.Controls.SetChildIndex(this.ButtonCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelMsg;
        public System.Windows.Forms.Button ButtonOk;
        public System.Windows.Forms.Button ButtonCancel;
    }
}