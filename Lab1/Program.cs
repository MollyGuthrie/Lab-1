using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, perimeter;
            Console.WriteLine("please enter the length of the room:");
            string length = Console.ReadLine();
            Console.WriteLine("please enter the width of the room:");
            string width = Console.ReadLine();
            double parsedlength = double.Parse(length);
            double parsedwidth = double.Parse(width);
            area = parsedlength * parsedwidth;
            Console.WriteLine("The area of the room is:");
            Console.WriteLine(area);
            perimeter = 2 * (parsedlength + parsedwidth);
            Console.WriteLine("The perimeter of the room is:");
            Console.WriteLine(perimeter);

        }
    }
}
