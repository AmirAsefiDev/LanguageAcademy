namespace Wfa_ZabanSara
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
            panel2 = new Panel();
            ButtonTeacher = new Button();
            ButtonStudent = new Button();
            ButtonDegree = new Button();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(ButtonTeacher);
            panel2.Controls.Add(ButtonStudent);
            panel2.Controls.Add(ButtonDegree);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 106);
            panel2.TabIndex = 2;
            // 
            // ButtonTeacher
            // 
            ButtonTeacher.Location = new Point(236, 3);
            ButtonTeacher.Name = "ButtonTeacher";
            ButtonTeacher.Size = new Size(106, 97);
            ButtonTeacher.TabIndex = 2;
            ButtonTeacher.Text = "استاد";
            ButtonTeacher.UseVisualStyleBackColor = true;
            ButtonTeacher.Click += ButtonTeacher_Click;
            // 
            // ButtonStudent
            // 
            ButtonStudent.Location = new Point(124, 3);
            ButtonStudent.Name = "ButtonStudent";
            ButtonStudent.Size = new Size(106, 97);
            ButtonStudent.TabIndex = 1;
            ButtonStudent.Text = "دانش آموز";
            ButtonStudent.UseVisualStyleBackColor = true;
            ButtonStudent.Click += ButtonStudent_Click;
            // 
            // ButtonDegree
            // 
            ButtonDegree.Location = new Point(12, 3);
            ButtonDegree.Name = "ButtonDegree";
            ButtonDegree.Size = new Size(106, 97);
            ButtonDegree.TabIndex = 0;
            ButtonDegree.Text = "مدرک";
            ButtonDegree.UseVisualStyleBackColor = true;
            ButtonDegree.Click += ButtonDegree_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._0__44_;
            pictureBox1.Location = new Point(0, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(710, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 435);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Activated += Form1_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button ButtonDegree;
        private PictureBox pictureBox1;
        private Button ButtonStudent;
        private Button ButtonTeacher;
    }
}
