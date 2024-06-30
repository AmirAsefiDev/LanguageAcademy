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
            ButtonCourseSelect = new Button();
            ButtonCourseGroup = new Button();
            ButtonCourse = new Button();
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
            panel2.Controls.Add(ButtonCourseSelect);
            panel2.Controls.Add(ButtonCourseGroup);
            panel2.Controls.Add(ButtonCourse);
            panel2.Controls.Add(ButtonTeacher);
            panel2.Controls.Add(ButtonStudent);
            panel2.Controls.Add(ButtonDegree);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 134);
            panel2.TabIndex = 2;
            // 
            // ButtonCourseSelect
            // 
            ButtonCourseSelect.Image = Properties.Resources.Student_3_icon;
            ButtonCourseSelect.Location = new Point(640, 8);
            ButtonCourseSelect.Name = "ButtonCourseSelect";
            ButtonCourseSelect.Size = new Size(119, 119);
            ButtonCourseSelect.TabIndex = 5;
            ButtonCourseSelect.Text = "انتخاب واحد";
            ButtonCourseSelect.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonCourseSelect.UseVisualStyleBackColor = true;
            ButtonCourseSelect.Click += ButtonCourseSelect_Click;
            // 
            // ButtonCourseGroup
            // 
            ButtonCourseGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCourseGroup.Image = Properties.Resources.Group_icon;
            ButtonCourseGroup.Location = new Point(515, 9);
            ButtonCourseGroup.Margin = new Padding(3, 4, 3, 4);
            ButtonCourseGroup.Name = "ButtonCourseGroup";
            ButtonCourseGroup.Size = new Size(119, 119);
            ButtonCourseGroup.TabIndex = 4;
            ButtonCourseGroup.Text = "گروه درسی";
            ButtonCourseGroup.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonCourseGroup.UseVisualStyleBackColor = true;
            ButtonCourseGroup.Click += ButtonCourseGroup_Click;
            // 
            // ButtonCourse
            // 
            ButtonCourse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCourse.Image = Properties.Resources.emblem_library;
            ButtonCourse.Location = new Point(390, 8);
            ButtonCourse.Margin = new Padding(3, 4, 3, 4);
            ButtonCourse.Name = "ButtonCourse";
            ButtonCourse.Size = new Size(119, 119);
            ButtonCourse.TabIndex = 3;
            ButtonCourse.Text = "درس";
            ButtonCourse.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonCourse.UseVisualStyleBackColor = true;
            ButtonCourse.Click += ButtonCourse_Click;
            // 
            // ButtonTeacher
            // 
            ButtonTeacher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonTeacher.Image = Properties.Resources.Teacher_icon;
            ButtonTeacher.Location = new Point(265, 7);
            ButtonTeacher.Margin = new Padding(3, 4, 3, 4);
            ButtonTeacher.Name = "ButtonTeacher";
            ButtonTeacher.Size = new Size(119, 119);
            ButtonTeacher.TabIndex = 2;
            ButtonTeacher.Text = "استاد";
            ButtonTeacher.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonTeacher.UseVisualStyleBackColor = true;
            ButtonTeacher.Click += ButtonTeacher_Click;
            // 
            // ButtonStudent
            // 
            ButtonStudent.Image = Properties.Resources.Graduate_female_icon;
            ButtonStudent.Location = new Point(139, 9);
            ButtonStudent.Margin = new Padding(3, 4, 3, 4);
            ButtonStudent.Name = "ButtonStudent";
            ButtonStudent.Size = new Size(119, 119);
            ButtonStudent.TabIndex = 1;
            ButtonStudent.Text = "دانش آموز";
            ButtonStudent.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonStudent.UseVisualStyleBackColor = true;
            ButtonStudent.Click += ButtonStudent_Click;
            // 
            // ButtonDegree
            // 
            ButtonDegree.Image = Properties.Resources.degree_folded_icon;
            ButtonDegree.Location = new Point(13, 9);
            ButtonDegree.Margin = new Padding(3, 4, 3, 4);
            ButtonDegree.Name = "ButtonDegree";
            ButtonDegree.Size = new Size(119, 119);
            ButtonDegree.TabIndex = 0;
            ButtonDegree.Text = "مدرک";
            ButtonDegree.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonDegree.UseVisualStyleBackColor = true;
            ButtonDegree.Click += ButtonDegree_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._0__44_;
            pictureBox1.Location = new Point(0, 197);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(883, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 435);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
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
        private Button ButtonCourse;
        private Button ButtonCourseGroup;
        private Button ButtonCourseSelect;
    }
}
