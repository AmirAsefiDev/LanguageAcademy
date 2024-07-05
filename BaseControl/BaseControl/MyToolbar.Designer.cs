namespace BaseControl
{
    partial class MyToolbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelButton = new Panel();
            BtnDelete = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            PanelAction = new Panel();
            BtnOK = new Button();
            BtnCancel = new Button();
            PanelButton.SuspendLayout();
            PanelAction.SuspendLayout();
            SuspendLayout();
            // 
            // PanelButton
            // 
            PanelButton.BackColor = Color.Gainsboro;
            PanelButton.Controls.Add(BtnDelete);
            PanelButton.Controls.Add(BtnNew);
            PanelButton.Controls.Add(BtnEdit);
            PanelButton.Location = new Point(252, 27);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(405, 117);
            PanelButton.TabIndex = 0;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.DeleteImage;
            BtnDelete.ImageAlign = ContentAlignment.MiddleRight;
            BtnDelete.Location = new Point(15, 27);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(115, 65);
            BtnDelete.TabIndex = 24;
            BtnDelete.Text = "حذف";
            BtnDelete.TextAlign = ContentAlignment.MiddleLeft;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.InsertImage;
            BtnNew.ImageAlign = ContentAlignment.MiddleRight;
            BtnNew.Location = new Point(272, 27);
            BtnNew.Margin = new Padding(3, 4, 3, 4);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(115, 65);
            BtnNew.TabIndex = 22;
            BtnNew.Text = "جدید";
            BtnNew.TextAlign = ContentAlignment.MiddleLeft;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.UpdateImage;
            BtnEdit.ImageAlign = ContentAlignment.MiddleRight;
            BtnEdit.Location = new Point(142, 27);
            BtnEdit.Margin = new Padding(3, 4, 3, 4);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(115, 65);
            BtnEdit.TabIndex = 23;
            BtnEdit.Text = "ویرایش";
            BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // PanelAction
            // 
            PanelAction.BackColor = Color.White;
            PanelAction.Controls.Add(BtnOK);
            PanelAction.Controls.Add(BtnCancel);
            PanelAction.Location = new Point(17, 27);
            PanelAction.Name = "PanelAction";
            PanelAction.Size = new Size(229, 117);
            PanelAction.TabIndex = 1;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(118, 45);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(94, 29);
            BtnOK.TabIndex = 0;
            BtnOK.Text = "تایید";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(18, 45);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "لغو";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // MyToolbar
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelAction);
            Controls.Add(PanelButton);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MyToolbar";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(678, 176);
            Load += MyToolbar_Load;
            PanelButton.ResumeLayout(false);
            PanelAction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelButton;
        private Button BtnDelete;
        private Button BtnNew;
        private Button BtnEdit;
        private Panel PanelAction;
        private Button BtnOK;
        private Button BtnCancel;
    }
}
