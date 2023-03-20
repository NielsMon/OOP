using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Spaarrekening : Bankrekening
    {
        // attributen
        private double _percentage;

        // properties
        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        // properties
        public Spaarrekening(string ibanNummer, double saldo) :
            base(ibanNummer, saldo){ this.Percentage = 0.05; }

        // methodes
        public void SchrijfRentebij(double bedrag)
        {
            Saldo += Saldo * Percentage;
        }
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (percentage {Percentage*100})";
        }
    }
}