//Description
//
//Write a program that finds the biggest of three numbers that are read from the console.
//Input
//
//    On the first three lines you will receive the three numbers, each on a separate line.
//
//Output
//
//    On the only output line, write the biggest of the three numbers.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            double[] numbersInput = new double[3];
            for (int i = 0; i < numbersInput.Length; i++)
            {
                numbersInput[i] = double.Parse(Console.ReadLine());
            }
            double theBiggest = -200;

            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (numbersInput[i] > theBiggest)
                {
                    theBiggest = numbersInput[i];
                }
            }
            Console.WriteLine("{0}", theBiggest);
        }
    }
}
