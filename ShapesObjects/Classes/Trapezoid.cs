using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects.Classes
{
    public class Trapezoid : IShapes
    {
        public const string _shapeName = "Trapezoid";
        public const int _sidesOfShapes = 4;

        public string ShapeName
        {
            get
            {
                return _shapeName;
            }
        }

        public int SidesOfShape
        {
            get
            {
                return _sidesOfShapes;
            }
        }
    }
}
