using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Dier
    {
        // attributen
        private string _naam;
        private string _gegevens;

        // properties
        public string Naam 
        {
            get{ return _naam; }
            set { _naam = value; }
        }
        public virtual string Gegevens
        {
            get { return $"Mijn naam is {Naam} en ik ben een {this.GetType().Name}."; }
        }

        // constructors
        public Dier(string naam)
        {
            this.Naam = naam;
        }

        // methoden
        public virtual string Praten(string zin)
        {
            return "praten";
        }
        public virtual string Strelen()
        {
            return "strelen";
        }
        public override string ToString()
        {
            return Gegevens;
        }
        public override bool Equals(object obj)
        {
            if (obj is Dier dier)
            {
                return (this.Naam == dier.Naam) &&
                    (this.GetType() == dier.GetType());
            }
            return false;
        }

    }
}
