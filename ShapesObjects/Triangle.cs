using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects
{
    public class Triangle : IShapes
    {
        public string ShapeName { get; set; }
        private int sidesOfShapes = 3;

        public string SidesOfShape()
        {
            return ShapeName + " has " + sidesOfShapes.ToString() + " sides.";
        }
    }
}
