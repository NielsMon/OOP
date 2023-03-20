using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenSetup();
            double optie = GeefOpties ();

            double lengte, breedte, hoogte, straal, resultaat;
            string output = "";
            switch (optie)
            {
                case 0:
                    lengte = VraagWaarde("Geef een lengte: ");
                    breedte = VraagWaarde("Geef een breedte: ");
                    resultaat = MeetkundigeFormules.OppervlakteRechthoek(lengte, breedte);
                    output = $"De oppervlakte van de rechthoek is: {Math.Round(resultaat,2)} cm²";
                    break;
                case 1:
                    straal = VraagWaarde("Geef een straal: ");
                    resultaat = MeetkundigeFormules.OppervlakteCirkel(straal);
                    output = $"De oppervlakte van de cirkel is: {Math.Round(resultaat, 2)} cm²";
                    break;
                case 2:
                    lengte = VraagWaarde("Geef een lengte: ");
                    breedte = VraagWaarde("Geef een breedte: ");
                    hoogte = VraagWaarde("Geef een hoogte: ");
                    resultaat = MeetkundigeFormules.VolumeBalk(lengte, breedte, hoogte);
                    output = $"De volume van de balk is: {Math.Round(resultaat, 2)} cm²";
                    break;
                case 3:
                    straal = VraagWaarde("Geef een straal: ");
                    hoogte = VraagWaarde("Geef een hoogte: ");
                    resultaat = MeetkundigeFormules.VolumeCilinder(straal, hoogte);
                    output = $"De volume van de cilinder is: {Math.Round(resultaat, 2)} cm²";
                    break;
            }
            Console.Clear();
            Console.WriteLine(output);
        }
        private static void ScreenSetup()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 3.01";
        }
        private static double VraagWaarde(string message)
        {
            double output;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!double.TryParse(input, out output));
            return output;
        }
        private static int GeefOpties()
        {
            Console.WriteLine($"Opties\n" + $"{new string('-', "opties".Length)}\n\n" + $"0. Oppervlakte rechthoek\n" + $"1. Oppervlakte cirkel\n" + $"2. Volume balk\n" + $"3. Volume cilinder\n");
            return (int)(VraagWaarde("Geef een optie: "));
        }

    }
}
