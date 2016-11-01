//Description
//
//Write a program that, depending on the first line of the input, reads an int, double or string variable.
//
//    If the variable is int or double, the program increases it by one.
//    If the variable is a string, the program appends* at the end.
//    Print the result at the console. Use switch statement.
//
//Input
//
//    On the first line you will receive the type of input as string in the following form:
//        integer for int
//        real for double
//        text for string
//    On the second line you will be given the value of the variable.
//
//Output
//
//    Write a single line on the console - the value transformed according to the rules from the description.
//        Print all double variables with exactly 2-digits precision after the floating point. Example: 0.99


using System;

namespace _09.IntDoubleString
{
    class IntDoubleStr
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    int intInput = int.Parse(Console.ReadLine());
                    int intOutput = intInput + 1;
                    Console.WriteLine("{0}", intOutput);
                    break;
                case "real":
                    double doubleInput = double.Parse(Console.ReadLine());
                    double doubleOutput = doubleInput + 1;
                    Console.WriteLine("{0:F2}", doubleOutput);
                    break;
                case "text":
                    string stringInput = Console.ReadLine();
                    string stringOutput = stringInput + "*";
                    Console.WriteLine(stringOutput);
                    break;
            }
        }
    }
}
