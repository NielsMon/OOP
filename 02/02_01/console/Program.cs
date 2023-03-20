using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Vierkant vierkant = new Vierkant(GeefNummer("Geef een zijde: "));
            Console.Clear();
            Console.WriteLine($"Teken:\n" +
                $"{vierkant.Teken()}\n" +
                $"Omtrek: {vierkant.Omtrek()}\n" +
                $"Oppervlakte: {vierkant.Oppervlakte()}\n" +
                $"Diagonaal: {Math.Round(vierkant.Diagonaal(), 0)}");
        }
        private static int GeefNummer(string message)
        {
            string input;
            int nummer;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out nummer));
            return nummer;
        }
    }
}
