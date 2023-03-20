using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Student
    {
        // atributen
        private int _wiskunde;
        private int _informatica;
        private string _naam;
        private string _voornaam;

        // properties
        public int Wiskunde
        {
            get { return _wiskunde; }
            set 
            {
                if (value < 0)
                {
                    _wiskunde = 0;
                }
                else if (value > 20)
                {
                    _wiskunde = 20;
                }
                else
                {
                    _wiskunde = value;
                }
            }
        }
        public int Informatica
        {
            get { return _informatica; }
            set
            {
                if (value < 0)
                {
                    _informatica = 0;
                }
                else if (value > 20)
                {
                    _informatica = 20;
                }
                else
                {
                    _informatica = value;
                }
            }
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        // constructor
        public Student(string voornaam, string naam, int wiskunde, int informatica)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
            this.Wiskunde = wiskunde;
            this.Informatica = informatica;
        }

        // methoden
        public string ToonGegevens()
        {
            return $"{Voornaam} {Naam}\n" +
                $"Wiskunde: {Wiskunde}\n" +
                $"Informatica: {Informatica}";
        }
    }
}
