using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//                                        Assignment 1 soulutions..by Bhuiyash Kumar
namespace trainingDay1Infinte
{
    class firstProgram
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter two numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n == n1)
            {
                Console.WriteLine("they are equal");
            }
            else
            {
                Console.WriteLine("they are not equal");
            }
            Console.ReadKey();
        }
    }
    class SecondProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >=0)
            { 
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative...");
            }
            Console.ReadLine();
        
        }
    }
    class thirdProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input 1 for addition 2 for product, 3 for division and 4 so substraction... ");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    int sumation = sum(a, b); Console.WriteLine($"sum is:{sumation} "); Console.ReadLine();
                    break;
                case 2:
                    int prod = product(a, b); Console.WriteLine($"product is:{prod} "); Console.ReadLine();
                    break;
                case 3:
                    int div = division(a, b); Console.WriteLine($"division is:{div} "); Console.ReadLine();
                    break;
                case 4:
                    int diff = difference(a, b); Console.WriteLine($"difference is:{diff} "); Console.ReadLine();
                    break;

            }

        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static int product(int a, int b)
        {
            return a * b;
        }
        static int division(int a, int b)
        {
            return a / b;
        }
        static int difference(int a, int b)
        {
            return a - b;
        }
    }
}
