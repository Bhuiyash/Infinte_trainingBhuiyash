using CaseStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Case_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Student Management System)");
            App app = new App();
            app.showFirstScreen();
            Console.ReadLine();
        }
    }
}
