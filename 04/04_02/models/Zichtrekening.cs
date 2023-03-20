using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zichtrekening : Bankrekening
    {
        private string _rekeningnr;

        public string Rekeningnr { get; set; }
        public Zichtrekening(string rekeningnummer, double saldo) :
            base(rekeningnummer, saldo)
        { 
            this.Rekeningnr = rekeningnummer;
            this.Minimum = -100;
        }
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (Minimum {Minimum})";
        }
    }
}
