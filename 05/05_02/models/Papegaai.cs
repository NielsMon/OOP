using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Papegaai : Dier
    {
        // properties
        public override string Gegevens
        {
            get { return base.Gegevens + " Krahh, C# is leuk! Krahh! Wipo!"; }
        }

        // constructor
        public Papegaai(string naam) : base(naam) { }

        // methoden
        public override string Praten(string zin)
        {
            return $"Krahh! {zin}";
        }
        public override string Strelen()
        {
            return "Koko! koko! kokoooohh!";
        }
    }
}
