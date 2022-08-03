﻿using System;

namespace Day6_Practice_Problem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] notes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] arr = new int[9];
            Console.WriteLine("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (amount >= notes[i])
                {
                    arr[i] = amount / notes[i];
                    amount = amount - (arr[i] * notes[i]);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(notes[i] + ":" + arr[i]);
                }
            }
        }

    }
}