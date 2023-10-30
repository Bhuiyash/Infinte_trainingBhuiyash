using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Case_Study
{
    public class AppEngine
    {
        public void Introduce(Course course)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Course Introduced");
            Console.WriteLine("*****************");
            string connectionString = "Data Source=ICS-LT-3DWY693;Initial Catalog=CaseStudyProject;" + "Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string courseInsertQuery = "Insert into courses values (@course_id,@course_name)";
                using (SqlCommand cmd = new SqlCommand(courseInsertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@course_id", course.course_id);
                    cmd.Parameters.AddWithValue("@course_name", course.course_name);
                    cmd.ExecuteNonQuery();
                }


            }




            Console.WriteLine($"Course ID: {course.course_id}\nCourse Name: {course.course_name}");
        }

        public void ListofCourses()
        {
            List<Course> courses = LoadCoursesFromDatabase();
            foreach (var course in courses)
            {
                Info.DisplayTwo(course);
            }
        }

        public List<Course> LoadCoursesFromDatabase()
        {
            List<Course> courses = new List<Course>();

            string connectionString = "Data Source=ICS-LT-3DWY693;Initial Catalog=CaseStudyProject;" + "Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Courses";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int courseId = reader.GetInt32(0);
                            string courseName = reader.GetString(1);

                            courses.Add(new Course(courseId, courseName));
                        }
                    }
                }
            }

            return courses;
        }


        public void ListOfStudents()
        {
            List<Student> students = LoadStudentsFromDatabase();
            foreach (var student in students)
            {
                Info.DisplayOne(student);
            }

        }
        public List<Student> LoadStudentsFromDatabase()
        {

            List<Student> students = new List<Student>();
            try
            {
                string connectionString = "Data Source=ICS-LT-3DWY693;Initial Catalog=CaseStudyProject;" + "Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Students";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int student_id = reader.GetInt32(0);
                                string studentName = reader.GetString(1);
                                DateTime dob = reader.GetDateTime(2);


                                students.Add(new Student(student_id, studentName, dob));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return students;
        }


        public void InsertEnrollmentIntoDatabase(Student student, Course course, DateTime enrollmentDate)
        {
            try
            {
                string connectionString = "Data Source=ICS-LT-3DWY693;Initial Catalog=CaseStudyProject;" + "Integrated Security=True"; // Replace with your actual database connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("Student enrollment in course");
                    Console.WriteLine($"Student ID: {student.studentId}\nStudent Name: {student.studentName}" +
                        $"\nStudent Date Of Birth: {student.studentDob}" +
                        $"\nCourse ID: {course.course_id}\nCourse Name: {course.course_name}" +
                        $"\nEnrollment Date: {dateTime}");
                    //student enrollment
                    string studentInsertQuery = "Insert into Students values (@student_id,@student_name,@student_dob)";
                    using (SqlCommand cmd = new SqlCommand(studentInsertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@student_id", student.studentId);
                        cmd.Parameters.AddWithValue("@student_name", student.studentName);
                        cmd.Parameters.AddWithValue("@student_dob", student.studentDob);
                        cmd.ExecuteNonQuery();
                    }

                    //enrollments insertion
                    string insertQuery = "INSERT INTO Enrollments (student_id, course_id, enrollment_date) " +
                                        "VALUES (@StudentId, @CourseId, @EnrollmentDate)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", student.studentId);
                        cmd.Parameters.AddWithValue("@CourseId", course.course_id);
                        cmd.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("-----Enrollment successful :)-----");
                            Console.WriteLine($"Student {student.studentName} has been enrolled in the system with course id {course.course_id}");
                        }
                        else
                        {
                            Console.WriteLine("Enrollment failed. :(");
                        }
                    }
                }

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}

