﻿using Case_Study;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
    {
        interface UserInterface
        {
            void showFirstScreen();

            void showStudentScreen();

            void showAdminScreen();

            void showAllStudentsScreen();

            void showStudentRegistrationScreen();

            void introduceNewCourseScreen();

            void showAllCoursesScreen();

        }

        public class App : UserInterface

        {
           AppEngine appengine = new AppEngine();

            public void showFirstScreen()

            {

                Console.WriteLine("Your choices : \n1.Student\n2.Admin\n3.Exit");

                Console.Write("Enter your choice (1/2/3): ");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        showStudentScreen(); break;
                    case 2:
                        showAdminScreen(); break;
                    case 3:
                    Console.WriteLine("Exited...");
                    Console.ReadLine();

                    break;
                    default:
                        Console.WriteLine("Input is Invalid \n...please enter 1 or 2 or 3");
                    showFirstScreen();
                    
                    
                    break;

                }

            }

            public void showStudentScreen()

            {

                Console.WriteLine("-------------Student Screen-------------");

                Console.WriteLine("What do you want to do?\n1.Register details\n2.Show all courses\n3.Exit \n 4.Go back to main menu");

                Console.Write("Enter your choice(1/2/3) : ");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                     case 1:

                        showStudentRegistrationScreen();
                    showStudentScreen();
                    break;

                    case 2:
                        showAllCoursesScreen();

                        showStudentScreen();

                        break;

                    case 3:
                    Console.WriteLine("press any key to close screen");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("---------------------------Main Menu----------------------------");
                    showFirstScreen();
                    break;

                    default:

                        Console.WriteLine("Invalid input"); break;

                }

            }

            public void showAdminScreen()

            {

                Console.WriteLine("---------Admin Screen----------");

                Console.WriteLine("What do you want to do?\n1.Show all students\n2.Show all courses\n3.Introduce new courses\n4.Exit\n5.Go back to main menu");
                  
                Console.Write("Enter your choice(1/2/3/4) : ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)

                {

                    case 1:

                     showAllStudentsScreen();
                    showAdminScreen(); 
                    break;

                    case 2:

                        showAllCoursesScreen();

                        showAdminScreen();

                        break;

                    case 3:

                        introduceNewCourseScreen(); break;

                    case 4:
                    Console.WriteLine("press any key to exit the console!");
                    Console.ReadLine();
                    break;
                   case 5:
                    showFirstScreen();
                    break;


                    default:
                        Console.WriteLine("Input Invalid");
                    showFirstScreen();
                    break;

                }

            }

            public void showStudentRegistrationScreen()

            {

       
                Console.WriteLine("-------------Registration------------");

                Console.Write("Enter your Name : ");

                string name = Console.ReadLine();

                Console.Write("Enter your Student ID :");

                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter your Date of Birth(yyyy-mm-dd) : ");

                DateTime dob = DateTime.Parse(Console.ReadLine());

                Student student = new Student(id, name, dob);
            Console.WriteLine("----------------List of courses-----------");

            appengine.ListofCourses();
            Console.WriteLine("----------------End of courses-----------");

            Console.Write("Enter the Course ID : ");

                int cid = int.Parse(Console.ReadLine());

                Console.Write("Enter the Course Name : ");

                string cname = Console.ReadLine();

                Course course = new Course(cid, cname);

            appengine.InsertEnrollmentIntoDatabase(student, course, DateTime.Now);
            Console.WriteLine("-------------------New List of Students--------------------------");
            appengine.ListOfStudents ();
            Console.WriteLine("---------------------End of List----------------------------------------");

            }

            public void showAllCoursesScreen()

            {

                Console.WriteLine("----------------List of courses-----------");

                appengine.ListofCourses();
            Console.WriteLine("----------------End of courses-----------");


        }
        public void showAllStudentsScreen()

            {

            Console.WriteLine("------Students list------");
            appengine.ListOfStudents();
            Console.WriteLine("------end of list--------");
            showAdminScreen();

            }
            public void introduceNewCourseScreen()
            {
            Console.WriteLine("-----------------------------------------------------------------");
                Console.Write("Enter the no. of course(s) you want to introduce : ");

                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)

                {

                    Console.Write("Enter the new Course ID : ");

                    int cid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the new Course Name : ");

                    string cname = Console.ReadLine();

                    Course course = new Course(cid, cname);

                    appengine.Introduce(course);
                }
            Console.WriteLine("--------------------------------------------------------------------------------------");
                showAdminScreen();
            }

        }
    }


    

 