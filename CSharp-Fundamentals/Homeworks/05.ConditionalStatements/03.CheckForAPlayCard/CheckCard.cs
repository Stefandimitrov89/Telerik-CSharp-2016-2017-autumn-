//Description
//
//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.Write /a/ program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no /CONTENT_OF_STRING" /otherwise.
//Input
//
//   On the only line you will receive a single string.
//
//Output
//
//    Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".


using System;

namespace _03.CheckForAPlayCard
{
    class CheckCard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "no " + input;

            switch (input)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    output = "yes " + input;
                    break;                    
            }

                Console.WriteLine(output);

        }
    }
}
