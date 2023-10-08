using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter shape type :");
            string shapeType = Console.ReadLine();
            IShape cc = ShapeFactory.GetShape(shapeType);
            if(cc!=null)
            {
                Console.WriteLine("Shape Type : {0}", cc.GetShapeType());
                Console.WriteLine("Shape Area : {0}", cc.GetShapeArea());
                Console.WriteLine("No of Shape Properties: {0}", cc.GetShapeProperties());
                Console.WriteLine("Thankyou");
            }
            else
            {
                Console.WriteLine("Invalid shape.. please give correct type");
            }
            Console.Read();
        }
    }
}
