using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

           /* for (int i = 0; i < number - 2 ; i++)
            {
                for (int k = 0; k < number - 1; k++)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', k), new string('.', number - k  ));
                }
            }*/

            for (int i = 0; i< number -1; i ++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', number - i));
            }
                        Console.WriteLine("{0}*****{0}", new string('.', number - 1));
            Console.WriteLine(new string('*', 2 * number + 3));
            Console.WriteLine("{0}*****{0}", new string('.', number - 1));
            
            for (int i = 0 ; i < number -1 ; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', number - 2 - i), new string ('.', i + 2));
            }
            
        }
    }
}
