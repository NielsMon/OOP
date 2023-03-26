using System;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cursist> cursisten = FileOperations.LeesCursisten();

            Console.WriteLine("Cursisten");
            Console.WriteLine(new String('-', "cursisten".Length));
            PrintCursisten(cursisten);

            Console.WriteLine();

            int keuze = PrintOptions();
            switch (keuze)
            {
                case 0:
                    AddCursist(cursisten);
                    break;
                case 1:
                    DeleteCursist(cursisten);
                    break;
            }

            Console.WriteLine("\nNieuwe lijst van cursisten");
            Console.WriteLine("--------------------------");
            PrintCursisten(cursisten);
        }
        private static int PrintOptions()
        {
            string input;
            int optie;
            Console.WriteLine("Wat wil je doen?\n\n" +
                "0. Toevoegen\n" +
                "1. Verwijderen");
            do
            {
                Console.Write("\nMaak een keuze: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out optie) || optie < 0 || optie > 1);
            return optie;
        }
        private static void AddCursist(List<Cursist> cursisten)
        {
            Console.Write("Geef de voornaam van de nieuwe cursist: ");
            string voornaam = Console.ReadLine();

            Console.Write("Geef de familienaam van de nieuwe cursist: ");
            string familienaam = Console.ReadLine();

            int cursistId = cursisten.Count + 1;

            Cursist cursist = null;
            cursisten.Add(cursist = new Cursist(cursistId, voornaam, familienaam));
        }
        private static void DeleteCursist(List<Cursist> cursisten)
        {
            string input;
            int keuze;

            do
            {
                Console.Write("Geef de cursistId van de cursist die je wil verwijderen: ");
                input=Console.ReadLine();
            } while (!int.TryParse(input, out keuze) || keuze < 1 || keuze > cursisten.Count);

            cursisten.RemoveAt(--keuze);

            for (int i = 0; i < cursisten.Count; i++)
            {
                cursisten[i].CursistID = i + 1;
            }
        }
        private static void PrintCursisten(List<Cursist> cursisten) 
        {
            foreach (Cursist item in cursisten)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
