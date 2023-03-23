using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen
            string invoer;
            int keuzeAuto, keuzeActie, aantalKilometer;

            string actieBoodschap = $"Acties\n" +
                $"{new string('*', "acties".Length)}\n" +
                $"0. Testrit maken\n" +
                $"1. Details tonen";

            // objecten
            Audi audi = new Audi("1-lvn-568", 25000, 7500, 25);
            Volkswagen vw = new Volkswagen("1-sej-454", 100000, 5500, 10);
            Bmw bmw = new Bmw("1-hbj-298", 500, 12500, 44);

            Auto auto = null;

            string output = $"Auto's\n" + $"{new string('*', "auto's".Length)}\n" + $"0. Stoppen\n" + $"1. Audi (1-lvn-568)\n" + $"2. Volkswagen (1-sej-454)" + $"\n3. BMW (1-hbj-298)";
            Console.WriteLine(output);

            keuzeAuto = EnterNumber("Kies een auto: ", 0, 3);
            while (keuzeAuto != 0)
            {
                switch (keuzeAuto)
                {
                    case 1:
                        auto = audi;
                        break;
                    case 2:
                        auto = vw;
                        break;
                    case 3:
                        auto = bmw;
                        break;
                }

                
                Console.WriteLine(actieBoodschap);
                keuzeActie = EnterNumber("Kies een actie: ", 0, 1);

                switch (keuzeActie)
                {
                    case 0:
                        aantalKilometer = EnterNumber("Geef aantal kilometer: ", 0);
                        auto.Rijden(aantalKilometer);
                        break;
                    case 1:
                        Console.WriteLine(auto.ToString());
                        break;
                }

                Console.WriteLine(output);


                keuzeAuto = EnterNumber("Kies een auto: ", 0, 3);
            }
            //Console.WriteLine(actieBoodschap);
        }
        private static int EnterNumber(string message, int min, int max)
        {
            int number;
            string input;
            bool succes = false;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
                succes = int.TryParse(input, out number);
                if (number < min || number > max)
                {
                    succes = false;
                }
            } while (!succes);
            return number;
        }
        private static int EnterNumber(string message, int min)
        {
            int number;
            string input;
            bool succes = false;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
                succes = int.TryParse(input, out number);
                if (number < min)
                {
                    succes = false;
                }
            } while (!succes); ;
            return number;
        }
    }
}
