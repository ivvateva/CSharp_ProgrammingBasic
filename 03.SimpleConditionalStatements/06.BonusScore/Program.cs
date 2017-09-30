using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double temp_bonus = 0;
            if (score < 100)
            {
                temp_bonus = 5;
            }
            else if (score > 100 && score < 1000)
            {
                temp_bonus = 0.2 * score;
            }
            else if (score > 1000)
            {
                temp_bonus = 0.1 * score;
            }

            if (score % 2 == 0)
            {
                temp_bonus = temp_bonus + 1;
            }
            
            if (score % 10 == 5  )
            {
                temp_bonus = temp_bonus + 2;
            }


            Console.WriteLine(temp_bonus);
            Console.WriteLine(temp_bonus + score);
        }
    }
}
