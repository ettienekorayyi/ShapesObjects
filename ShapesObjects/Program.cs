using ShapesObjects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesObjects
{
    public class Program
    {
        private List<IShapes> container = new List<IShapes>();
        private Messenger messenger = new Messenger();
        private ShapeFactory shapeFactory = new ShapeFactory();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Process();
            Console.ReadKey();
        }

        /// <summary>
        /// Recursion for process
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Enter Shape Name: ");

            IShapes shape = shapeFactory.CreateShape(Console.ReadLine());
            if (shape != null)
                container.Add(shape);

            messenger.ShapeDescription(shape);
            messenger.SumOfSides(container.Sum(x => x.SidesOfShape));

            Console.WriteLine("Do you want to do it again?(Y/N)");

            if (Console.ReadLine() == "Y")
            {
                    Console.Clear();
                    Process();
            } 
        }
    }
}
