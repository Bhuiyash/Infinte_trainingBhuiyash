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
    public class AppEngine
    {
        List<Student> students = new List<Student>();
        public void Introduce(Course course)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Course Introduced");
            Console.WriteLine($"Course ID : {course.course_id}\nCourse Name : {course.course_name}");
        }
        public void ListofCourses()
        {
            List<Course> courses = new List<Course>()
            {
               new Course(1001,"Computer Science and Engineering"),new Course(1002,"Mathmatics"),new Course(1003,"Quantum Physics"),
               new Course(1004,"History and Civics"),new Course(1005,"English Language")
            };
            foreach (var course in courses)
            {
                Info.DisplayTwo(course);
            }
        }
        public void Enroll(Student student, Course course)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Student enrollment in course");
            Console.WriteLine($"Student ID : {student.studentId}\nStudent Name : {student.studentName}" +
                $"\nStudent Date Of Birth : {student.studentDob}" +
                $"\nCourse ID : {course.course_id}\nCourse Name : {course.course_name}" +
                $"\nEnrollment Date :{dateTime}");
        }
    }
}