using System;

namespace Task1BirdsAndFeathers
{
    class Feathers
    {
        static void Main(string[] args)
        {
            int numberOfBirds = int.Parse(Console.ReadLine());
            double numberOfFeathers = double.Parse(Console.ReadLine());

            long evenMagicNumber = 123123123123;
            int oddMagicNumber = 317;

            double averageFeathersPerBird = (double)numberOfFeathers / numberOfBirds;

            if (numberOfBirds % 2 == 0)
            {
                double result = averageFeathersPerBird * evenMagicNumber;
                Console.WriteLine("{0:F4}", result);
            }
            else
            {
                double result = (double)averageFeathersPerBird / (double)oddMagicNumber;
                Console.WriteLine("{0:F4}", result);
            }

            

        }
    }
}
