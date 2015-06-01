﻿//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine

using System;


class EnglishDig
{
         static string DisplayDigit(int digit)
        {
            switch (digit % 10)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Last digit in English is " + DisplayDigit(x));
        }
}
   


