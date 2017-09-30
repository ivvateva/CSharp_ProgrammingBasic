using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            if (income >= minSalary && mark < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minSalary)
            {
                double scholarship = 0;
                double scholarship_ex = 0;
                if (mark >= 4.50) scholarship = 0.35 * minSalary;
                else if (mark >= 5.5) scholarship_ex = 25 * mark;

                if (scholarship > scholarship_ex) Console.WriteLine("You get a Social scholarship {0} BGN", scholarship);
                else if (scholarship_ex > scholarship) Console.WriteLine("You get a scholarship for excellent results {0} BGN", scholarship_ex);
                else Console.WriteLine("You cannot get a scholarship!");
            }
            else if (mark >= 5.5)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", 25 * mark);
            }

        }
    }
}
