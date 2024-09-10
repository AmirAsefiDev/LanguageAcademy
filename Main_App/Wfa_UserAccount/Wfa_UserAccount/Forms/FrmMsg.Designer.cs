namespace Wfa_UserAccount.Forms
{
    partial class FrmMsg
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
            //SuspendLayout();

            ButtonOk = new Button();
            labelMsg = new Label();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // ButtonOk
            // 
            ButtonOk.DialogResult = DialogResult.OK;
            ButtonOk.Location = new Point(155, 230);
            ButtonOk.Margin = new Padding(3, 4, 3, 4);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(116, 59);
            ButtonOk.TabIndex = 2;
            ButtonOk.Text = "تایید";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // labelMsg
            // 
            labelMsg.AutoSize = true;
            labelMsg.Location = new Point(179, 130);
            labelMsg.Name = "labelMsg";
            labelMsg.Size = new Size(53, 23);
            labelMsg.TabIndex = 3;
            labelMsg.Text = "label1";
            // 
            // ButtonCancel
            // 
            ButtonCancel.DialogResult = DialogResult.Cancel;
            ButtonCancel.Location = new Point(278, 230);
            ButtonCancel.Margin = new Padding(3, 4, 3, 4);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(116, 59);
            ButtonCancel.TabIndex = 4;
            ButtonCancel.Text = "لغو";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // frmMsg
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 317);
            Controls.Add(ButtonCancel);
            Controls.Add(labelMsg);
            Controls.Add(ButtonOk);
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmMsg";
            Load += frmMsg_Load;
            Controls.SetChildIndex(ButtonOk, 0);
            Controls.SetChildIndex(labelMsg, 0);
            Controls.SetChildIndex(ButtonCancel, 0);
            ResumeLayout(false);
            PerformLayout();

            //// 
            //// FrmMsg
            //// 
            //AutoScaleDimensions = new SizeF(9F, 20F);
            //AutoScaleMode = AutoScaleMode.Font;
            //ClientSize = new Size(800, 450);
            //Name = "FrmMsg";
            //Load += FrmMsg_Load;
            //ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Label labelMsg;
        public System.Windows.Forms.Button ButtonOk;
        public System.Windows.Forms.Button ButtonCancel;

    }
}