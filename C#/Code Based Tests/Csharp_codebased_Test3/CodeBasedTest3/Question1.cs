using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Code based 3 Bhuiyash Kumar
 1. Write a program to find the Sum and the Average points scored by the teams in the IPL. 
Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that takes no.of matches 
as input and accepts that many scores from the user. The function should then display the Average and Sum of the scores.
35 mts

 */
namespace CodeBasedTest3
{
    class Cricket
    {
        public void PointsCalculation(int no_of_matches)
        {
            List<int> scores = new List<int>();
            for(int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine($"Enter Score for match");
                int s = Convert.ToInt32(Console.ReadLine());
                scores.Add(s);
            }
            int totalScore = 0;
            double avgScore = 0.0;
            foreach(int x in scores)
            {
                totalScore += x;
            }
            avgScore = totalScore / no_of_matches;
            Console.WriteLine($"Total Score is:{totalScore} ");
            Console.WriteLine($"Average score is: {avgScore}");
        }
    }
    class Question1
    {
        static void Main(string[] args)
        {
            Cricket obj = new Cricket();
            Console.WriteLine("Enter the number of matches: ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());
            obj.PointsCalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}
