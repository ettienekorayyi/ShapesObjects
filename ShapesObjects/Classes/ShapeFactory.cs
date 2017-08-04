using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects.Classes
{
    public class ShapeFactory
    {
        public IShapes CreateShape(string type)
        {
            switch (type)
            {
                case "Square": return new Square();
                case "Rectangle": return new Rectangle();
                case "Pentagon": return new Pentagon();
                case "Triangle": return new Triangle();
                default: return null;
            }
        }
    }
}
