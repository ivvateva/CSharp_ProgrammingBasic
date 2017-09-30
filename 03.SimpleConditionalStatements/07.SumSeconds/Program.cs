using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = int.Parse(Console.ReadLine());
            int result2 = int.Parse(Console.ReadLine());
            int result3 = int.Parse(Console.ReadLine());
            int sum_time_sec = result1 + result2 + result3;
            int min = sum_time_sec / 60;
            int sec = sum_time_sec % 60;
            if (sec < 10)
            {
                Console.WriteLine(min + ":0" + sec);
            }
            else
            {
                Console.WriteLine(min + ":" + sec);
            }

        }
    }
}
