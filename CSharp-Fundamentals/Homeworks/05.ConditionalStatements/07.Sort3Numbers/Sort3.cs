//Description
//
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//
//    Use nested if statements.
//    Don’t use arrays and the built-in sorting functionality.
//
//Input
//
//    On the first three lines, you will receive the three numbers, each on a separate line.
//
//Output
//
//    Output a single line on the console - the sorted numbers, separated by a whitespace


using System;

namespace _07.Sort3Numbers
{
    class Sort3
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.Write(a + " ");
                if (b >= c)
                {
                    Console.Write(b + " " + c);

                }
                else
                {
                    Console.Write(c + " " + b);

                }
            }
            if (b > a && b > c)
            {
                Console.Write(b + " ");
                if (a > c)
                {
                    Console.Write(a + " " + c);

                }
                else
                {
                    Console.Write(c + " " + a);
                }
            }
            if (c > a && c > b)
            {
                Console.Write(c + " ");
                if (a > b)
                {
                    Console.Write(a + " " + b);

                }
                else
                {
                    Console.Write(b + " " + a);
                    Console.WriteLine();
                }
            }
        }
    }
}
