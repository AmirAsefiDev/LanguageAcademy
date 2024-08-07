﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControl
{
    public partial class Dropdown : UserControl
    {
        private Form dropdownForm;

        public event EventHandler OnValueChanged;

        public Dropdown()
        {
            InitializeComponent();
            DropDownInputMaskedEdit.TextChanged += DropDownInputMaskedEdit_TextChanged;

        }

        private void DropDownInputMaskedEdit_TextChanged(object sender, EventArgs e)
        {
            if (OnValueChanged != null)
                OnValueChanged(this,new EventArgs());
        }

        public string Value
        {
            get { return DropDownInputMaskedEdit.Text; }
            set { DropDownInputMaskedEdit.Text = value; }
        }

        public string InputMask
        {
            get { return DropDownInputMaskedEdit.Mask; }
            set { DropDownInputMaskedEdit.Mask = value; }
        }
        public Func<Control> GetDropdownControl;

        private void ShowDropdownButton_Click(object sender, EventArgs e)
        {
             dropdownForm = new Form();
            dropdownForm.FormBorderStyle = FormBorderStyle.None;
            dropdownForm.BackColor = Color.Gainsboro;
            var screenLocation = this.PointToScreen(Point.Empty);
            dropdownForm.Width = 400;
            dropdownForm.Height = 280;
            dropdownForm.ShowInTaskbar = false;
            dropdownForm.TopMost = true;
            if(GetDropdownControl != null)
            {
                var control = GetDropdownControl();
                dropdownForm.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }
            dropdownForm.Show();
            dropdownForm.Deactivate += (s, args) =>
            {
                dropdownForm.Close();
                dropdownForm = null;
            };
            screenLocation.Y += this.Height;
            screenLocation.X = screenLocation.X + (Width - dropdownForm.Width);
            dropdownForm.Location = screenLocation;

        }
        public void CloseDropdown()
        {
            if(dropdownForm != null)
                dropdownForm.Close();
        }
    }
}
