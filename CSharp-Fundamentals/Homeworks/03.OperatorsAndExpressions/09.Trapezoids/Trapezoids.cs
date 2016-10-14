//Description
//
//Write an expression that calculates trapezoid's area by given sides a and b and height h. The three values should be /read /from the console in the order shown below. All three value will be floating-point numbers.
//Input
//
//    The input will consist of exactly 3 lines:
//        The side a on the first line.
//        The side b on the second line.
//        The height h on the third line.
//
//Output
//
//    Output a single line containing a single value - the area of the trapezoid.Output the area with exactly 7-digit //precision after the floating point.
//
//Constraints
//
//
//   All numbers will always be valid floating-point numbers in the range [-500, 500].
//    Time limit: 0.1s
//   Memory limit: 16MB


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double baseA = double.Parse(Console.ReadLine());
            double baseB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double median = (baseA + baseB) / 2;
            double area = median * height;
            Console.WriteLine("{0:F7}", area);
        }
    }
}
