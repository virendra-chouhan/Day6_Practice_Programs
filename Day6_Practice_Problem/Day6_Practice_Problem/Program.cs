﻿using System;

namespace Day6_Practice_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("enter the Number");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                
            }

    }
}