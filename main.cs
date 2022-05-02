// Created by: Jaejun Lee
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userInteger;
        Console.WriteLine("Put an integer:");
        userInteger = int.Parse(Console.ReadLine());
        if (userInteger > 0)
        {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("The integer is positive.");
        }
        else
        {
            Console.WriteLine("The integer is negative.");
        }
    }
}