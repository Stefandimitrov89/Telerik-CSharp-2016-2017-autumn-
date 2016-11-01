//Description
//
//Write a program that finds the biggest of 5 numbers that are read from the console.
//Input
//
//    On the first 5 lines you will receive the 5 numbers, each on a separate line
//
//Output
//
//    On the only output line, write the biggest of the 5 numbers



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main(string[] args)
        {
            double[] numbersInput = new double[5];
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
