using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ConcatenateData
{
    class Program
    {
        static void Main()
        {
            var first = Console.ReadLine();
            var last = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}!", first, last, age, town);
        }
    }
}
