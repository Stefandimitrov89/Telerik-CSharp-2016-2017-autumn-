﻿//Description

//Declare two string variables and assign them with Hello and World. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).


using System;

namespace _06.StringsAndObjects
{
    class StringsAndObj
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string helloWorldString = helloWorld.ToString();
            Console.WriteLine(helloWorldString);
        }
    }
}
