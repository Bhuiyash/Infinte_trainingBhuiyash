using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType)
        {
            IShape Icc = null;
            if (shapeType == "Triangle")
            {
                Icc = new Triangle();
            }
            else if (shapeType == "Rectangle")
            {
                Icc = new Rectangle();
            }
            else if (shapeType == "Circle")
            {
                Icc = new Circle();
            }
            return Icc;
        }
    }
}
