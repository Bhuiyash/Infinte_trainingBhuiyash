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
    //class Scenarios
    //{
    //    public static void Scenario1()
    //    {
    //        Student studentOne = new Student(101, "Bhuiyash", DateTime.Parse("2002-01-20"));
    //        Student studentTwo = new Student(102, "Prakhar", DateTime.Parse("2001-04-24"));
    //        Student studentThree = new Student(103, "Pranjal", DateTime.Parse("2002-09-13"));
    //        Info.DisplayOne(studentOne);
    //        Info.DisplayOne(studentTwo);
    //        Info.DisplayOne(studentThree);
    //    }
    //    public static void Scenario2()
    //    {
    //        Student[] student_array = new Student[2];
    //        student_array[0] = new Student(104, "Shoaib", new DateTime(2002, 11, 25));
    //        student_array[1] = new Student(105, "Abhinay", new DateTime(2001, 12, 21));
    //        foreach (Student student in student_array)
    //        {
    //            Info.DisplayOne(student);
    //        }
    //    }
    //}
}
