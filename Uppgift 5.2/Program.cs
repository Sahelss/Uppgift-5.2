using System;

namespace Uppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 3 heltal");
            int[] nmr = new int[3];

            nmr[0] = int.Parse(Console.ReadLine());
            nmr[1] = int.Parse(Console.ReadLine());
            nmr[2] = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Här är dina 3 heltal plusade med varandra: " + (nmr[0] + nmr[1] + nmr[2]));
            }
        }
    }
}

