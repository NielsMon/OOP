using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class Klant : Persoon
    {

        // Attribuut
        private string _klantencode;

        //Property
        private string Klantencode
        {
            get { return _klantencode; }
            set { _klantencode = value; }
        }

        // Constructor
        public Klant(string voornaam, string achternaam) : base(voornaam, achternaam)
        {
            MaakRandomKlantenCode();
        }

        //Methode
        private void MaakRandomKlantenCode()
        {
            string toegelatenKarakters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] klantencode = new char[16];

            Random random = new Random();

            for (int i = 0; i < klantencode.Length; i++)
            {
                klantencode[i] = toegelatenKarakters[random.Next(toegelatenKarakters.Length)];
            }
            Klantencode = new string(klantencode);
        }

        // Methode
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" mijn klanten code: {Klantencode}.";
        }
    }
}