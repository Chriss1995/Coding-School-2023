using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class University : Institute
    {public Student[]? Student { get; set; }
     public Course[]? Course { get; set; }
     public Grade[]? Grades { get; set; }
    public Schedule[]? ScheduledCourse { get; set; }
    public University() { }
    public void GetStudents() { }
    public void GetCourses() { }
     public void GetGrades() { }
     public void SetSchedule(Course CourseID, Professor ProffessorID, DateTime dateTime) { }

    }
}
