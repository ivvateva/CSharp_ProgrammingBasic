﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee") { Console.WriteLine(quantity * 0.5); }
                else if (product == "water") { Console.WriteLine(quantity * 0.8); }
                else if (product == "beer") { Console.WriteLine(quantity * 1.2); }
                else if (product == "sweets") { Console.WriteLine(quantity * 1.45); }
                else if (product == "peanuts") { Console.WriteLine(quantity * 1.6); }
                else Console.WriteLine("invalid product");
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee") { Console.WriteLine(quantity * 0.4); }
                else if (product == "water") { Console.WriteLine(quantity * 0.7); }
                else if (product == "beer") { Console.WriteLine(quantity * 1.15); }
                else if (product == "sweets") { Console.WriteLine(quantity * 1.3); }
                else if (product == "peanuts") { Console.WriteLine(quantity * 1.5); }
                else Console.WriteLine("invalid product");
            }
            else if (town == "varna")
            {
                if (product == "coffee") { Console.WriteLine(quantity * 0.45); }
                else if (product == "water") { Console.WriteLine(quantity * 0.7); }
                else if (product == "beer") { Console.WriteLine(quantity * 1.1); }
                else if (product == "sweets") { Console.WriteLine(quantity * 1.35); }
                else if (product == "peanuts") { Console.WriteLine(quantity * 1.55); }
                else Console.WriteLine("invalid product");
            }
            else
                Console.WriteLine("invalid town");
        }
    }
}
