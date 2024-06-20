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
            checkBox1.Location = new Point(267, 135);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 313);
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
    }
}
