using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects
{
    public class Pentagon : IShapes
    {
        public string ShapeName { get; set; }
        private int sidesOfShapes = 5;

        public string SidesOfShape()
        {
            return ShapeName + " has " + sidesOfShapes.ToString() + " sides.";
        }
    }
}
