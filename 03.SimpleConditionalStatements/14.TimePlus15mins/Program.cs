using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            if (minutes < 45)
            {
                minutes = minutes + 15;
                if (minutes > 10)
                {
                    Console.WriteLine(hour + ":" + minutes);
                }
                else Console.WriteLine(hour + ":0" + minutes);
            }
            else if (minutes >= 45)
            {
                minutes = (minutes + 15) - 60;
                if (hour == 23)
                {
                    hour = 0;
                }
                else hour = hour + 1;

                if (minutes >= 10)
                {
                    Console.WriteLine(hour + ":" + minutes);
                }
                else Console.WriteLine(hour + ":0" + minutes);
            }
        }
    }
}

