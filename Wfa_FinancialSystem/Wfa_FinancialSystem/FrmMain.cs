using Wfa_FinancialSystem.Forms;
using Wfa_FinancialSystem.Forms.MasterForm;

namespace Wfa_FinancialSystem
{
    public partial class FrmMain : frmMaster
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StrFormName = "Form1";
        }

        private void ButtonBank_Click(object sender, EventArgs e)
        {
            FrmBank frmBank = new();
            frmBank.StrFormName = "»«‰ò Â«";
            frmBank.ShowDialog();
        }

        private void ButtonPayType_Click(object sender, EventArgs e)
        {
            FrmPayType frmPayType = new();
            frmPayType.StrFormName = "›—„ ‰Ê⁄ Å—œ«Œ ";
            frmPayType.ShowDialog();
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            FrmPayment frmPayment = new();
            frmPayment.StrFormName = "Å—œ«Œ  Â«";
            frmPayment.ShowDialog();
        }
    }
}
