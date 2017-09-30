using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            double mark = Double.Parse(Console.ReadLine());
            if (mark >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
