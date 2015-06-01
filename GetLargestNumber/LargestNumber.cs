//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;


class LargestNumber
{
         static int GetMax(int a, int b)
        {
            return (a >= b ? a : b);
        }

        static void Main()
        {
            Console.WriteLine("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("C = ");
            int c = int.Parse(Console.ReadLine());

            if (GetMax(a,b) > c) // if a or b is greater than c then
            {
                Console.WriteLine(GetMax(a, b)); // print a or b
            }
            else
            {
                Console.WriteLine(c); //print c
            }
        }
    }



