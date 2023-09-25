﻿using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            for (int i = 0; i < n; i++)

            {
                int newNumber = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + newNumber;
            }
            int sumRight = 0;
            for (int i = 0; i < n; i++)
            {
               int newNumber = int.Parse(Console.ReadLine());
                sumRight= sumRight + newNumber;  
            }
            if (sumLeft==sumRight)
            {
                Console.WriteLine("Yes, sum = " + sumRight);
            }
            else
            {
                int diff = Math.Abs(sumRight - sumLeft);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
