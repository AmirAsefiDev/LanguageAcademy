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
            myToolbar1 = new MyToolbar();
            SuspendLayout();
            // 
            // myTextBox1
            // 
            myTextBox1.IsNumber = true;
            myTextBox1.IsReal = false;
            myTextBox1.Location = new Point(231, 59);
            myTextBox1.Margin = new Padding(3, 5, 3, 5);
            myTextBox1.Name = "myTextBox1";
            myTextBox1.Size = new Size(222, 27);
            myTextBox1.TabIndex = 0;
            // 
            // myTextBox2
            // 
            myTextBox2.IsNumber = false;
            myTextBox2.IsReal = true;
            myTextBox2.Location = new Point(231, 111);
            myTextBox2.Margin = new Padding(3, 5, 3, 5);
            myTextBox2.Name = "myTextBox2";
            myTextBox2.Size = new Size(222, 27);
            myTextBox2.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(183, 180);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // myComboBox1
            // 
            myComboBox1.AutoCompleteMode = AutoCompleteMode.None;
            myComboBox1.AutoCompleteSource = AutoCompleteSource.None;
            myComboBox1.DataSource = null;
            myComboBox1.DisplayMember = "";
            myComboBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myComboBox1.Location = new Point(355, 180);
            myComboBox1.Margin = new Padding(3, 5, 3, 5);
            myComboBox1.Name = "myComboBox1";
            myComboBox1.SelectedIndex = -1;
            myComboBox1.SelectedValue = null;
            myComboBox1.Size = new Size(214, 31);
            myComboBox1.TabIndex = 3;
            myComboBox1.ValueMember = "";
            // 
            // dropdown1
            // 
            dropdown1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropdown1.InputMask = "";
            dropdown1.Location = new Point(64, 47);
            dropdown1.Margin = new Padding(5, 4, 5, 4);
            dropdown1.Name = "dropdown1";
            dropdown1.Size = new Size(401, 39);
            dropdown1.TabIndex = 4;
            dropdown1.Value = "";
            // 
            // myToolbar1
            // 
            myToolbar1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myToolbar1.Location = new Point(12, 269);
            myToolbar1.Name = "myToolbar1";
            myToolbar1.RightToLeft = RightToLeft.Yes;
            myToolbar1.Size = new Size(666, 167);
            myToolbar1.TabIndex = 5;
            myToolbar1.Btn_OK += myToolbar1_Btn_OK;
            myToolbar1.Btn_Cancel += myToolbar1_Btn_Cancel;
            myToolbar1.Btn_New += myToolbar1_Btn_New;
            myToolbar1.Btn_Edit += myToolbar1_Btn_Edit;
            myToolbar1.Btn_Delete += myToolbar1_Btn_Delete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 644);
            Controls.Add(myToolbar1);
            Controls.Add(dropdown1);
            Controls.Add(myComboBox1);
            Controls.Add(checkBox1);
            Controls.Add(myTextBox2);
            Controls.Add(myTextBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private MyToolbar myToolbar1;
    }
}
