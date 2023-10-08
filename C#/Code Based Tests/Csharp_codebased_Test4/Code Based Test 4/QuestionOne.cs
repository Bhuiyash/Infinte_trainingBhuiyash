using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Solution 1 Bhuiyash Kumar 3 October 2023
namespace Code_Based_Test_4
{
    class QuestionOne
    {
        static void Main()
        {
            string filePath = "C:\\Users\\bhuiyashk\\OneDrive - Infinite Computer Solutions (India) Limited\\desktop\\sample.txt";
            Console.WriteLine("Enter text to append to the file to the desktop: ");
            string textToAppend = Console.ReadLine();
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {

                    writer.WriteLine(textToAppend);
                }
                Console.WriteLine("Text appended to the file successfully. Have a good day!");
            }
            catch (Exception error)
            {
                Console.WriteLine("An error has occurred: " + error.Message);
            }
            Console.ReadLine();
        }
    }
}