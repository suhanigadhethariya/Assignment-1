using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX30
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string s;
            Console.WriteLine("enter your string:");
            s = Console.ReadLine();
            a = s.Substring(s.Length - 4);
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(a+" ");
            }
        }
    }
}
