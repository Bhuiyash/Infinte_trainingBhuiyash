using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IShape
    {
        double GetShapeArea();
    
        string GetShapeType(); 
        int GetShapeProperties();
    }
}