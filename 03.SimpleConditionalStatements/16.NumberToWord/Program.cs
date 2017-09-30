using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int dec = 0;
            int temp = 0;

            if (number > 0 && number < 100)
            { 
            if (number < 21)
            {
                if (number == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (number == 1)
                {
                    Console.WriteLine("one");
                }
                else if (number == 2)
                {
                    Console.WriteLine("two");
                }
                else if (number == 3)
                {
                    Console.WriteLine("three");
                }
                else if (number == 4)
                {
                    Console.WriteLine("four");
                }
                else if (number == 5)
                {
                    Console.WriteLine("five");
                }
                else if (number == 6)
                {
                    Console.WriteLine("six");
                }
                else if (number == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (number == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (number == 9)
                {
                    Console.WriteLine("nine");
                }
                else if (number == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (number == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (number == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (number == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (number == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (number == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (number == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (number == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (number == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (number == 19)
                {
                    Console.WriteLine("nineteen");
                }
            }

            if (number >= 20 && number <= 29)
            {
                dec = 20;
                Console.Write("twenty");
            }
            else if (number >= 30 && number <= 39)
            {
                dec = 30;
                Console.Write("thirty");
            }
            else if (number >= 40 && number <= 49)
            {
                dec = 40;
                Console.Write("fourty");
            }
            else if (number >= 50 && number <= 59)
            {
                dec = 50;
                Console.Write("fifty");
            }
            else if (number >= 60 && number <= 69)
            {
                dec = 60;
                Console.Write("sixty");
            }
            else if (number >= 70 && number <= 79)
            {
                dec = 70;
                Console.Write("seventy");
            }
            else if (number >= 80 && number <= 89)
            {
                dec = 80;
                Console.Write("eighty");
            }
            else if (number >= 90 && number <= 99)
            {
                dec = 90;
                Console.Write("ninety");
            }


            if (number > 10)
                {
                    temp = number - dec;
                    if (temp == 1)
                    {
                        Console.WriteLine(" one");
                    }
                    else if (temp == 2)
                    {
                        Console.WriteLine(" two");
                    }
                    else if (temp == 3)
                    {
                        Console.WriteLine(" three");
                    }
                    else if (temp == 4)
                    {
                        Console.WriteLine(" four");
                    }
                    else if (temp == 5)
                    {
                        Console.WriteLine(" five");
                    }
                    else if (temp == 6)
                    {
                        Console.WriteLine(" six");
                    }
                    else if (temp == 7)
                    {
                        Console.WriteLine(" seven");
                    }
                    else if (temp == 8)
                    {
                        Console.WriteLine(" eight");
                    }
                    else if (temp == 9)
                    {
                        Console.WriteLine(" nine");
                    }
                }
            }

            

            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
                Console.WriteLine("invalid number");
                
            }
        }
    }
