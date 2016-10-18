//Description
//
//Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th //bit.
//Input
//
//    On the first line you will receive the number P.On the second line you will receive the number N.
//
//Output
//
//
//   Output a single value - the value of the N-th bit in P.
//
//Constraints
//
//   N will be a positive integer and always smaller than 55.
//    0 <= P <= 255
//    Time limit: 0.1s
//   Memory limit: 16MB


using System;

namespace _12.NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());

            long mask = (long)1 << position;
            
            long maskedInput = input & mask;

            long output = maskedInput >> position;

            Console.WriteLine(output);
        }
    }
}
