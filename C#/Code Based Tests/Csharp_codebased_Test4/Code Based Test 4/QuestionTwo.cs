using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Solution 2
namespace Code_Based_Test_4
{
    public delegate int CalculatorDelegate(int num1, int num2);
    class QuestionTwo
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            CalculatorDelegate addDelegate = new CalculatorDelegate(Add);
            CalculatorDelegate subtractDelegate = new CalculatorDelegate(Subtract);
            CalculatorDelegate multiplyDelegate = new CalculatorDelegate(Multiply);
            int resultAddition = addDelegate(num1, num2);
            int resultSubtraction = subtractDelegate(num1, num2);
            int resultMultiplication = multiplyDelegate(num1, num2);
            Console.WriteLine($"Addition: {resultAddition}");
            Console.WriteLine($"Subtraction: {resultSubtraction}");
            Console.WriteLine($"Multiplication: {resultMultiplication}");
            Console.ReadLine();
        }
    }
}
