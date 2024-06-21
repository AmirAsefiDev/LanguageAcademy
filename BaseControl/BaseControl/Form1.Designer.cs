namespace BaseControl
{
    partial class Form1
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
            myTextBox1 = new MyTextBox();
            myTextBox2 = new MyTextBox();
            checkBox1 = new CheckBox();
            myComboBox1 = new MyComboBox();
            dropdown1 = new Dropdown();
            SuspendLayout();
            // 
            // myTextBox1
            // 
            myTextBox1.IsNumber = true;
            myTextBox1.IsReal = false;
            myTextBox1.Location = new Point(202, 44);
            myTextBox1.Name = "myTextBox1";
            myTextBox1.Size = new Size(222, 23);
            myTextBox1.TabIndex = 0;
            // 
            // myTextBox2
            // 
            myTextBox2.IsNumber = false;
            myTextBox2.IsReal = true;
            myTextBox2.Location = new Point(202, 83);
            myTextBox2.Name = "myTextBox2";
            myTextBox2.Size = new Size(222, 23);
            myTextBox2.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(160, 135);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // myComboBox1
            // 
            myComboBox1.DataSource = null;
            myComboBox1.DisplayMember = "";
            myComboBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myComboBox1.Location = new Point(311, 135);
            myComboBox1.Name = "myComboBox1";
            myComboBox1.selectedItem = null;
            myComboBox1.Size = new Size(214, 26);
            myComboBox1.TabIndex = 3;
            myComboBox1.ValueMember = "";
            // 
            // dropdown1
            // 
            dropdown1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropdown1.InputMask = "";
            dropdown1.Location = new Point(56, 35);
            dropdown1.Margin = new Padding(4, 3, 4, 3);
            dropdown1.Name = "dropdown1";
            dropdown1.Size = new Size(351, 29);
            dropdown1.TabIndex = 4;
            dropdown1.Value = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 483);
            Controls.Add(dropdown1);
            Controls.Add(myComboBox1);
            Controls.Add(checkBox1);
            Controls.Add(myTextBox2);
            Controls.Add(myTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyTextBox myTextBox1;
        private MyTextBox myTextBox2;
        private CheckBox checkBox1;
        private MyComboBox myComboBox1;
        private Dropdown dropdown1;
    }
}
