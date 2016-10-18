//Description
//
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from /the /console).
//Input
//
//    On the only input line you will receive the unsigned integer number whose bits you must exchange.
//
//Output
//
//    On the only output line print the value of the integer with the exchanged bits.
//
//Constraints
//
//    N will always be a valid 32-bit unsigned integer.
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());

            //uint mask3 = 1 << 3;
            //uint thirdBit = (input & mask3) >> 3 ;
            //uint mask4 = 1 << 4;
            //uint forthBit = (input & mask4) >> 4;
            //uint mask5 = 1 << 5;
            //uint fifthBit = (input & mask5) >> 5;
            //
            //uint mask24 = 1 << 24;
            //uint twentyForthBit = (input & mask24) >> 24; 
            //uint mask25 = 1 << 25;
            //uint twentyFifthBit = (input & mask25) >> 25;
            //uint mask26 = 1 << 26;
            //uint twentySixthBit = (input & mask26) >> 26;

            uint mask345 = 7 << 3;
            uint bits345 = (input & mask345) >> 3;

            uint mask242526 = 7 << 24;
            uint bits242526 = (input & mask242526) >> 24;

            Console.WriteLine(bits242526);

            uint output = input;


           
            //Console.WriteLine(thirdBit);
            //Console.WriteLine(forthBit);
            //Console.WriteLine(fifthBit);
            //Console.WriteLine(twentyForthBit);
            //Console.WriteLine(twentyFifthBit);
            //Console.WriteLine(twentySixthBit);
        }
    }
}
