using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            for (int i = 0; i < number; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (min > num) min = num;
            }
            Console.WriteLine(min);
        }
    }
}
