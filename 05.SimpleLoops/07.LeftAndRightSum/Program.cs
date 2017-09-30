using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < number; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum1 = sum1 + num;
            }

            for (int j = 0; j < number; j++)
            {
                double num = double.Parse(Console.ReadLine());
                sum2= sum2 + num;
            }

            if (Math.Abs(sum1 - sum2) == 0)
            {
                Console.WriteLine("Yes sum " + Math.Abs(sum1));
            }
            else Console.WriteLine("No diff " + Math.Abs(sum1 - sum2));

        }
    }
}
