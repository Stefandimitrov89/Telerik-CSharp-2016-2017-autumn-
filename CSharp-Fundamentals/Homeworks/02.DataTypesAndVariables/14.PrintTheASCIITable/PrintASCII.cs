//Description
//Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints the visible characters of the ASCII table on the console(characters from 33 to 126 including).

//Note: You may need to use for-loops(learn in Internet how).
//Input
//
//    None
//
//Output
//
//  The 94 characters on single line
//
//Constraints
//
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;

namespace _14.PrintTheASCIITable
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            for (var i = 33; i <= 126; i++)
            {
                char c = (char)i;
                Console.Write(c);
            }
        }
    }
}
