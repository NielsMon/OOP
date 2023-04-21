using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Plc
    {
        // atributen
        private static Licht _keukenLicht;
        private static Licht _woonkamerLicht;
        private static Verwarming _verwarming;

        // properties
        public Licht KeukenLicht
        { 
            get { return _keukenLicht;}
            set { _keukenLicht = value;}
        }
        public Licht WoonkamerLicht
        {
            get { return _woonkamerLicht; }
            set { _woonkamerLicht = value; }
        }
        public Verwarming Verwarming
        {
            get { return _verwarming; }
            set { _verwarming = value; }
        }

        // constructor
        public Plc(Licht keukenLicht, Licht woonkamerLicht, Verwarming verwarming)
        {
            this.KeukenLicht = keukenLicht;
            this.WoonkamerLicht= woonkamerLicht;
            this.Verwarming = verwarming;
        }

        // methoden
        public void DoeKeukenLichtAan()
        {
            KeukenLicht.AanUit = true;
        }
        public void DoeKeukenLichtUit()
        {
            KeukenLicht.AanUit = false;
        }
        public void DoeWoonkamerLichtAan()
        {
            WoonkamerLicht.AanUit = true;
        }
        public void DoeWoonkamerLichtUit()
        {
            WoonkamerLicht.AanUit = false;
        }
        public void ZetVerwarmingAan()
        {
            Verwarming.AanUit = true;
        }
        public void ZetVerwarmingUit()
        {
            Verwarming.AanUit = false;
        }
        public void PasTemperatuutAan(double temperatuur)
        {
            Verwarming.Graden = temperatuur;
        }
    }
}
