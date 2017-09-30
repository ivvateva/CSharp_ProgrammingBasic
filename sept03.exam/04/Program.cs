using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var lenght = int.Parse(Console.ReadLine());

            int cake = width * lenght;
            int numbers = 0;
            string input = "";
            while (cake > 0)
            {
                input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine("{0} pieces are left.", cake);
                    break;
                }
                else
                {
                    numbers = Convert.ToInt32(input);
                    cake = cake - numbers;                   
                }
                if (cake <= 0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(cake));

                }
            }
          


            
        }
    }
}
