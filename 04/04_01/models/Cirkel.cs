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
        public override string Omschrijving
        {
            get { return base.Omschrijving + $" straal {R}"; }
        }

        // constructors
        public Cirkel(double x, double y, double r): base(x,y) 
        {
            this.R = r;
        }
        public Cirkel() { }

        // methoden
        public double Omtrek()
        {
            return Math.Round(2 * Math.PI * R, 2);
        }
        public override string ToonGegevens()
        {
            return Omschrijving +
                $"\nOppervlakte: " + Oppervlakte() +
                $"\nOmtrek: " + Omtrek();
        }
        public virtual double Oppervlakte()
        {
            return Math.Round(Math.PI * (R * R), 2);
        }
        
    }
}
