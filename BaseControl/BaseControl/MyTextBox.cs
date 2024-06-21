using System;
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
    public partial class MyTextBox : UserControl
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        private bool _isNumber;
        private bool _isReal;
        public bool IsReal
        {
            get { return _isReal; }
            set { _isReal = value; }
        }
        public bool IsNumber
        {
            get { return _isNumber; }
            set { _isNumber = value; }

        }

        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public object Tag
        {
            get { return textBox1.Tag; }
            set { textBox1.Tag = value; }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGreen;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumber)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
            if (IsReal)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                    e.Handled = true;
            }
        }

        private void MyTextBox_Load(object sender, EventArgs e)
        {

        }

        private void MyTextBox_Resize(object sender, EventArgs e)
        {
            this.Width = textBox1.Width;
            this.Height = textBox1.Height;
        }

        private void MyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
