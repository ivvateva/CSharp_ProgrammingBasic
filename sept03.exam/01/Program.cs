using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = int.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var widgh = double.Parse(Console.ReadLine());

            double clothSize = (lenght + 0.60) * (widgh + 0.60);
            double smallClothSize = (lenght / 2) * (lenght / 2);

            double totalCloth = (tables * clothSize) * 7;
            double totalSmallCloth = (tables * smallClothSize) * 9;
            double totalClothBGN = totalCloth * 1.85;
            double totalSmallClothBGN = totalSmallCloth * 1.85;


            //double cloth = tables * (lenght + 0.60) * (widgh + 0.60);

            Console.WriteLine("{0:0.00} USD", (totalCloth + totalSmallCloth));
            Console.WriteLine("{0:0.00} BGN", (totalClothBGN + totalSmallClothBGN));
        }

    }
}
