﻿using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new console application “AverageNumber” that takes four numbers
            //as input to calculate and print the average.

            double number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            number1, number2, number3, number4, result);

            Console.ReadLine();
        }
    }
}
