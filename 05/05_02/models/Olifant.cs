using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Olifant : Dier
    {
        // properties
        public override string Gegevens
        {
            get { return base.Gegevens + " Pfwww! STOMP!"; }
        }

        // constructor
        public Olifant(string naam) : base(naam) { }

        // methoden
        public override string Praten(string zin)
        {
            return "Pfwwwwwww!";
        }
        public override string Strelen()
        {
            return "STOMP! STOMP! STOMP!";
        }
    }
}
