using System;
using LinearLibrary;
namespace Linear_function
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Function\ny = kx + b\n" + "---------------\n" + "Point A (x1,y1):");
            Console.Write("Enter x1 = ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1 = ");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------\n" + "Point B (x2,y2): ");
            Console.Write("Enter x2 = ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2 = ");
            var y2 = Convert.ToDouble(Console.ReadLine());

            var coordinates = new Coordinates(x1, y1, x2, y2);
            var linerFunction = new LinearFunction(coordinates);
       
            Console.WriteLine($"---------------\n{linerFunction}\n\nPress any button to end...");
            Console.ReadKey();
        }
    }
}


