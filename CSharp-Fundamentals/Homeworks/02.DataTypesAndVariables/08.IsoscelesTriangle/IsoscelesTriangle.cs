//Description

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©

//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

using System;

namespace _08.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            string first  = "   ©";
            string second = "  © ©";
            string third  = " ©   ©";
            string fourth = "© © © ©";
            Console.WriteLine(first );
            Console.WriteLine(second);
            Console.WriteLine(third );
            Console.WriteLine(fourth);
        }
    }
}
