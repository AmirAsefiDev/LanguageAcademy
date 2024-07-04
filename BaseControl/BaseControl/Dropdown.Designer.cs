namespace BaseControl
{
    partial class Dropdown
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
            ShowDropdownButton = new Button();
            DropDownInputMaskedEdit = new MaskedTextBox();
            SuspendLayout();
            // 
            // ShowDropdownButton
            // 
            ShowDropdownButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowDropdownButton.Location = new Point(0, 1);
            ShowDropdownButton.Margin = new Padding(4, 3, 4, 3);
            ShowDropdownButton.Name = "ShowDropdownButton";
            ShowDropdownButton.Size = new Size(73, 29);
            ShowDropdownButton.TabIndex = 0;
            ShowDropdownButton.Text = "▼";
            ShowDropdownButton.UseVisualStyleBackColor = true;
            ShowDropdownButton.Click += ShowDropdownButton_Click;
            // 
            // DropDownInputMaskedEdit
            // 
            DropDownInputMaskedEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DropDownInputMaskedEdit.Location = new Point(72, 2);
            DropDownInputMaskedEdit.Name = "DropDownInputMaskedEdit";
            DropDownInputMaskedEdit.Size = new Size(279, 27);
            DropDownInputMaskedEdit.TabIndex = 2;
            // 
            // Dropdown
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DropDownInputMaskedEdit);
            Controls.Add(ShowDropdownButton);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dropdown";
            Size = new Size(351, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ShowDropdownButton;
        private System.Windows.Forms.MaskedTextBox DropDownInputMaskedEdit;
    }
}
