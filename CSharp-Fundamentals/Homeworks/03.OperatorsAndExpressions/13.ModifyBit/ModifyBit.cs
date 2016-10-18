//Description
//
//We are given an integer number N(read from the console), a bit value v(read from the console as well) (v = 0 or 1) /and/ a position P(read from the console). Write a sequence of operators(a few lines of C# code) that modifies N to /hold /the value v at the position P from the binary representation of N while preserving all other bits in N. Print /the /resulting number on the console.
//Input
//
//
// The input will consist of exactly 3 lines containing the following:
//
//     First line - the integer number N.
//
//     Second line - the position P.
//     Third line - the bit value v.
//
//
//Output
//
// Output a single line containing the value of the number N with the modified bit.
//
//
//Constraints
//
// N will always be a valid 64-bit unsigned integer.
// P will always be between in the range [0, 64).
//    v will be always either 0 or 1.
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;

namespace _13.ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());

            ulong output = input;

            if (value == 1)
            {
                ulong mask = (ulong)1 << position;
                output = input | mask;
            }
            else
            {
                ulong mask = ~((ulong)1 << position);
                output = input & mask;
            }
            
            Console.WriteLine(output);
        }
    }
}
