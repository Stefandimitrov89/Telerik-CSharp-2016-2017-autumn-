using System;

namespace _15.Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            
            int currentAge = today.Year - birthDate.Year;
            if (today < birthDate.AddYears(currentAge))
            {
                currentAge--;
            }

            int ageIn10Years = currentAge + 10;
            Console.WriteLine(currentAge);
            Console.WriteLine(ageIn10Years);
        }
    }
}
