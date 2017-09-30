using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantity = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string order = Console.ReadLine().ToLower();
            double price = 0;

            /*switch (type)
            {
                case "9x13": price = 0.16; break;
                case "10x15": price = 0.16; break;
                case "13x18": price = 0.38; break;
                case "20x30": price = 2.90; break;
                default:; break;
            }*/

            if (type == "9x13")
            {
                if (quantity < 50)
                {
                    price = quantity * 0.16;
                }
                else price = 0.95 * (quantity * 0.16);
            }
            else if (type == "10x15")
            {
                if (quantity < 80)
                {
                    price = quantity * 0.16;
                }
                else price = 0.97 * (quantity * 0.16);
            }
            else if (type == "13x18")
            {
                if (quantity < 50)
                {
                    price = quantity * 0.38;
                }
                else if (quantity >= 50 && quantity < 100) price = 0.97 * (quantity * 0.38);
                else price = 0.95 * (quantity * 0.38);
            }
            else if (type == "20x30")
            {
                if (quantity < 10)
                {
                    price = quantity * 2.90;
                }
                else if (quantity >= 10 && quantity < 50) price = 0.93 * (quantity * 2.90);
                else price = 0.91 * (quantity * 2.90);
            }

            if (order == "online")
            {
                Console.WriteLine("{0:0.00}BGN", 0.98 * price);
            }
            else if (order == "office")
            {
                Console.WriteLine("{0:0.00}BGN", price);
            }

        }
    }
}
