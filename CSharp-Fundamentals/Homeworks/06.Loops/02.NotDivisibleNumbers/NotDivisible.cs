//Description
//
//Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by /3/ or 7, on a single line, separated by a space.
//Input
//
//    Will always consists of one valid integer number - the number N.
//
//Output
//
//    Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7, separated by a whitespace.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NotDivisibleNumbers
{
    class NotDivisible
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                int currNumber = i + 1;
                if ((currNumber % 3 != 0) && (currNumber % 7 != 0))
                {
                    Console.Write("{0} ", currNumber);
                }
            }
        }
    }
}
