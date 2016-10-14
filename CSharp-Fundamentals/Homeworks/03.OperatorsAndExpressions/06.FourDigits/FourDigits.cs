//Description
//
//Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
//
//    Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
//   Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
//   Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
//  Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
//
//Input
//
//
//  The input will consist of a single four-digit integer number on a single line.
//
//Output
//
//  Output the result of each action on a separate line, in the same order as they are explained above:
//
//      meaning the sum comes on the first line, the reversed number on the second, and so on.
//
//Constraints
//
//  The number will always be a valid positive four-digit integer.
//
//  The number will always start with a digit other than 0.
//
//  Time limit: 0.1s
//  Memory limit: 16MB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            int sum = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int temp = (int)Char.GetNumericValue(inputArr[i]);
                sum += temp;
            }
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", inputArr[3], inputArr[2], inputArr[1], inputArr[0]);
            Console.WriteLine("{0}{1}{2}{3}", inputArr[3], inputArr[0], inputArr[1], inputArr[2]);
            Console.WriteLine("{0}{1}{2}{3}", inputArr[0], inputArr[2], inputArr[1], inputArr[3]);
        }
    }
}
