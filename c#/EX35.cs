using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX35
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PHP Tutorial");
            Console.WriteLine(" ");
            Console.WriteLine("after");
            Console.WriteLine(" ");
           string  str="PHP Tutorial";
           Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));

            

        }
    }
}
