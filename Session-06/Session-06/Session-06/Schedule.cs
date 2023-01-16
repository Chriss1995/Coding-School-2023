using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProffessorID { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule() { }
        public Schedule(Guid id) { ID = id; }
        public Schedule(Guid id, Guid courseID)
        {
            ID = id;
            CourseID = courseID;
        }
        public Schedule(Guid  id, Guid courseID, Guid proffessorID)
        {
            ID = id;
            CourseID = courseID;
            ProffessorID = proffessorID;

        }
        public Schedule(
            Guid id,  Guid courseID, Guid proffessorID, DateTime callendar)
        {
            ID = id;
            CourseID = courseID;
            ProffessorID = proffessorID;
            Callendar = Callendar;

        }
    }

}
