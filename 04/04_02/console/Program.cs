using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankrekening bankrekening;
            Spaarrekening spaarrekening;
            Zichtrekening zichtrekening;

            int keuze, saldo = 0;
            string iban = "", output = "";
            Console.WriteLine($"0. Rekening\n" +
                $"1. Spaarrekening\n" +
                $"2. Zichtrekening");

            Console.Write("Maak uw keuze: ");
            keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 0:
                    Console.Write("Geef een IBAN: ");
                    iban = Console.ReadLine();
                    Console.Write("Geef een saldo: ");
                    saldo = int.Parse(Console.ReadLine());
                    bankrekening = new Bankrekening(iban, saldo);
                    output = bankrekening.ToonGegevens();
                    break;
                case 1:
                    spaarrekening = new Spaarrekening(iban, saldo);
                    output = spaarrekening.ToonGegevens();
                    break;
                case 2:
                    Console.Write("Geef een IBAN: ");
                    iban = Console.ReadLine();
                    Console.Write("Geef een saldo: ");
                    saldo = int.Parse(Console.ReadLine());
                    zichtrekening = new Zichtrekening(iban, saldo);
                    output = zichtrekening.ToonGegevens();
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
