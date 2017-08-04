using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects.Classes
{
    public class Octagon : IShapes
    {
        public const string _shapeName = "Octagon";
        public const int _sidesOfShapes = 8;

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
