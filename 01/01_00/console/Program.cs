using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeScreen();
            Gebruiker gebruiker = new Gebruiker();
            gebruiker.Nummer = VraagNummer();
            gebruiker.Voornaam = VraagNaam("Geef een voornaam: ");
            gebruiker.Familienaam = VraagNaam("Geef een familienaam: ");
            Console.WriteLine(gebruiker.ToonGegevens());
            EndProgram();
        }
        public static void ChangeScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 1: Oefening 0";
        }
        public static void EndProgram()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        public static string VraagNaam(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
        public static int VraagNummer()
        {
            string input;
            int number;
            do
            {
                Console.Write("Geef een nummer: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            return number;
        }
    }
}
