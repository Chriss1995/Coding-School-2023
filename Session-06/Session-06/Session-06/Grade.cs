﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int grades { get; set; }
        public Grade() { }
        public Grade(Guid id)
        {
            ID = id;
        }
        public Grade(Guid id, Guid studentID)
        {
            ID = id;
            StudentID = studentID;
        }
        public Grade(Guid id, Guid studentID, Guid courseID)
        {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
        }
        public Grade(Guid id, Guid studentID, Guid courseID, int grade)
        {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
            grades = grade;
        }

    }

}
