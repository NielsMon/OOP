using System;

namespace models
{
    public class Punt
    {
        // atributen
        private double _x;
        private double _y;
        public string _omschrijving;

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
        public virtual string Omschrijving
        {
            get { return this.GetType().Name + $": coord=({X},{Y})"; }
        }

        // constructor
        public Punt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Punt() {}

        // methoden
        public virtual string ToonGegevens()
        {
            return Omschrijving;
        }
    }
}
