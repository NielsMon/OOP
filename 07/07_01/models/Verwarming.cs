using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Verwarming
    {
        // attributen
        private static bool _aanUit;
        private static double _graden;

        // properties
        public bool AanUit
        {
            get { return _aanUit; }
            set { _aanUit = value; }
        }
        public double Graden
        {
            get { return _graden; }
            set { _graden = value; }
        }

        // constructor
        public Verwarming(bool aanUit, double graden)
        {
            this.AanUit = aanUit;
            this.Graden = graden;
        }
        public Verwarming()
        {
            this.AanUit = false;
            this.Graden = 0;
        }
    }
}
