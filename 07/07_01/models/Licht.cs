using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Licht
    {
        // attributen
        private static bool _aanUit;

        // properties
        public bool AanUit 
        { 
            get { return _aanUit; }
            set { _aanUit = value; }
        }

        // constructor
        public Licht(bool aanUit)
        {
            this.AanUit = aanUit;
        }
    }
}
