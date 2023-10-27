using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Course
    {
        public int course_id { get; set; }
        public string course_name { get; set; }
        public Course(int courseId, string courseName)
        {
            this.course_id = courseId;
            this.course_name = courseName;
        }
    }
    public class Enroll
    {
        private Student enrollStudent;
        private Course enrollCourse;
       
        public Enroll(Student stud, Course course)
        {
            this.enrollStudent = stud;
            this.enrollCourse = course;
        }
    }
    
}