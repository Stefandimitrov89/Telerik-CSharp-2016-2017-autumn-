//Description
//
//Write a program that does the following:
//
//    Reads an integer number from the console.
//    Stores in a variable if the number can be divided by 7 and 5 without remainder.
//    Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. Otherwise prints /"false /NUMBER". In place of NUMBER print the value of the input number.
//
//Input
//
//    The input will consist of a single integer value.
//
//Output
//
//    The output must always follow the format specified in the description. See the sample tests.
//
//Constraints
//
//    The input will always consist of valid integers and follow the format in the description.
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBySevenAndFive
{
    class DivBy7And5
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool divisible = true;
            int[] divisors = { 5, 7 };

            for (int i = 0; i < divisors.Length; i++)
            {
                if (input % divisors[i] != 0)
                {
                    divisible = false;
                }
            }
            Console.WriteLine(divisible? "true {0}" : "false {0}", input);
        }
    }
}
