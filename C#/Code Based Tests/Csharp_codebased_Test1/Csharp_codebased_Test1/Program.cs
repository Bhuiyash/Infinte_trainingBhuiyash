using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_codebased_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a String");
            string s = Console.ReadLine();
            int l = s.Length;
            Console.WriteLine($"input index value less than {l} to remove the character.");
            
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <l && n >= 0) {
                Console.WriteLine("the result: ");
                Console.WriteLine(s.Remove(n, 1));
              
            }
            else
            {
                Console.WriteLine("wrong input given, try again...!!");
                
            }
            Console.ReadKey();
            
        }
    }
}
