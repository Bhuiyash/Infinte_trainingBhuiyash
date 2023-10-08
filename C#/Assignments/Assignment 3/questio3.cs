using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3
{
    class questio3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("kindly input two strings/words:");
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            string result = (s.Equals(s1)) ? "they are equal" : "they are not equal";
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
