//Description

//Create a program that assigns null values to an integer and to a double variable.

//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.


using System;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmeric
    {
        static void Main(string[] args)
        {
            int? nullInteger = null;
            double? nullDouble = null;

            Console.WriteLine("{0} is a null integer", nullInteger);
            Console.WriteLine("{0} is a null double", nullDouble);

            nullInteger++;
            nullDouble++;

            Console.WriteLine("{0} is a null integer", nullInteger);
            Console.WriteLine("{0} is a null double", nullDouble);
        }
    }
}
