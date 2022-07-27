using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i,j,k;
            Console.Write("Enter a digit:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected output:");
            for (k = 1; k <= 2; k++)
            {
                for (i = 1; i <= 4; i++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine(" ");
                for (j = 1; j <= 4; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine(" ");
            }

        }
    }
}
