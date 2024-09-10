using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfa_ZabanSara.Forms
{
    public partial class frmMsg : MasterForm.frmMaster
    {
        public int ButtonCount=1;
        public frmMsg()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMsg_Load(object sender, EventArgs e)
        {
            labelMsg.Left = this.Width / 2 - labelMsg.Width / 2;

            if (ButtonCount==1)
            {
                ButtonCancel.Visible = false;
                ButtonOk.Left = this.Width / 2 - ButtonOk.Width /2;
            }

        }
    }
}
