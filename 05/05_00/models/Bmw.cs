using System;

namespace models
{
    public class Bmw : Auto
    {
        // constructor
        public Bmw(string nummerplaat, double aantalKilometers, double kostprijs, double literbrandstof) :
            base(nummerplaat, aantalKilometers, kostprijs, literbrandstof)
        { }

        // methoden
        public override void Rijden(double aantalKilometer)
        {
            base.Rijden(aantalKilometer);
        }
    }
}
