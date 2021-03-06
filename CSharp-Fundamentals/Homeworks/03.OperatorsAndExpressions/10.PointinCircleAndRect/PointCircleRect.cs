﻿//Description
//
//Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point(x, y) if it /is /within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).
//Input
//
//    You will receive the pair of coordinates on the two lines of the input - on the first line you will find x, and on /the/ second - y.
//
//Output
//
//    Print inside circle if the point is inside the circle and outside circle if it's outside. Then print a single //whitespace followed by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. See /the /sample tests for a visual description.
//
//Constraints
//
//    The coordinates x and y will always be valid floating-point numbers in the range[-1000, 1000].
//    Time limit: 0.1s
//    Memory limit: 16MB


using System;

namespace _10.PointCircleRectangle
{
    class PointCircleRect
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double circleRadius = 1.5;
            double circleX = 1;
            double circleY = 1;
            double distBetweenPiontAndCircleCenter = Math.Sqrt((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY));

            double rectTop = 1;
            double rectHeight = 2;
            double rectLeft = -1;
            double rectWidth = 6;
            double rectBot = rectTop - rectHeight;
            double rectRight = rectLeft + rectWidth;

            //bool insideCircle = true;
            //bool insideRect = true;

            string locationRectangle = "inside rectangle";
            string locationCircle = "inside circle";

            if (x < rectLeft || x > rectRight)
            {
                //insideRect = false;
                locationRectangle = "outside rectangle";
            }

            if (y < rectBot || y > rectTop)
            {
                //insideRect = false;
                locationRectangle = "outside rectangle";
            }

            if (distBetweenPiontAndCircleCenter > circleRadius)
            {
                //insideCircle = false;
                locationCircle = "outside circle";
            }

            Console.WriteLine("{0} {1}", locationCircle, locationRectangle);

        }
    }
}
