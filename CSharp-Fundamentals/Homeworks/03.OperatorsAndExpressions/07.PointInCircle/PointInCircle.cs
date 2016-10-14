//  Description
//  
//  Write a program that reads the coordinates of a point x and y and using an expression checks if given point(x, y) is //   inside a circle K({ 0, 0}, 2) - the center has coordinates(0, 0) and the circle has radius 2. The program should then //   print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
//  
//  In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.
//  
//  Input
//  
//  
//  You will receive exactly two lines, the first containing the x coordinate, the second containing the y coordinate.
//  
//  
//  Output
//  
//  Output a single line in the format described above. The distance should be always printed with 2-digit precision after /  the/ floating point.
//  
//  
//  Constraints
//  
//  The numbers x and y will always be valid floating point numbers in the range (-1000, 1000)
//      Time limit: 0.1s
//      Memory limit: 16MB


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PiontInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            int circleRadius = 2;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool inside = true;
            double distance = Math.Sqrt(x * x + y * y);

            if (distance > circleRadius)
            {
                inside = false;
            }

            Console.WriteLine(inside ? "yes {0:F2}" : "no {0:F2}", distance);
        }
    }
}
