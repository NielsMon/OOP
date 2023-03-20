using System;

namespace models
{
    public class Bmi
    {
        // properties
        public double Gewicht { get; set; }
        public double Lengte { get; set; }
        public string Naam { get; set; }

        // constructors
        public Bmi(string naam, double weight, double length)
        {
            this.Naam = naam;
            this.Gewicht = weight;
            this.Lengte = length;
        }
        public Bmi() : this("", 0, 0) { }

        // methods
        public double BerekenBmi()
        {
            return Math.Round(Gewicht/(Lengte*Lengte),1);
        }
        public string ToonGegevens()
        {
            return $"{Naam} weegt {Gewicht} kg en is {Lengte} m groot. De BMI is {BerekenBmi()}.";
        }
    }
}
