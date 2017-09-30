using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //square, rectangle, circle или triangle
            //до 3 цифри след десетичната точка
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.000}",( a * a));
                
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.000}", (a * b));

            }
            else if (figure == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.000}", ((Math.PI)* a*a));
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.000}", ((a * b)/2));
            }
        }
    }
}
