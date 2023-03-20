using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Boek
    {
        // attributen
        private string _titel;
        private string _auteur;
        private int _bladzijden;

        // properties
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        public int Bladzijden
        {
            get { return _bladzijden;}
            set { _bladzijden = value;}
        }

        // constructor
        public Boek()
        {
            this.Titel = "";
            this.Auteur = "";
            this.Bladzijden = 0;
        }
    }
}
