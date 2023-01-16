using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Professor : Person
    {
        public string? Rank { get; set; }
        public Course[]? Courses { get; set; }
        public Professor() { }
        public void Teach(Course course, DateTime Datetime) { }
        public void SetGrade(Guid StudentID, Guid GradeID, int grade) { }
        public void GetName() { }

    }
}
