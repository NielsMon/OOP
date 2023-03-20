using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Vierkant
    {
        // attributen
        private int _zijde;

        // properties
        public int Zijde
        {
            get { return _zijde; }
            set
            {
                if (value < 0)
                {
                    _zijde = 0;
                }
                else if (value > 25)
                {
                    _zijde = 25;
                }
                else
                {
                    _zijde = value;
                }
            }
        }

        // constructors
        public Vierkant(int lengte)
        {
            this.Zijde = lengte;
        }
        public Vierkant() : this(0) { }

        // methoden
        public int Omtrek()
        {
            return Zijde * 4;
        }
        public double Diagonaal()
        {
            return Math.Round((Math.Sqrt(2) * Zijde),2);
        }
        public int Oppervlakte()
        {
            return Zijde * Zijde;
        }
        public string Teken()
        {
            string output = "";  
            for (int i = 0; i < Zijde; i++)
            {
                for (int j = 0; j < Zijde; j++)
                {
                    if (j == Zijde-1)
                    {
                        output += "*";
                    }
                    else
                    {
                        output += "* ";
                    }
                    
                }
                output += "\n";
            } 
            return output;
        }
    }
}
