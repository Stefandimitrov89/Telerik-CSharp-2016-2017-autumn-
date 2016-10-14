//Description

//A marketing company wants to keep record of its employees.Each record would have the following characteristics:

//    First name
//    Last name
//    Age(0...100)
//    Gender(m or f)
//    Personal ID number(e.g. 8306112507)
//    Unique employee number(27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.Print the data at the console.

using System;

namespace _10.EployeeData
{
    class EployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string lastName = "Goshov";
            int age = 50;
            bool isMale = true;
            string male = "Male";
            string female = "Female";
            long personalID = 8306112507;
            long uniqueNumber = 27569999;

            Console.WriteLine("First name is {0}", firstName);
            Console.WriteLine("Last name is {0}", lastName);
            Console.WriteLine("{0} {1} is {2} yearls old", firstName, lastName, age);
            Console.WriteLine("{0} {1} is {2}", firstName, lastName, isMale ? male: female);
            Console.WriteLine("{0} {1}'s Personal ID number is {2}", firstName, lastName, personalID);
            Console.WriteLine("{0} {1}'s unique number is {2}", firstName, lastName, uniqueNumber);
        }
    }
}
