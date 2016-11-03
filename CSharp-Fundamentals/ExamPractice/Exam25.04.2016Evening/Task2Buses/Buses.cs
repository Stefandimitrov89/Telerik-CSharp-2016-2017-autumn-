using System;
namespace Task2Buses
{
    class Buses
    {
        static void Main(string[] args)
        {
            int numberOfBuses = int.Parse(Console.ReadLine());
            int[] bussesSpeed = new int[numberOfBuses];
            for (int i = 0; i < numberOfBuses; i++)
            {
                bussesSpeed[i] = int.Parse(Console.ReadLine());
            }
            int numberOfGroups = 1;

            for (int i = 1; i < bussesSpeed.Length; i++)
            {
                if (bussesSpeed[i] <= bussesSpeed[i - 1])
                {
                    numberOfGroups++;
                }
                else
                {
                    bussesSpeed[i] = bussesSpeed[i - 1];
                }
            }
            Console.WriteLine(numberOfGroups);


        }
    }
}




