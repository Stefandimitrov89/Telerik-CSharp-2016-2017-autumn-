//Description
//
//Write a program that calculates N! / K! for given N and K.
//
//    Use only one loop.
//
//Input
//
//    On the first line, there will be only one number - N
//    On the second line, there will be only one number - K
//
//Output
//
//    Output a single line, consisting of the result from the calculation described above.


using System;
using System.Numerics;

namespace _06.CalculateAgain
{
    class Again
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = (K + 1); i <= N; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
