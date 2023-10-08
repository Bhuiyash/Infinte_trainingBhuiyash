using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 2. Write a class Box that has Length and breadth as its members. 
Write a function that adds 2 box objects and stores in the 3rd. 
Display the 3rd object details. Create a Test class to execute the above.
25 mts.
 */
namespace CodeBasedTest3
{

    class Box
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public Box(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public Box Add(Box otherBox )
        {
            int finalLength = this.length + otherBox.length;
            int finalBreadth = this.breadth + otherBox.breadth;
            return new Box(finalLength, finalLength);
        }
        public void showDetails()
        {
            Console.WriteLine($"the length of box is: {length}");
            Console.WriteLine($"the breadth of box is: {breadth}");
        }
    }
    class Question2//testing the above class
    {
        static void Main(string[] args)
        {
            //accepting dimension of first box
            Console.WriteLine("enter the length of the 1st box: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth of the 1st box: ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            //accepting dimension of second box
            Console.WriteLine("enter the length of the 2nd box: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth of the 2nd box: ");
            int breadth2 = Convert.ToInt32(Console.ReadLine());

            //creating objects.
            Box box1 = new Box(length, breadth);
            Box box2 = new Box(length2, breadth2);

            Box box3 = box1.Add(box2);//adding two objects into box3

            box3.showDetails();
            Console.ReadLine();
        }
    }
}
