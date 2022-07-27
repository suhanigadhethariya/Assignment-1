using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("input string line:");
            str = Console.ReadLine();
            if(str.Length>=1)
            {
                var s=str.Substring(0,1);
                Console.Write(s +" "+ str +" "+ s);

            }
        }
    }
}
