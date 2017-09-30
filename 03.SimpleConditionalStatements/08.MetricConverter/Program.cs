using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = Double.Parse(Console.ReadLine());
            string inputMetrics = Console.ReadLine().ToLower();
            string outputMetrics = Console.ReadLine().ToLower();

            var m = 1.0;
            var mm = 1000;
            var cm = 100;
            var mi = 0.000621371192;
            var inn = 39.3700787;
            var km = 0.001;
            var ft = 3.2808399;
            var yd = 1.0936133;

            if (inputMetrics == "m") { number1 = number1 / m; }
            else if (inputMetrics == "mm") { number1 = number1 / mm; }
            else if (inputMetrics == "cm") { number1 = number1 / cm; }
            else if (inputMetrics == "mi") { number1 = number1 / mi; }
            else if (inputMetrics == "in") { number1 = number1 / inn; }
            else if (inputMetrics == "km") { number1 = number1 / km; }
            else if (inputMetrics == "ft") { number1 = number1 / ft; }
            else if (inputMetrics == "yd") { number1 = number1 / yd; }

            if (outputMetrics == "m") { number1 = number1 * m; }
            else if (outputMetrics == "mm") { number1 = number1 * mm; }
            else if (outputMetrics == "cm") { number1 = number1 * cm; }
            else if (outputMetrics == "mi") { number1 = number1 * mi; }
            else if (outputMetrics == "in") { number1 = number1 * inn; }
            else if (outputMetrics == "km") { number1 = number1 * km; }
            else if (outputMetrics == "ft") { number1 = number1 * ft; }
            else if (outputMetrics == "yd") { number1 = number1 * yd; }

            //number1 = System.Math.Round(number1, 8);
            Console.WriteLine(number1);            
        }
    }
}
