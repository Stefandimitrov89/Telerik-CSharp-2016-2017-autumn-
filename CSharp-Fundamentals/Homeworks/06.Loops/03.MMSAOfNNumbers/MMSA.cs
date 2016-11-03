//Description
//
//Write a program that reads from the console a sequence of N real numbers and returns the minimal, the maximal number, /the /sum and the average of all numbers (displayed with 2 digits after the decimal point).
//
//    The input starts by the number N (alone in a line) followed by N lines, each holding an real number.
//    The output is like in the examples below.
//
//Input
//
//    On the first line, you will receive the number N.
//    On each of the next N lines, you will receive a single real number.
//
//Output
//
//    You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the /second, /the sum on the third and the average on the fourth, in the following format:
//

using System;
namespace _03.MMSAOfNNumbers
{
    class MMSA
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] inputArr = new double[N];
            for (int i = 0; i < N; i++)
            {
                inputArr[i] = double.Parse(Console.ReadLine());
            }
            double max = double.MinValue;
            double min = double.MaxValue;
            double sumOfumbers = 0;
            double average = 0;

            foreach (var num in inputArr)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                sumOfumbers += num;
            }
            average = sumOfumbers / N;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sumOfumbers);
            Console.WriteLine("avg={0:F2}", average);
        }
    }
}
