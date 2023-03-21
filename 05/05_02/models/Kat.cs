using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Kat : Dier
    {
       // properties
        public override string Gegevens
        {
            get { return base.Gegevens + " Miauw! Miauw!"; }
        }

        // constructor
        public Kat(string naam) : base(naam){ }

        // methoden
        public override string Praten(string zin)
        {
            return "MAAAUWWW!";
        }
        public override string Strelen()
        {
            return "RRR! RRRR! RRRRRRRR!";
        }
    }
}
