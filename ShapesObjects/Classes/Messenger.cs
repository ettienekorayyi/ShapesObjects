using ShapesObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects.Classes
{
    public class Messenger : IMessenger
    {
        public void SumOfSides(int number)
        {
            Console.WriteLine("Total number of sides is " + number.ToString());
        }

        public void ShapeDescription(IShapes shape)
        {
            if (shape == null)
                Console.WriteLine("Undefined Shape");

            if (shape != null)
                Console.WriteLine(shape.ShapeName + " has " + shape.SidesOfShape.ToString() + " sides.");
        }
    }
}
