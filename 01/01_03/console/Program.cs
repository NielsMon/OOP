using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Boek boek = new Boek();
            Console.Write("Titel: ");
            boek.Titel = Console.ReadLine();
            Console.Write("Auteur: ");
            boek.Auteur = Console.ReadLine();
            boek.Bladzijden = GeefNummer("Bladzijden: ");
            int blzPerDag = GeefNummer("Bladzijden per dag: ");
            Console.WriteLine($"Het boek {boek.Titel} van {boek.Auteur} zou " +
                $"{Math.Ceiling((double)(boek.Bladzijden)/(double)(blzPerDag))} dagen duren om uit te lezen.");
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
