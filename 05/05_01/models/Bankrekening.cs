using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Bankrekening
    {
        // attributen
        private string _ibanNummer;
        private string _landCode;
        private double _minimum;
        private double _saldo;

        // properties
        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = LandCode + value; }
        }
        public string LandCode
        {
            get { return _landCode; }
            set { _landCode = "BE"; }
        }
        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    _saldo = Minimum;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        // constructors
        public Bankrekening(string ibanNummer, double saldo)
        {
            this.IbanNummer = ibanNummer;
            this.Saldo = saldo;
        }
        public Bankrekening() { }

        // methodes
        public void Afhalen(double bedrag)
        {
            Saldo -= bedrag;
        }
        public void Storten(double bedrag)
        {
            Saldo += bedrag;
        }
        public virtual string ToonGegevens()
        {
            return $"Rekening {IbanNummer} met saldo {Saldo}";
        }
        public override string ToString()
        {
            return $"{IbanNummer} -> Je huidig saldo bedraagt: {Saldo} euro.";
        }
    }
}
