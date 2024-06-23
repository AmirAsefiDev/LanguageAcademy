namespace BaseControl
{
    partial class DateTimePicker
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
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            CurrentCalendarLabel = new Label();
            LastYearButton = new Button();
            LastMonthButton = new Button();
            NextMonthButton = new Button();
            NextYearButton = new Button();
            BottomPanel = new Panel();
            GotoTodayButton = new Button();
            GotoSelectedDateButton = new Button();
            SelectedDatelabel = new Label();
            CalendarDataGridView = new DataGridView();
            Day1Column = new DataGridViewTextBoxColumn();
            Day2Column = new DataGridViewTextBoxColumn();
            Day3Column = new DataGridViewTextBoxColumn();
            Day4Column = new DataGridViewTextBoxColumn();
            Day5Column = new DataGridViewTextBoxColumn();
            Day6Column = new DataGridViewTextBoxColumn();
            Day7Column = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CalendarDataGridView).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gainsboro;
            TopPanel.BorderStyle = BorderStyle.FixedSingle;
            TopPanel.Controls.Add(CurrentCalendarLabel);
            TopPanel.Controls.Add(LastYearButton);
            TopPanel.Controls.Add(LastMonthButton);
            TopPanel.Controls.Add(NextMonthButton);
            TopPanel.Controls.Add(NextYearButton);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(320, 45);
            TopPanel.TabIndex = 0;
            // 
            // CurrentCalendarLabel
            // 
            CurrentCalendarLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CurrentCalendarLabel.Location = new Point(132, 8);
            CurrentCalendarLabel.Name = "CurrentCalendarLabel";
            CurrentCalendarLabel.Size = new Size(51, 26);
            CurrentCalendarLabel.TabIndex = 4;
            CurrentCalendarLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LastYearButton
            // 
            LastYearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LastYearButton.Location = new Point(252, 10);
            LastYearButton.Name = "LastYearButton";
            LastYearButton.Size = new Size(60, 23);
            LastYearButton.TabIndex = 3;
            LastYearButton.Text = "سال قبل";
            LastYearButton.UseVisualStyleBackColor = true;
            LastYearButton.Click += LastYearButton_Click;
            // 
            // LastMonthButton
            // 
            LastMonthButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LastMonthButton.Location = new Point(189, 10);
            LastMonthButton.Name = "LastMonthButton";
            LastMonthButton.Size = new Size(60, 23);
            LastMonthButton.TabIndex = 2;
            LastMonthButton.Text = "ماه قبل";
            LastMonthButton.UseVisualStyleBackColor = true;
            LastMonthButton.Click += LastMonthButton_Click;
            // 
            // NextMonthButton
            // 
            NextMonthButton.Location = new Point(66, 10);
            NextMonthButton.Name = "NextMonthButton";
            NextMonthButton.Size = new Size(60, 23);
            NextMonthButton.TabIndex = 1;
            NextMonthButton.Text = "ماه بعد";
            NextMonthButton.UseVisualStyleBackColor = true;
            NextMonthButton.Click += NextMonthButton_Click;
            // 
            // NextYearButton
            // 
            NextYearButton.Location = new Point(4, 10);
            NextYearButton.Name = "NextYearButton";
            NextYearButton.Size = new Size(60, 23);
            NextYearButton.TabIndex = 0;
            NextYearButton.Text = "سال بعد";
            NextYearButton.UseVisualStyleBackColor = true;
            NextYearButton.Click += NextYearButton_Click;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.Gainsboro;
            BottomPanel.BorderStyle = BorderStyle.FixedSingle;
            BottomPanel.Controls.Add(GotoTodayButton);
            BottomPanel.Controls.Add(GotoSelectedDateButton);
            BottomPanel.Controls.Add(SelectedDatelabel);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 251);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(320, 49);
            BottomPanel.TabIndex = 1;
            // 
            // GotoTodayButton
            // 
            GotoTodayButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GotoTodayButton.Location = new Point(232, 11);
            GotoTodayButton.Name = "GotoTodayButton";
            GotoTodayButton.Size = new Size(75, 23);
            GotoTodayButton.TabIndex = 7;
            GotoTodayButton.Text = "تاریخ امروز";
            GotoTodayButton.UseVisualStyleBackColor = true;
            GotoTodayButton.Click += GotoTodayButton_Click;
            // 
            // GotoSelectedDateButton
            // 
            GotoSelectedDateButton.Location = new Point(13, 11);
            GotoSelectedDateButton.Name = "GotoSelectedDateButton";
            GotoSelectedDateButton.Size = new Size(75, 23);
            GotoSelectedDateButton.TabIndex = 6;
            GotoSelectedDateButton.Text = "تاریخ انتخابی";
            GotoSelectedDateButton.UseVisualStyleBackColor = true;
            GotoSelectedDateButton.Click += GotoSelectedDateButton_Click;
            // 
            // SelectedDatelabel
            // 
            SelectedDatelabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedDatelabel.Location = new Point(126, 10);
            SelectedDatelabel.Name = "SelectedDatelabel";
            SelectedDatelabel.Size = new Size(71, 26);
            SelectedDatelabel.TabIndex = 5;
            SelectedDatelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalendarDataGridView
            // 
            CalendarDataGridView.AllowUserToAddRows = false;
            CalendarDataGridView.AllowUserToDeleteRows = false;
            CalendarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CalendarDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CalendarDataGridView.Columns.AddRange(new DataGridViewColumn[] { Day1Column, Day2Column, Day3Column, Day4Column, Day5Column, Day6Column, Day7Column });
            CalendarDataGridView.Dock = DockStyle.Fill;
            CalendarDataGridView.Location = new Point(0, 45);
            CalendarDataGridView.MultiSelect = false;
            CalendarDataGridView.Name = "CalendarDataGridView";
            CalendarDataGridView.ReadOnly = true;
            CalendarDataGridView.RowHeadersVisible = false;
            CalendarDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CalendarDataGridView.Size = new Size(320, 206);
            CalendarDataGridView.TabIndex = 2;
            // 
            // Day1Column
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day1Column.DefaultCellStyle = dataGridViewCellStyle15;
            Day1Column.HeaderText = "ش";
            Day1Column.Name = "Day1Column";
            Day1Column.ReadOnly = true;
            // 
            // Day2Column
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day2Column.DefaultCellStyle = dataGridViewCellStyle16;
            Day2Column.HeaderText = "ی";
            Day2Column.Name = "Day2Column";
            Day2Column.ReadOnly = true;
            // 
            // Day3Column
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day3Column.DefaultCellStyle = dataGridViewCellStyle17;
            Day3Column.HeaderText = "د";
            Day3Column.Name = "Day3Column";
            Day3Column.ReadOnly = true;
            // 
            // Day4Column
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day4Column.DefaultCellStyle = dataGridViewCellStyle18;
            Day4Column.HeaderText = "س";
            Day4Column.Name = "Day4Column";
            Day4Column.ReadOnly = true;
            // 
            // Day5Column
            // 
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day5Column.DefaultCellStyle = dataGridViewCellStyle19;
            Day5Column.HeaderText = "چ";
            Day5Column.Name = "Day5Column";
            Day5Column.ReadOnly = true;
            // 
            // Day6Column
            // 
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day6Column.DefaultCellStyle = dataGridViewCellStyle20;
            Day6Column.HeaderText = "پ";
            Day6Column.Name = "Day6Column";
            Day6Column.ReadOnly = true;
            // 
            // Day7Column
            // 
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Day7Column.DefaultCellStyle = dataGridViewCellStyle21;
            Day7Column.HeaderText = "ج";
            Day7Column.Name = "Day7Column";
            Day7Column.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CalendarDataGridView);
            Controls.Add(BottomPanel);
            Controls.Add(TopPanel);
            Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "DateTimePicker";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(320, 300);
            Load += DateTimePicker_Load;
            TopPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CalendarDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView CalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7Column;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button LastYearButton;
        private System.Windows.Forms.Button LastMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Label CurrentCalendarLabel;
        private System.Windows.Forms.Label SelectedDatelabel;
        private System.Windows.Forms.Button GotoTodayButton;
        private System.Windows.Forms.Button GotoSelectedDateButton;
    }
}
