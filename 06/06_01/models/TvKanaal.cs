using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class TvKanaal
    {
        // attributen
        private int _nummer;
        private string _omschrijving;

        // properties
        public int Nummer
        { 
            get { return _nummer; }
            set { _nummer = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value;}
        }

        // constructor
        public TvKanaal(int nummer, string omschrijving)
        {
            this.Nummer = nummer;
            this.Omschrijving = omschrijving;
        }
        public TvKanaal():this(0,"") { }

        // methoden
        public override string ToString()
        {
            return $"Nummer van het kanaal is {Nummer}";
        }
    }
}
