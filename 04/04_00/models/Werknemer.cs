using System;

namespace models
{
    public class Werknemer : Persoon
    {
        // attributen
        private double _loon;

        // properties
        public double Loon 
        { 
            get { return _loon; }
            set { _loon = value; }
        }

        // constructor
        public Werknemer(string voornaam, string achternaam):base(voornaam, achternaam)
        {
            this.Loon = 10.2;
        }

        // methoden
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" mijn loon bedraagt: {Loon} euro/uur.";
        }
    }
}
