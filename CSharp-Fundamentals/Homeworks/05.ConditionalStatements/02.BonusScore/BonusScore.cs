//Bonus Score
//Description
//
//Write a program that applies bonus score to given score in the range[1…9] by the following rules:
//
//    If the score is between 1 and 3, the program multiplies it by 10.
//    If the score is between 4 and 6, the program multiplies it by 100.
//    If the score is between 7 and 9, the program multiplies it by 1000.
//    If the score is less than 0 or more than 9, the program prints "invalid score".
//
//Input
//
//    The only input line will contain one integer number - the score
//
//Output
//
//    Output the score with the applied bonus


using System;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            string output = "invalid score";
            int appliedScore = 0;

            if (score >= 1 && score <= 3)
            {
                appliedScore = score * 10;
                output = appliedScore.ToString();
            }
            else if (score >= 4 && score <= 6)
            {
                appliedScore = score * 100;
                output = appliedScore.ToString();
            }
            else if (score >= 7 && score <= 9)
            {
                appliedScore = score * 1000;
                output = appliedScore.ToString();
            }
            Console.WriteLine(output);
        }
    }
}
