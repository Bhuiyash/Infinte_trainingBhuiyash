using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_6
{
    class Program

    {

        static void Main(string[] args)

        { 
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");

            int age = int.Parse(Console.ReadLine());
            Concession.ConcessionCalculator.CalculateConcession(age, name);
            Console.ReadLine();

        }
    }
}
