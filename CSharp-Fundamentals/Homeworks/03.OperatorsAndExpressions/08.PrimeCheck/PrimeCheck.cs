//Description
//
//Write a program that reads an integer N(which will always be less than 100 or equal) and uses an expression to check if //given N is prime(i.e.it is divisible without remainder only to itself and 1).
//
//    Note: You should check if the number is positive
//
//Input
//
//    On the only input line you will receive the number N.
//
//Output
//
//    Output true if the number is prime and false otherwise.
//
//Constraints
//
//    N will always be a valid 32-bit integer number, which will be less than 100 or equal.
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sqrtNum = Math.Sqrt(number);
            bool isPrime = true;

            if (number <= 0)
            {
                isPrime = false;
            }

            for (int i = 2; i <= sqrtNum; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine(isPrime ? "true" : "false");

        }
    }
}
