using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace UniversityLib
{
    public class University
    {
        public Guid ID { get; set; }
        public string? name { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }
        public University() { ID = Guid.NewGuid(); }
        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Course CourseID, Professor ProffessorID, DateTime dateTime) { }

    }
    public class Student
    {
       public Guid ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }
        public Student() { ID = Guid.NewGuid(); }
        public void Attend(Course course, DateTime datetime) { }
        public void WriteExam(Course course, DateTime datetime) { }

    }
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int grades { get; set; }
        public Grade() { }
        public Grade(Guid id)
        {
            ID = Guid.NewGuid();
        }
    }
    public class Course
    {
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }
        public Course() { }
        public Course(Guid id)
        {
            ID= Guid.NewGuid();
        }
    }
    public class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProffessorID { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule() { }
        public Schedule(Guid id) { ID = Guid.NewGuid(); }
    }
    public class Professor
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string? Rank { get; set; }
        public List<Course> Courses { get; set; }
        public Professor() { ID = Guid.NewGuid(); }
        public void Teach(Course course, DateTime Datetime) { }
        public void SetGrade(Guid StudentID, Guid GradeID, int grade) { }
        public void GetName() { }

    }
}