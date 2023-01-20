using UniversityLib;

namespace Session_10
{
    public partial class Form1 : Form
    {
        List<Student> students;
        List<Course> courses;

        public Form1()
        {
            InitializeComponent();
        }
        private void PopulateStudent()
        {
            students = new List<Student>();
            Student student1 = new Student()
            {
                name = "Chrissanthi",
                age = 28,
                RegistrationNumber = 10050
            };
            students.Add(student1);
            Student student2 = new Student()
            {
                name = "Lydia",
                age = 18,
                RegistrationNumber = 100060
            };
            students.Add(student2);

        }





    }
}