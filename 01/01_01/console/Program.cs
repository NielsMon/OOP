using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjustScreen();
            Teller teller = new Teller();
            Console.WriteLine($"Keuzemenu:\n" +
                $"0: Stoppen\n" +
                $"1: Verhogen\n" +
                $"2: Verlagen\n" +
                $"3: Resetten\n");

            int keuze = EnterNumber();
            while (keuze != 0)
            {
                switch (keuze)
                {
                    case 1: teller.Verhoog(); break;
                    case 2: teller.Verlaag(); break;
                    case 3: teller.Resetten(); break;
                }
                keuze = EnterNumber();
            }

            Console.Clear();
            Console.WriteLine(teller.ToonGegevens());

            EndProgram();
        }
        public static void AdjustScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 1: oefening 1.01";
        }
        public static void EndProgram()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        public static int EnterNumber()
        {
            int number;
            string input;
            bool succes = false;
            do
            {
                Console.Write("Maak een keuze: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out number);
                if (number < 0 || number > 3)
                {
                    succes = false;
                }
            } while (!succes);
            return number;
        }
    }
}
