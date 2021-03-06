﻿//Description
//
//Write a program that reads a card sign(as a string) from the console and generates and prints all possible cards from a //standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using /the /classical notation(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//
//    The card faces should start from 2 to A(10 is 10).
//    Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//
//Input
//
//    On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
//
//Output
//
//    The output should follow the format bellow(assume our input is 5): 2 of spades, 2 of clubs, 2 of hearts, 2 of /diamonds/ 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds
//

using System;

namespace _04.PrintADeck
{
    class PrintDeck
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int value;
            if (int.TryParse(input, out value))
            {
                for (int i = 2; i <= value; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }
            else
            {
                switch (input)
                {
                    case "J":
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", input);
                        break;
                    case "Q":
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", input);
                        break;
                    case "K":
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", input);
                        break;
                    case "A":
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", input);
                        break;

                    default:
                        break;
                }
            }
        }
            
    }
}
