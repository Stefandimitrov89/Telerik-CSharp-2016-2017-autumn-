//Description
//
//Write a program that shows the sign(+, - or 0) of the product of three real numbers, without calculating it.
//
//   Use a sequence of if operators.
//
//Input
//
//   On the first three lines, you will receive the three numbers, each on a separate line
//
//Output
//
//    Output a single line - the sign of the product of the three numbers


using System;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double[] numbersInput = new double[3];
            for (int i = 0; i < numbersInput.Length; i++)
            {
                numbersInput[i] = double.Parse(Console.ReadLine());
            }
            int negative_numbers_count = 0;
            char output = '+';

            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (numbersInput[i] < 0)
                {
                    negative_numbers_count++;
                }
                if (numbersInput[i] == 0)
                {
                    output = '0';
                    Console.WriteLine(output);
                    return;

                }
            }     

            if (negative_numbers_count % 2 != 0)
            {
                output = '-';
            }

            Console.WriteLine(output);
        }
    }
}
