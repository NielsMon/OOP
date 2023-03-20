using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie van variabelen
            string naam, invoer;
            int scoreProgrammeren, scoreNetwerken;
            Student student;

            // initialisatie van object
            student = new Student();

            // opvragen van de naam
            do
            {
                Console.Write("Geef een naam: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(naam));

            // naam student toekennen aan object
            student.Naam = naam;

            // opvragen van de score programmeren
            do
            {
                Console.Write("Geef een score voor programmeren: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out scoreProgrammeren));

            // score programmeren toekennen
            student.VoerScoreIn(0,scoreProgrammeren);

            // opvragen van de score netwerken
            do
            {
                Console.Write("Geef een score voor netwerken: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out scoreNetwerken));

            // score programmeren toekennen
            student.VoerScoreIn(1, scoreNetwerken);

            // rapport afdrukken
            Console.WriteLine(student.ToonRapport());
        }
    }
}
