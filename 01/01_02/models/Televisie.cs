using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Televisie
    {
        // atributes
        private int _kanaal;
        private int _volume;

        // properties
        public int Kanaal
        {
            get { return _kanaal; }
            set 
            {
                if (value < 1)
                {
                    _kanaal = 1;
                }
                else if (value > 30)
                {
                    _kanaal = 30;
                }
                else
                {
                    _kanaal = value;
                }
            }
        }
        public int Volume
        {
            get { return _volume; }
            set 
            {
                if (value < 0)
                {
                    _volume = 0;
                }
                else if (value > 10)
                {
                    _volume = 10;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        // constructors
        public Televisie()
        {
            this.Kanaal = 1;
            this.Volume = 5;
        }

        // methods
        public string ToonGegevens()
        {
            return $"Kanaal: {Kanaal} - Volume: {Volume}";
        }
        public void VermeerderKanaal()
        {
            Kanaal += 1;
        }
        public void VerminderKanaal()
        {
            Kanaal -= 1;
        }
        public void VermeerderVolume()
        {
            Volume += 1;
        }
        public void VerminderVolume()
        {
            Volume -= 1;
        }
    }
}
