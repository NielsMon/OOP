using System;

namespace models
{
    public class Cilinder : Cirkel
    {
        // attributen
        private double _h;

        // properties
        public double H 
        { 
            get { return _h; }
            set { _h = value; }
        }
        public override string Omschrijving
        {
            get { return base.Omschrijving + $", hoogte = {H}"; }
        }

        // constructors
        public Cilinder(double x, double y, double r, double h) : base(x, y, r) 
        { 
            this.H = h; 
        }
        public Cilinder() { }

        // methoden
        public new double Oppervlakte()
        {
            return Math.Round(2 * Math.PI * Math.Pow(R, 2) + 2 * Math.PI * R * H,2);
        }
        public double Volume()
        {
            return Math.Round(Math.PI * (R * R) * H,2);
        }
        public new string ToonGegevens()
        {
            return Omschrijving +
                $"\nOppervlakte: " + Oppervlakte() +
                $"\nVolume: " + Volume();
        }
    }
}
