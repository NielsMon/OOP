using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Teller
    {
        // atributes
        private int _waarde;

        // properties
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }

        // constructor
        public Teller()
        {
            this.Waarde = 0;
        }

        // methods
        public void Verhoog()
        {
            Waarde += 1;
        }
        public void Verlaag()
        {
            Waarde -= 1;
        }
        public void Resetten()
        {
            this.Waarde = 0;
        }
        public string ToonGegevens()
        {
            return $"De waarde van de teller is {Waarde}.";
        }
    }
}
