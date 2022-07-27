using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX15
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            Console.WriteLine("ATMIYA UNIVERSITY");
            Console.WriteLine(" ");
            Console.WriteLine("Simple Output:");
            Console.WriteLine(remove_char("ATMIYA UNIVERSITY", 2)+" " );
            Console.WriteLine(remove_char("ATMIYA UNIVERSITY", 7));

        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
