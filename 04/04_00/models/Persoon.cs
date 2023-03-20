using System;

namespace models
{
    public class Persoon
    {
        // attributen
        private string _voornaam;
        private string _achternaam;

        // properties
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        // constructor
        protected Persoon(string voornaam, string achternaam)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
        }

        // methoden
        public virtual string ToonGegevens()
        {
            return $"Mijn naam is {Voornaam} {Achternaam}";
        }
    }
}
