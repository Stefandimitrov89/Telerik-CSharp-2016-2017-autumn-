//Description
//
//Write a program that reads two double values from the console A and B, stores them in variables and exchanges their /values/ if the first one is greater than the second one.Use an if-statement.As a result print the values of the /variables A and/ B, separated by a space.
//Input
//
//  On the first line, you will receive the value of A
//  On the second line, you will receive the value of B
//
//Output
//
//    On the only output line, print the values of the two variables, separated by a whitespace
//

using System;

namespace _01.ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                int greaterNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = greaterNumber;
            }

            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}
