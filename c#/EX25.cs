﻿using System;
public class
    EX25
{
    public static void Main()
    {
        Console.Write("Input  a number(integer): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum = sum + n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the said integer: " + sum);
    }
}