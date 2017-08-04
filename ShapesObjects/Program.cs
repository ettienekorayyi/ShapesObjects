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
            

            do
            { 
                Console.WriteLine("Enter Shape Name: ");
                IShapes shape = shapeFactory.CreateShape(Console.ReadLine());
                Messenger messenger = new Messenger();

                messenger.WriteMessage(shape);

                Console.WriteLine("Do you want to do it again?(Y/N)");
                selection = Console.ReadLine();
                Console.Clear();
            }
            while (selection == "Y" || selection == "y");
            
        }
    }
}
