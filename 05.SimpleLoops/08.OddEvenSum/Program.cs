using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i =1; i <= numbers; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    evenSum = evenSum + num;
                else oddSum = oddSum + num;
            }

            if (evenSum == oddSum)
                Console.WriteLine("Yes sum " + oddSum);
            else Console.WriteLine("No diff " + Math.Abs(oddSum - evenSum));
        }
    }
}
