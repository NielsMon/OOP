using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialisatie van object
            double literBenzine = ReturnNumber("Geef hoeveelheid brandstof: ");
            double huidigeKmStand = ReturnNumber("Geef huidige kilometerstand: ");
            double vorigeKmStand = ReturnNumber("Geef kilometerstand laatste onderhoud: ");

            Auto auto = new Auto(literBenzine, huidigeKmStand, vorigeKmStand);

            // keuzemenu weergeven
            int keuze = MakeChoice();
            auto.VerwerkKeuze(keuze);

            // bewerkingen uitvoerenauto.VerwerkKeuze(keuze);
            Console.Clear();
            Console.WriteLine(auto.ControleerStatus());
        }
        private static int ReturnNumber(string message)
        {
            int number;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            return number;
        }
        private static int MakeChoice()
        {
            int keuze;
            string menu = $"Opties\n" +
                $"{new string('-', "opties".Length)}\n" +
                "0. Stoppen\n" +
                "1. Voeg 25 kilometer toe\n" +
                "2. Voeg 100 kilometer toe\n" +
                "3. Voeg 1000 kilometer toe\n" +
                "4. Vul brandstof aan\n" +
                "5. Voer onderhoud uit";
            Console.WriteLine($"{menu}\n");

            do
            {
                keuze = ReturnNumber("Geef een keuze: ");
            } while (keuze < 0 || keuze > 5);

            return keuze;
        }

    }
}
