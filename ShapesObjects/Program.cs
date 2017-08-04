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

            do
            { 
                Console.WriteLine("Enter Shape Name: ");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "Square":
                        Square square = new Square() { ShapeName = input };
                        Console.WriteLine(p.GetShape(square));
                        break;
                    case "Rectangle":
                        Rectangle rectangle = new Rectangle() { ShapeName = input };
                        Console.WriteLine(p.GetShape(rectangle));
                        break;
                    case "Pentagon":
                        Pentagon pentagon = new Pentagon() { ShapeName = input };
                        Console.WriteLine(p.GetShape(pentagon));
                        break;
                    case "Triangle":
                        Triangle triangle = new Triangle() { ShapeName = input };
                        Console.WriteLine(p.GetShape(triangle));
                        break;
                    default:
                        Console.WriteLine("Shape entered is invalid");
                        break;
                }
                Console.WriteLine("Do you want to do it again?(Y/N)");
                selection = Console.ReadLine();
                Console.Clear();
            }
            while (selection == "Y" || selection == "y");
            
        }
        private string GetShape(IShapes shape)
        {
            if (shape is Square)
                return shape.SidesOfShape();
            else if(shape is Rectangle)
                return shape.SidesOfShape();
            else if (shape is Pentagon)
                return shape.SidesOfShape();
            else if (shape is Triangle)
                return shape.SidesOfShape();
            else
                return "Sides of Shape cannot be determined";
        }
    }
}
