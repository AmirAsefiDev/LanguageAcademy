using Wfa_ZabanSara.Forms;

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

        private void ButtonTeacher_Click(object sender, EventArgs e)
        {
            Forms.TeacherForm TeacherForm = new();
            TeacherForm.StrFormName = "فرم استاد";
            TeacherForm.ShowDialog();
        }

        private void ButtonCourse_Click(object sender, EventArgs e)
        {
            CourseForm course = new();
            course.StrFormName = "فرم درس";
            course.ShowDialog();
        }

        private void ButtonCourseGroup_Click(object sender, EventArgs e)
        {
            CourseGroupForm courseForm = new CourseGroupForm();
            courseForm.StrFormName = "فرم گروه درسی";
            courseForm.ShowDialog();
        }

        private void ButtonCourseSelect_Click(object sender, EventArgs e)
        {
            CourseSelectForm courseSelectForm = new();
            courseSelectForm.StrFormName = "فرم انتخاب واحد";
            courseSelectForm.ShowDialog();
        }
    }
}
