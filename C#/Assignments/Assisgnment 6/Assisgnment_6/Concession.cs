using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class ConcessionCalculator
    {
        public const int TotalFare = 500;
        public static void CalculateConcession(int age, string name)

        {
            if (age <= 5)
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                double concessionedFare = TotalFare * 0.7;
                Console.WriteLine($"Name: {name}, Age: {age}");
                Console.WriteLine($"Senior Citizen - Fare: {concessionedFare}");
            }
            else
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare}");
            }

        }

    }

}