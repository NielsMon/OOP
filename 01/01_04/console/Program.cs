using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwembad zwembad = new Zwembad(GeefNummer("Breedte: "), GeefNummer("Diepte: "),
                GeefNummer("Lengte: "), GeefNummer("Randafstand: "));
            Console.Clear();
            Console.WriteLine(zwembad.ToonGegevens());
        }
        private static double GeefNummer(string message)
        {
            string input;
            double nummer;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!double.TryParse(input, out nummer));
            return nummer;
        }
    }
}
