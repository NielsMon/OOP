using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Cursist
    {
        // attributen
        private int _cursistID;
        private string _voornaam;
        private string _familienaam;
        private string _naam;

        // properties
        public int CursistID
        {
            get { return _cursistID; }
            set { _cursistID = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Familienaam
        {
            get { return _familienaam;}
            set { _familienaam = value;}
        }
        public string Naam
        {
            get { return $"{Voornaam} {Familienaam}";}
        }

        // constructos
        public Cursist(int cursistId, string voornaam, string familienaam)
        {
            this.CursistID = cursistId;
            this.Voornaam = voornaam;
            this.Familienaam=familienaam;
        }

        public override string ToString()
        {
            return $"{CursistID}. {Naam}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
