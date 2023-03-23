﻿using System;

namespace models
{
    public class Audi : Auto
    {
        // constructor
        public Audi(string nummerplaat, double aantalKilometers, double kostprijs, double literbrandstof):
            base(nummerplaat, aantalKilometers, kostprijs, literbrandstof) { }

        // methoden
        public override void Rijden(double aantalKilometer)
        {
            this.AantalKilometers += aantalKilometer;
            this.LiterBrandstof -= (aantalKilometer / 15);
        }
    }
}
