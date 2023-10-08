using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle : IShape
    {
        public int length;
        public int breadth;
       public double GetShapeArea()
        {
            Console.WriteLine("Enter length of the reactangle: ");
             length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of the reactangle: ");
             breadth = Convert.ToInt32(Console.ReadLine());
            return length * breadth;
        }
        public int GetShapeProperties()
        {
            Console.WriteLine($"Length: {length} ");
            Console.WriteLine($"Breadth: {breadth} ");
            return 2;
        }
        public string GetShapeType()
        {
            return "Rectangle Shape";
        }
    }




}

