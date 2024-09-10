namespace Main_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ActiveUser.UserName;
            toolStripStatusLabel4.Text = DateTime.Now.ToShortTimeString();
        }
        private void ButtonStudentManage_Click(object sender, EventArgs e)
        {
            Wfa_ZabanSara.Form1 form1 = new Wfa_ZabanSara.Form1();
            form1.StrFormName = "مدیریت دانش آموزان";
            form1.ShowDialog();
        }

        private void ButtonFinancial_Click(object sender, EventArgs e)
        {
            Wfa_FinancialSystem.FrmMain frmMain = new Wfa_FinancialSystem.FrmMain();
            frmMain.StrFormName = "امور مالی";
            frmMain.ShowDialog();
        }

        private void ButtonUsersManage_Click(object sender, EventArgs e)
        {
            Wfa_UserAccount.Forms.FrmMain frmMain = new Wfa_UserAccount.Forms.FrmMain();
            frmMain.StrFormName = "مدیریت کاربران";
            frmMain.ShowDialog();
        }



        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
