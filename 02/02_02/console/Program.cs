using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmi bmi = new Bmi(GeefNaam(), GeefNummer("Geef een gewicht: "), GeefNummer("Geef een lengte: "));
            Console.WriteLine(bmi.ToonGegevens());
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
        private static string GeefNaam()
        {
            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();

            return naam;
        }
    }
}
