using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects
{
    public interface IShapes
    {
        string ShapeName { get; set; }
        string SidesOfShape();
    }
}
