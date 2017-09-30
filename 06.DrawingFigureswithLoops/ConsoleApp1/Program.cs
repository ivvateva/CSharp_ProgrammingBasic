using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == (number - 1)) Console.Write("+");
                else Console.Write("|");
                for (int j = 0; j < number -2; j++)
                {
                    Console.Write('-');
                }
                if (i == 0 || i == (number - 1)) Console.WriteLine("+");
                else Console.WriteLine("|");
            }
        }
    }
}
