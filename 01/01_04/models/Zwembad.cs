using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zwembad
    {
        // atributen
        private double _breedte;
        private double _diepte;
        private double _lengte;
        private double _randafstand;

        // properties
        public double Breedte
        {
            get { return _breedte; }
            set 
            {
                if (value < 0)
                {
                    _breedte = 0;
                }
                else
                {
                    _breedte = value;
                }
            }
        }
        public double Diepte
        {
            get { return _diepte; }
            set 
            {
                if (value < 0)
                {
                    _diepte = 0;
                }
                else
                {
                    _diepte = value;
                }
            }
        }
        public double Lengte
        {
            get { return _lengte; }
            set 
            {
                if (value < 0)
                {
                    _lengte = 0;
                }
                else
                {
                    _lengte = value;
                }
            }
        }
        public double Randafstand
        {
            get { return _randafstand; }
            set
            {
                if (value < 0 || Randafstand >= Diepte)
                {
                    _randafstand = 0;
                }
                else
                {
                    _randafstand = value;
                }
            }
        }

        // constructor
        public Zwembad(double breedte, double diepte, double lengte, double randafstand)
        {
            this.Breedte = breedte;
            this.Diepte = diepte;
            this.Lengte = lengte;
            this.Randafstand = randafstand;
        }

        // methoden
        public double LiterWater()
        {
            return Breedte * Lengte * (Diepte - Randafstand) * 1000;
        }
        public string ToonGegevens()
        {
            return $"Diepte = {Diepte}\n" +
                $"Breedte = {Breedte}\n" +
                $"Lengte = {Lengte}\n" +
                $"Randafstand = {Randafstand}\n\n" +
                $"Liters water = {LiterWater()}";
        }
    }
}
