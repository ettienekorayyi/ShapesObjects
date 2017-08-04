using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects.Interfaces
{
    public interface IMessenger
    {
        void ShapeDescription(IShapes shape);
        void SumOfSides(int number);
    }
}
