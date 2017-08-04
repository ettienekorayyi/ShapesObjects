using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects
{
    public class Square : IShapes
    {
        public const string _shapeName = "Square";
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
