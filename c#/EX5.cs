using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,temp;
            Console.Write("Input the First Number :");
            i = int.Parse(Console.ReadLine());
            Console.Write("Input the First Number :");
            j = int.Parse(Console.ReadLine());
            temp = i;
            i = j;
            j = temp;
            Console.WriteLine("After swaping:");
            Console.WriteLine("output the First Number :" + (i));
            Console.WriteLine("output the second Number :" + (j));
        }
    }
}
