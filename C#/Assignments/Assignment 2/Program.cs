using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Assignment 2 solutions by Bhuiyash kumar
namespace Assignment2Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter the array of 5 elements");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter value");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            foreach (int x in arr)
            {
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
                sum += x;
            }
            Console.WriteLine("average of the array elements: " + (sum / arr.Length));
            Console.WriteLine($"Max value is:{max} ");
            Console.WriteLine($"Min value is: {min}");
            Console.ReadLine();
        }
    }

    class secondProgram
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            Console.WriteLine("input 10 marks of student.");
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter mark");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int total = 0;
            foreach (int x in arr)
            {
                total += x;
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
            }
            Console.WriteLine("array in ascen order");
            Array.Sort(arr);
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
            Array.Reverse(arr);
            Console.WriteLine("array in desc order");
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }


        }

    }
}
