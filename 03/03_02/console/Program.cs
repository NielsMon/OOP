using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            double gradenCelsius = 0;
            DateTime tijdstip = DateTime.Now;
            string gradenFahrenheitToString, tijdstipToString;

            Meting meting;

            gradenCelsius = GradenCelsius();

            //Console.Write("Geef aantal graden Fahrenheit: ");
            gradenFahrenheitToString = Console.ReadLine();

            //Console.Write("Geef een tijdstip: ");
            tijdstipToString = Console.ReadLine();

            if (gradenFahrenheitToString != "")
            {
                double.TryParse(gradenFahrenheitToString, out double gradenFahrenheit);
                meting = new Meting(tijdstip, gradenFahrenheit, gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
                meting.GradenFahrenheit = gradenFahrenheit;
                meting.Tijdstip = tijdstip;
            }
            else if (tijdstipToString != "")
            {
                DateTime.TryParse(tijdstipToString, out tijdstip);
                meting = new Meting(tijdstip, gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
                meting.Tijdstip = tijdstip;
            }
            else
            {
                meting = new Meting(gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
            }

            Console.WriteLine(meting.ToonGegevens());
        }

        public static double GradenCelsius()
        {

            string invoer;
            double gradenCelsius;

            do
            {
                //Console.Write("Geef aantal graden Celsius: ");
                invoer = Console.ReadLine();
            } while (!double.TryParse(invoer, out gradenCelsius));
            return gradenCelsius;
        }

    }
}
