﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            //double comission = 0;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    //comission = 0.05;
                    //Console.WriteLine("{0:0.00}", comission * sales);
                    Console.WriteLine("{0:0.00}", (sales * 0.05));
                    //Console.WriteLine("{:0.00}", (sales * 0.05));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:0.00}", (sales * 0.07));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:0.00}", sales * 0.08);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:0.00}", sales * 0.12);
                }
                else Console.WriteLine("error");
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:0.00}", (sales * 0.045));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:0.00}", (sales * 0.075));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:0.00}", sales * 0.1);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:0.00}", sales * 0.13);
                }
                else Console.WriteLine("error");
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:0.00}", (sales * 0.055));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:0.00}", (sales * 0.08));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:0.00}", sales * 0.12);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:0.00}", sales * 0.145);
                }
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
