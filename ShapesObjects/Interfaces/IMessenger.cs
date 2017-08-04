using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects.Interfaces
{
    public interface IMessenger
    {
        void WriteMessage(IShapes shape);
    }
}
