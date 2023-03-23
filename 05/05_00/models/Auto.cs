using System;

namespace models
{
    public class Auto
    {
        // attributen
        private string _nummerplaat;
        private double _aantalKilometers;
        private double _kostPrijs;
        private double _literBrandstof;

        // # betekent protected!! attributen blijven private, properties worden protected!!

        // properties
        protected string Merk // GetType().Name >> is enkel een get, set is overbodig
        {
            get { return this.GetType().Name ; }
        }
        protected string Nummerplaat
        {
            get { return _nummerplaat; }
            set { _nummerplaat = value;}
        }
        protected double AantalKilometers
        {
            get { return _aantalKilometers;}
            set { _aantalKilometers = (double)value; }
        }
        protected double KostPrijs
        {
            get { return _kostPrijs; }
            set { _kostPrijs = (double)value; }
        }
        protected double LiterBrandstof
        {
            get { return _literBrandstof;}
            set { _literBrandstof = (double)value; }
        }

        // constructors
        public Auto(string nummerplaat, double aantalKilometers, double kostprijs, double literbrandstof)
        {
            this.Nummerplaat = nummerplaat;
            this.AantalKilometers=aantalKilometers;
            this.KostPrijs = kostprijs;
            this.LiterBrandstof=literbrandstof;
        }

        // methoden
        public virtual void Rijden(double aantalKilometer)
        {
            this.AantalKilometers += aantalKilometer;
            this.LiterBrandstof -= (aantalKilometer / 20);
        }
        public override string ToString()
        {
            return $"Ik ben een {this.Merk} met nummerplaat {this.Nummerplaat} ({Math.Round(this.AantalKilometers,2)} km - {this.LiterBrandstof:N2} liter)\nKostprijs: {this.KostPrijs} euro";
        }
        public override bool Equals(object obj)
        {
            if (obj is Auto auto)
            {
                return (this.Nummerplaat == auto.Nummerplaat) && this.GetType() == auto.GetType();
            }
            return false;
        }
        public override int GetHashCode() // enkel om een foutmelding bij Auto te voorkomen in codegrade
        {
            return base.GetHashCode();
        }
    }
}
