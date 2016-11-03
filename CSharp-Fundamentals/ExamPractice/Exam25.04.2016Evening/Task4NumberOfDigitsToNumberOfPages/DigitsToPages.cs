using System;

namespace Task4NumberOfDigitsToNumberOfPages
{
    class DigitsToPages
    {
        static void Main(string[] args)
        {
            int numberOfDigits = int.Parse(Console.ReadLine());

            int currentDigits = 0;
            int currentPage = 0;

            while (currentDigits < numberOfDigits)
            {
                currentPage++;
                string currentPageString = currentPage.ToString();
                currentDigits += currentPageString.Length;
            }
            Console.WriteLine(currentPage);
        }
    }
}
