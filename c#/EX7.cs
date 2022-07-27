using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,a,b,c,d,mod;
            Console.Write("Input the first number:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Input the first number:");
            j = int.Parse(Console.ReadLine());
            a = i + j;
            b = i - j;
            c = i * j;
            d = i / j;
            mod = i % j;
 
           Console.WriteLine(i + " "+"+" +" "+ j + " " + "=" + a);
           Console.WriteLine(i + " " + "-" + " " + j + " " + "=" + b);
           Console.WriteLine(i + " " + "*" + " " + j + " " + "=" + c);
           Console.WriteLine(i + " " + "/" + " " + j + " " + "=" + d);
           Console.WriteLine(i + " " + "%" + " " + j + " " + "=" + mod);

        }
    }
}
