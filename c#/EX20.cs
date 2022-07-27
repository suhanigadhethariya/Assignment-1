using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,i;
            Console.Write("Enter Integer:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter Integer:");
            b = int.Parse(Console.ReadLine());
            i=a+b;
            if(a==20 || b==20 )
            {
                 Console.Write("one interger is 20 ");
            }

            else if (i == 20)
            {
                Console.Write("sum is 20:");
            }
            else
            {
                Console.Write("Not same as syntax");
            }
      

        }
    }
}
