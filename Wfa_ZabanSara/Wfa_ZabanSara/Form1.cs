namespace Wfa_ZabanSara
{
    public partial class Form1 : Forms.MasterForm.frmMaster
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void ButtonDegree_Click(object sender, EventArgs e)
        {
            Forms.DegreeForm degreeForm = new Forms.DegreeForm();
            degreeForm.StrFormName = "فرم مدارک";
            degreeForm.ShowDialog();
        }

        private void ButtonStudent_Click(object sender, EventArgs e)
        {
            Forms.StudentForm studentForm = new Forms.StudentForm();
            studentForm.StrFormName = "فرم دانش آموز";
            studentForm.ShowDialog();
        }
    }
}
