using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Triangle : IShape
    {
        public int Base;
        public int Height;
        public double GetShapeArea()
        {
            Console.WriteLine("Kindly enter base of the triangle: ");
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kindly enter height of the triangle: ");
            Height = Convert.ToInt32(Console.ReadLine());
            return (0.5)*Base*Height;
        }
        public int GetShapeProperties()
        {
            Console.WriteLine($"Base: {Base} ");
            Console.WriteLine($"Height: {Height} ");
            return 2;
        }

        public string GetShapeType()
        {
            return "Triangle Shape";
        }
    }
}
