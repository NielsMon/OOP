using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            Televisie televisie = new Televisie();
            Console.WriteLine("Keuzemenu:\n" +
                "1: Kanaal verhogen\n" +
                "2: Kanaal verlagen\n" +
                "3: Volume verhogen\n" +
                "4: Volume verlagen\n" +
                "5: Stoppen\n");

            Console.WriteLine($"Startconfiguratie: Kanaal: {televisie.Kanaal} - Volume {televisie.Volume}");

            int keuze = MaakKeuze();

            while (keuze != 5)
            {
                switch (keuze)
                {
                    case 1: televisie.VermeerderKanaal(); break;
                    case 2: televisie.VerminderKanaal(); break;
                    case 3: televisie.VermeerderVolume(); break;
                    case 4: televisie.VerminderVolume(); break;
                }
                keuze = MaakKeuze();
            }
            Console.Clear();
            Console.WriteLine(televisie.ToonGegevens());
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Les 1: Oefening 1.02";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static int MaakKeuze()
        {
            string input;
            int nummer;
            bool succes = false;

            do
            {
                Console.Write("Maak een keuze: ");
                input = Console.ReadLine();
                succes = int .TryParse(input, out nummer);
                if (nummer < 1 || nummer > 5)
                {
                    succes = false;
                }
            } while (!succes);
            return nummer;
        }
    }
}
