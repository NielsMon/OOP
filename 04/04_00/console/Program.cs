using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam, achternaam;
            Klant klant;
            Werknemer werknemer;

            // Werknemer aanmaken
            voornaam = LeesStringNietLeeg("Beste werknemer, geef je voornaam: ");
            achternaam = LeesStringNietLeeg("Beste werknemer, geef je achternaam: ");

            werknemer = new Werknemer(voornaam, achternaam);
            Console.Clear();
            Console.WriteLine(werknemer.ToonGegevens());
            Console.WriteLine();
            // Klant aanmaken

            voornaam = LeesStringNietLeeg("Beste klant, geef je voornaam: ");
            achternaam = LeesStringNietLeeg("Beste klant, geef je achternaam: ");

            klant = new Klant(voornaam, achternaam);
            Console.Clear();
            Console.WriteLine(klant.ToonGegevens());
        }

        static string LeesStringNietLeeg(string vraag)
        {
            string invoer;

            do
            {
                Console.Write(vraag);
                invoer = Console.ReadLine();
            } while (string.IsNullOrEmpty(invoer));
            return invoer;
        }
    }
}
