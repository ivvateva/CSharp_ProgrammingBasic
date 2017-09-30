using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            if (type == "premiere")
            {
                Console.WriteLine("{0:f2}", 12 * rows * columns);
            }
            else if (type == "normal")
            {
                Console.WriteLine("{0:f2}", 7.5 * rows * columns);
            }
            else if (type == "discount")
            {
                Console.WriteLine("{0:f2}", 5 * rows * columns);
            }
            else Console.WriteLine("error");
        }
    }
}
