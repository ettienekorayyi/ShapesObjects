using ShapesObjects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string selection = String.Empty;
            ShapeFactory shapeFactory = new ShapeFactory();
            List<IShapes> container = new List<IShapes>();
            int totalSides = 0;

            do
            { 
                Console.WriteLine("Enter Shape Name: ");
                IShapes shape = shapeFactory.CreateShape(Console.ReadLine());
                Messenger messenger = new Messenger();

                container.Add(shape);
                messenger.WriteMessage(shape);

                Console.WriteLine("Do you want to do it again?(Y/N)");
                selection = Console.ReadLine();
                Console.Clear();
            }
            while (selection == "Y" || selection == "y");

            for (int item = 0; item < container.Count; item++)
                totalSides += container[item].SidesOfShape;
            Console.WriteLine(totalSides);
        }
    }
}
