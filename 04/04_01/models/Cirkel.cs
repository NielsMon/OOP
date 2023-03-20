using System;

namespace models
{
    public class Cirkel : Punt
    {
        // attributen
        private double _r;

        // properties
        public double R
        { 
            get { return _r; }
            set { _r = value; }
        }

        // constructors
        public Cirkel(double x, double y, double r): base(x,y) { this.R = r; }
        public Cirkel() { }

        // methoden
        public double Omtrek()
        {
            return Math.Round(2 * Math.PI * R, 2);
        }
        public override string Omschrijving()
        {
            return base.Omschrijving() + $" straal {R}\n" +
                $"Oppervlakte: " + Oppervlakte()+
                $"\nOmtrek: " + Omtrek();
        }
        public virtual string ToonGegevens()
        {
            return Omschrijving();
        }
        public virtual double Oppervlakte()
        {
            return Math.Round(Math.PI * (R * R), 2);
        }
        
    }
}
