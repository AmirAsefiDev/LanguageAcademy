using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace winprint
{
    public partial class PrintOptions : Form
    {
      
        public static Boolean report_flag;
        public PrintOptions()
        {
            InitializeComponent();

        }
        public PrintOptions(List<string> availableFields)
        {
            InitializeComponent();

            foreach (string field in availableFields)
                chklst.Items.Add(field, true);
        }

        private void PrintOptions_Load(object sender, EventArgs e)
        {
            rdoAllRows.Checked = true;            //فعال کردن همه ستون ها برای چاپ
            chkFitToPageWidth.Checked = true; //چاپ تمام عرض
            r_portrait.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public List<string> GetSelectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
                        return lst;
        }
        public string PrintTitle
        {
            get { return txtTitle.Text; }
        }

        public bool PrintAllRows
        {
            get { return rdoAllRows.Checked; }
        }

        public bool FitToPageWidth
        {
            get { return chkFitToPageWidth.Checked; }
        }

        private void rdoSelectedRows_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void r_portrait_CheckedChanged(object sender, EventArgs e)
        {
            pic_landscape.Visible = false;
            pic_portrait.Visible = true;
            report_flag = true;
        }

        private void r_landscape_CheckedChanged(object sender, EventArgs e)
        {
            pic_landscape.Visible = true;
            pic_portrait.Visible = false;
            report_flag = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrintDGV.AddWidth = -trackBar1.Value;
            MorOptionPrint Op = new MorOptionPrint();
            Op.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
