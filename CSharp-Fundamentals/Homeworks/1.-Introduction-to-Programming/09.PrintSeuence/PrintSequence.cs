using System;

namespace _09.PrintSeuence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            double a = 1;

            for (int i = 0; i < 10; i++)
            {

                double b = Math.Abs(a) + 1;
                a = b * Math.Pow(-1, i);

                Console.WriteLine("{0}", a);
            }
        }
    }
}
