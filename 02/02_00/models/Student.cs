﻿using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Student
    {
        // atributen
        private string _naam;
        private int _scoreProgrammeren;
        private int _scoreNetwerken;

        // properties
        public string Naam 
        { 
            get { return _naam; }
            set { _naam = value; }
        }
        public int ScoreProgrammeren
        {
            get { return _scoreProgrammeren; }
            set 
            { 
                if(value < 0)
                {
                    _scoreProgrammeren = 0;
                }else if(value > 20)
                {
                    _scoreProgrammeren = 20;
                }
                else
                {
                    _scoreProgrammeren = value;
                } 
            }
        }
        public int ScoreNetwerken
        {
            get { return _scoreNetwerken; }
            set 
            {
                if (value < 0)
                {
                    _scoreNetwerken = 0;
                }
                else if (value > 20)
                {
                    _scoreNetwerken = 20;
                }
                else
                {
                    _scoreNetwerken = value;
                }
            }
        }

        // constructor
        public Student(string naam, int scoreProgrammeren, int scoreNetwerken)
        {
            this.Naam = naam;
            this.ScoreProgrammeren = scoreProgrammeren;
            this.ScoreNetwerken = scoreNetwerken;
        }
        public Student():this("", 0, 0) {}

        // methoden
        public void VoerScoreIn(int keuze, int score)
        {
            switch (keuze)
            {
                case 0:VoerScoreProgrammerenIn(score); break;
                case 1:VoerScoreNetwerkenIn(score); break;
            }
        }
        public void VoerScoreProgrammerenIn(int score)
        {
            ScoreProgrammeren = score;
        }
        public void VoerScoreNetwerkenIn(int score)
        {
            ScoreNetwerken=score;
        }
        public string ToonRapport()
        {
            string bericht = (ScoreProgrammeren >= 10 && ScoreNetwerken >= 10) ?
                "Proficiat u bent geslaagd!" : "Helaas u bent niet geslaagd!";
            return $"{Naam}\n" +
                $"{new string('-', Naam.Length)}\n" +
                $"Programmeren: {ScoreProgrammeren}\n" +
                $"Netwerken: {ScoreNetwerken}\n" +
                $"{bericht}";
        }
    }
}
