//Description
//
//Write an expression that calculates rectangle’s area and perimeter by given width and height.The width and height /should /be read from the console.
//Input
//
//
//   The input will consist of 2 lines:
//        On the first line, you will receive a floating-point number that will represent the width of the rectangle.
//
//       On the second line, you will receive another floating-point number that will represent the height of the /rectangle.
//
//
//Output
//
//   Output a single line - the rectangle's area and perimeter, separated by a whitespace.
//
//       Print the area and perimeter values with exactly 2-digits precision after the floating point
//
//
//Constraints
//
//   The width and height will always be valid floating-point numbers.
//
//   Time limit: 0.1s
//   Memory limit: 16MB


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rect
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = (width + height) * 2;

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }                               
    }
}
