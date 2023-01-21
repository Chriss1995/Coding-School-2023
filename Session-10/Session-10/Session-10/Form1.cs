using UniversityLib;

namespace Session_10
{
    public partial class Form1 : Form
    {
        List<Student> students;
        List<Course> courses;
        List<Grade> grades;
        List<Schedule> Schedules;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(Object sender, EventArgs e)
        {
            PopulateStudent();
            GetCourses();
            University university = new University()
            {
                name = "University of Aegean"
            };
            university.students.Add(students);
        }
        public void PopulateStudent()
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
        private void GetCourses()
        {
            courses = new List<Course>();
            Course course1 = new Course()
            {
                Code = "Geo101",
                Subject = "Introduction to Geology"

            };
            courses.Add(course1);
            Course course2 = new Course()
            {
                Code = "Math011",
                Subject = "Introduction to Maths"
            };
            courses.Add(course2);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(university, "test.json");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           Serializer serializer = new Serializer();
            university = serializer.Deserialize<University>("test.json");

        }

        private void grvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}