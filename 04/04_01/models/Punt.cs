using System;

namespace models
{
    public class Punt
    {
        // atributen
        private double _x;
        private double _y;

        public double X 
        { 
            get{ return _x; }
            set{ _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        // constructor
        public Punt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Punt() {}

        // methoden
        public virtual string Omschrijving()
        {
            return $"{this.GetType().Name}: coord=({X},{Y})";
        }
        public string ToonGegevens()
        {
            return Omschrijving();
        }
    }
}
