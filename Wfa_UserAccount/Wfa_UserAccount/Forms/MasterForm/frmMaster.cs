using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfa_UserAccount.Forms.MasterForm
{
    public partial class frmMaster : Form
    {
        public string StrFormName = "فرم اصلی";
        public frmMaster()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            labFormName.Text = StrFormName;
            picExit.Left = panelMaster.Width - picExit.Width;
            labFormName.Left = panelMaster.Width / 2 - labFormName.Width / 2;
        }
    }
}
