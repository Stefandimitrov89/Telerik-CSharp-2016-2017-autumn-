//Description
//
//Write a program that read a digit[0 - 9] from the console, and depending on the input, shows the digit as a word(in //English).
//
//    Print "not a digit" in case of invalid input.
//    Use a switch statement.
//
//Input
//
//    The input consists of one line only, which contains the digit.
//
//Output
//
//    Output a single line - should the input be a valid digits, print the english word for the digits.Otherwise, print /"not/ a digit".
//

using System;

namespace _08.DigitAsWord
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "not a digit";

            switch (input)
            {
                case "1":
                    output = "one";
                    break;
                case "2":
                    output = "two";
                    break;
                case "3":
                    output = "three";
                    break;
                case "4":
                    output = "four";
                    break;
                case "5":
                    output = "five";
                    break;
                case "6":
                    output = "six";
                    break;
                case "7":
                    output = "seven";
                    break;
                case "8":
                    output = "eight";
                    break;
                case "9":
                    output = "nine";
                    break;
                case "0":
                    output = "zero";
                    break;
            }

            Console.WriteLine("{0}", output);
        }
    }
}
