using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3
{
    class question2solution
    {
        static void Main(string[] args)
        {Console.WriteLine("kindly input a string/word:");
            string s = Console.ReadLine();
            string rev = "";
            char[] c = s.ToCharArray();
            for(int i = s.Length-1; i >=0; i--)
            {
                rev = rev + c[i];
            }
            Console.WriteLine("the reverse of your String : " + rev);
            Console.ReadLine();
    } 
    }
}
