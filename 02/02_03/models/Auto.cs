using System;

namespace models
{
    public class Auto
    {
        // attributen
        private double _literBenzine;
        private double _huidigeKmStand;
        private double _vorigeKmStand;

        // properties
        public double LiterBenzine 
        { 
            get { return _literBenzine; }
            set
            {
                if (value > 60)
                {
                    _literBenzine = 60;
                }
                else if (value < 0)
                {
                    _literBenzine = 0;
                }
                else
                {
                    _literBenzine = value;
                }
            }
        }
        public double HuidigeKmStand
        {
            get { return _huidigeKmStand; }
            set
            {
                if (value < 0)
                {
                    _huidigeKmStand = 0;
                }
                else
                {
                    _huidigeKmStand = value;
                }
            }
        }
        public double VorigeKmStand
        {
            get { return _vorigeKmStand; }
            set
            {
                if (value < 0)
                {
                    _vorigeKmStand = 0;
                }
                else
                {
                    _vorigeKmStand = value;
                }
            }
        }

        // constructor
        public Auto(double literBenzine, double huidigeKmStand, double vorigeKmStand)
        {
            this.LiterBenzine=literBenzine;
            this.HuidigeKmStand=huidigeKmStand;
            this.VorigeKmStand=vorigeKmStand;
        }
        public Auto() : this(0, 0, 0) { }

        // methods
        public void VoegKmToe(double km)
        {
            LiterBenzine -= (km * 0.05);
            HuidigeKmStand += km;
        }
        public void VulBrandstofAan()
        {
            Console.Write("Geef hoeveelheid brandstof: ");
            double brandstof = double.Parse(Console.ReadLine());
            LiterBenzine += brandstof;
        }
        public void Onderhoud()
        {
            VorigeKmStand = HuidigeKmStand;
        }
        public void VerwerkKeuze(int keuze)
        {
            switch (keuze)
            {
                case 1: VoegKmToe(25); break;
                case 2: VoegKmToe(100); break;
                case 3: VoegKmToe(1000); break;
                case 4: VulBrandstofAan(); break;
                case 5: Onderhoud(); break;
            }
        }
        public string ControleerStatus()
        {
            string output = $"Status\n" +
                $"{new string('-', "status".Length)}";
            if (LiterBenzine < 10)
            {
                output += "\nVoeg Brandstof toe aub!";
            }
            if (HuidigeKmStand - VorigeKmStand >= 25000)
            {
                output += "\nEr is dringend onderhoud nodig!";
            }
            if (LiterBenzine >= 10 && HuidigeKmStand - VorigeKmStand < 25000)
            {
                output += $"\nDe auto is volledig in orde!";

            }
            return output;
        }
    }
}
