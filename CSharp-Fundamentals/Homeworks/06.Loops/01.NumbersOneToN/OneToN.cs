//Description
//
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on /a /single line, separated by a whitespace.
//Input
//
//    The input will consist of a single line - the number N
//
//Output
//
//    The output should consist of a single line - the numbers from 1 to N, separated by a whitespace


using System;

namespace _01.NumbersOneToN
{
    class OneToN
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                int currNumber = i + 1;
                Console.Write("{0} ", currNumber);
            }
        }
    }
}
