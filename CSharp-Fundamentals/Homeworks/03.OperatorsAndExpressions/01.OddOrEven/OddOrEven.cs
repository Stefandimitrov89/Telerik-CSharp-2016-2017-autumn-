//Description
//
//Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, /and /prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.
//Input
//
//    On the single input line you will receive an integer number.
//
//Output
//
//    Output a single line - if the number is even, output even, followed by a whitespace and the value of the number. //Otherwise, print odd, again followed by a whitespace and the number's value. See the sample tests.
//
//Constraints
//
//    The input number will always be a valid integer number.
//    The input number will always be in the range [-30, 30].
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool even = true;
            if (input % 2 != 0)
            {
                even = false;
            }

            Console.WriteLine(even? "even {0}" :"odd {0}" , input);

        }
    }
}
