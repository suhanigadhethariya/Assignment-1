using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i;
            Console.WriteLine("Enter value:");
            a = int.Parse(Console.ReadLine());
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(a + " " + "*"+" " + i + " " + "=" + (a*i));
            }
        }
    }
}
