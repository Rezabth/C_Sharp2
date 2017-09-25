using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            var age = int.Parse(Console.ReadLine());
            if (age < 16)
            {
                Console.WriteLine("You seem to be young.");

            }

            else if (age< 18)
                {

                    Console.WriteLine("Maybe study on gynisiaum?");
                
                }

            else
            {

                Console.WriteLine("Hello");
            }



        }
    }
}