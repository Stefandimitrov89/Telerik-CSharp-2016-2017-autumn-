using System;

namespace Task3NumberOfPages
{
    class NumberOfPages
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());

            int numberOfDigits = 0;

            for (int i = 1; i <= numberOfPages; i++)
            {
                string currentInt = i.ToString();
                numberOfDigits += currentInt.Length;
            }

            Console.WriteLine(numberOfDigits);
            
        }
    }
}
