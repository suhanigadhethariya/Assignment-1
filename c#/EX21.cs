using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter first value:");
            a = int.Parse(Console.ReadLine());
            if (Math.Abs(100 - a) <= 20 || Math.Abs(200 - a) <= 20)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
    }
}
