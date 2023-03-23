using System;

namespace models
{
    public class Volkswagen : Auto
    {
        // constructor
        public Volkswagen(string nummerplaat, double aantalKilometers, double kostprijs, double literbrandstof) :
            base(nummerplaat, aantalKilometers, kostprijs, literbrandstof)
        { }

        // methoden
        public override void Rijden(double aantalKilometer)
        {
            this.AantalKilometers += aantalKilometer;
            this.LiterBrandstof -= (aantalKilometer / 25);
        }
    }
}
