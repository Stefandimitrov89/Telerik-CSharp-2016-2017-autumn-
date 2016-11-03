//Description
//
//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//
//    Use only one loop.Print the result with 5 digits after the decimal point.
//
//Input
//
//    On the first line you will receive one number - N.
//    On the second line you will receive another number - x.
//
//Output
//
//    Output only one number - the sum of the sequence for the given N and x.


using System;

namespace _05.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());

            decimal result = 1;

            decimal numerator = 1;
            decimal denominator = 1;

            for (int i = 0; i < power; i++)
            {
                numerator *= (i + 1);
                denominator *= x;

                result += (decimal)numerator / (decimal)denominator;

            }
            Console.WriteLine("{0:F5}", result);
        }
    }
}
