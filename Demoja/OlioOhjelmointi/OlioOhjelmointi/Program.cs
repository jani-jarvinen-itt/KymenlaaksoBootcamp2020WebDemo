using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Auto oma = new Auto();
            Auto kaverin = new Auto();
            Auto naapurin = new Auto();

            oma.Väri = "punainen";
            oma.Huippunopeus = 220;
            oma.Käynnistä();

            naapurin.Väri = "harmaa";
            naapurin.Huippunopeus = 190;
            naapurin.Käynnistä();
        }
    }
}
