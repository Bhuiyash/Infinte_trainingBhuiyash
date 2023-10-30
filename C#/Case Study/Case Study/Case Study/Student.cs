using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
   public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public DateTime studentDob { get; set; }
        public Student(int id, string name, DateTime dateOfBirth)
        {
            studentId = id;
            studentName = name;
            studentDob = dateOfBirth;
        }
    }
    class Info
    {
        public static void DisplayOne(Student student)
        {
            Console.WriteLine($"Student ID : {student.studentId} Student Name : {student.studentName}" +
                $"\nStudent Date of birth : {student.studentDob}");
        }
        public static void DisplayTwo(Course course)
        {
            Console.WriteLine($"Course ID : {course.course_id} Course Name : {course.course_name}");
        }
    }
   
}
