using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Circle : IShape
    {
        public int radius;
        public double GetShapeArea()
        {
            Console.WriteLine("kindly enter circle's radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            return 3.14*radius*radius;
        }
        public int GetShapeProperties()
        {
          Console.WriteLine($"the radius of Circle is :{radius}");
            return 1;
        }
        public string GetShapeType()
        {
            return "Circle Shape";
        }
    }
}
