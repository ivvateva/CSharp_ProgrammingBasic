using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i<= number; i++)
            {
                Console.Write(new string(' ', number - i));
                for (int j = 0; j < i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = number -2 ; i >= 0; i--)
            {
                Console.Write(new string(' ', number - i - 1 ));
                for (int j = i ; j >= 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
