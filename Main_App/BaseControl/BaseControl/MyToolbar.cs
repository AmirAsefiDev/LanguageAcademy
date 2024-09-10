namespace BaseControl
{

    public partial class MyToolbar : UserControl
    {
        public delegate void Btn_Click();
        public event Btn_Click Btn_OK;
        public event Btn_Click Btn_Cancel;
        public event Btn_Click Btn_New;
        public event Btn_Click Btn_Edit;
        public event Btn_Click Btn_Delete;

        public Boolean ActionMode_NewOrEdit;
        public int ActiveRecord;

        public MyToolbar()
        {
            InitializeComponent();
        }

        private void MyToolbar_Load(object sender, EventArgs e)
        {
            SetActionMode(true);
        }

        public void SetActionMode(bool state)
        {
            PanelAction.Visible = !state;
            PanelButton.Visible = state;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            SetActionMode(false);
            Btn_New();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SetActionMode(false);
            Btn_Edit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Btn_Delete();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Btn_OK();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetActionMode(true);
            Btn_Cancel();
        }
    }
}
