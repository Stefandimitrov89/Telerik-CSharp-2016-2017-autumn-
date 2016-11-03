//Description
//
//In combinatorics, the number of ways to choose N different members out of a group of N different elements(also known as the number of /combinations) /is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of /52 cards.Your /task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.
//
//  Try to use only two loops.
//
//Input
//
//  On the first line, there will be only one number - N
//  On the second line, there will also be only one number - K
//
//Output
//
//
//  On the only output line, write the result of the calculation for the provided N and K


using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate3_
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int difference = N - K;

            BigInteger result = 0;

            BigInteger leftPartOfEquation = 1; //N!/K!
            BigInteger rightPartOfEquation = 1; // ((N - K)!)

            for (int i = (K + 1); i <= N; i++)
            {
                leftPartOfEquation *= i;
            }

            for (int i = 0; i < difference; i++)
            {
                rightPartOfEquation *= (i + 1);
            }

            result = leftPartOfEquation / rightPartOfEquation;

            Console.WriteLine(result);
        }
    }
}
