using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k,sum;
            Console.Write("Input the first number to multiply:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply:");
            j = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply:");
            k = int.Parse(Console.ReadLine());
            sum = i * j * k;
            Console.WriteLine("output is:" + (sum));
        }
    }
}
