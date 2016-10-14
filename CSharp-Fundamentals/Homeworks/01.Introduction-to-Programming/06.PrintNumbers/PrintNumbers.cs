using System;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 101, 1001 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
