using System;

namespace _16.LongSequence
{
    class PrintLong
    {
        static void Main(string[] args)
        {
            double a = 1;

            for (int i = 0; i < 1000; i++)
            {

                double b = Math.Abs(a) + 1;
                a = b * Math.Pow(-1, i);

                Console.WriteLine("{0}", a);
            }
        }
    }
}
