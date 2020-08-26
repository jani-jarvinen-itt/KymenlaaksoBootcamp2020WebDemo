using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa peliin!");

            Random random = new Random();
            int oikeaVastaus = random.Next(1, 21);
            Console.WriteLine(oikeaVastaus);

            int arvausKerrat = 0;
            while (arvausKerrat < 3)
            {
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                string arvaus = Console.ReadLine();
                int arvattuLuku = int.Parse(arvaus);

                if (arvattuLuku < oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }
                else if (arvattuLuku > oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                else
                {
                    Console.WriteLine("Oikein arvattu! Voit pelin!");
                    break;
                }

                arvausKerrat++;
            }

            Console.WriteLine("Peli päättyi.");
        }
    }
}
