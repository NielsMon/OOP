using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Gebruiker
    {
        // atributen
        private int _nummer;
        private string _voornaam;
        private string _familienaam;

        // properties
        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value;}
        }

        // constructor
        public Gebruiker()
        {
            this.Nummer = 0;
            this.Voornaam = "";
            this.Familienaam = "";
        }

        // methoden
        public void Wissen()
        {
            this.Nummer = 0;
            this.Voornaam = "";
            this.Familienaam = "";
        }

        public string ToonGegevens()
        {
            return $"{Nummer} - {Voornaam} {Familienaam}";
        }
    }
}
