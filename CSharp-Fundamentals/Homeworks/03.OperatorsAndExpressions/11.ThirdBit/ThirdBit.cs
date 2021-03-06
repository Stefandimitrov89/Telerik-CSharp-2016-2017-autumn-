﻿//Description
//
//Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned //integer read from the console.
//
//    The bits are counted from right to left, starting from bit 0.
//    The result of the expression should be either 1 or 0. Print it on the console.
//
//Input
//
//    On the only input line, you will receive a single positive integer - the number whose 3rd bit you must print.
//
//Output
//
//    Output a single number - 1 or 0 - the value of the 3rd bit, counted from 0 and from right to left.
//
//Constraints
//
//    The input number will always be a valid positive integer number.
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());
            uint mask = 1 << 3;
            
            long inputMask = input & mask;
            long bit = inputMask >> 3;
            Console.WriteLine(bit);
            
        }
    }
}
