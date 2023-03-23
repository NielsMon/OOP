using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankrekening rekening = null;

            int keuze, saldo = 0, handeling;
            string iban = "BE12 3456 7890 1234";
            Boolean stop = false;

            keuze = MaakEenKeuze();

            switch (keuze)
            {
                case 1:
                    rekening = new Spaarrekening(iban, saldo);
                    break;
                case 2:
                    rekening = new Zichtrekening(iban, saldo);
                    break;
            }

            
            handeling = KiesEenOptie();

            while (!stop)
            {
                switch (handeling)
                {
                    case 1:
                        Afhalen(rekening);
                        handeling = KiesEenOptie();
                        break;
                    case 2:
                        Storten(rekening);
                        handeling = KiesEenOptie();
                        break;
                    case 3:
                        SchrijfRenteBij();
                        handeling = KiesEenOptie();
                        break;
                    case 4:
                        Console.WriteLine(rekening.ToString());
                        stop = true;
                        break;
                }
            }

            
        }
        private static int MaakEenKeuze()
        {
            int optie;
            string input;

            Console.WriteLine($"" +
                $"1. Spaarrekening\n" +
                $"2. Zichtrekening");

            do
            {
                Console.Write("Kies een optie: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out optie) || optie < 1 || optie > 2);
            return optie;
        }
        private static int KiesEenOptie()
        {
            int optie;
            string input;

            Console.WriteLine("" +
                "1. Afhalen\n" +
                "2. Storten\n" +
                "3. Schrijf rente bij\n" +
                "4. Informatie");

            do
            {
                Console.Write("Kies een optie: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out optie) || optie < 1 || optie > 4);
            return optie;
        }
        private static void Afhalen(Bankrekening rekening)
        {
            Console.Write("Hoeveel wil je afhalen: ");
            double bedrag = double.Parse(Console.ReadLine());
            if (bedrag <= 0)
            {
                Console.WriteLine("Het af te halen bedrag moet groter zijn dan 0");
            }
            else if (rekening.Saldo - bedrag < rekening.Minimum)
            {
                Console.WriteLine("Je hebt niet genoeg saldo om deze opdracht te verwerken...");
            }
            else
            {
                rekening.Afhalen(bedrag);
            }
        }
        private static void Storten(Bankrekening rekening)
        {
            Console.Write("Hoeveel wil je storten: ");
            double bedrag = double.Parse(Console.ReadLine());
            if (bedrag <= 0)
            {
                Console.WriteLine("Het te storten bedrag moet groter zijn dan 0");
            }
            else
            {
                rekening.Storten(bedrag);
            }
        }
        private static void SchrijfRenteBij()
        {
            Console.WriteLine("Schrijf rente bij");
        }
    }
}
