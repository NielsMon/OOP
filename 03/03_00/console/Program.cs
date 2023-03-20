using System;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen
            int optie;
            List<string> studenten;
            List<int> scores;

            optie = VraagOptieOp();
            studenten = FileOperations.StudentenLezen();
            scores = FileOperations.ScoresLezen();

            Console.Clear();

            switch (optie)
            {
                case 0: DrukStudentenAf(studenten); break;
                case 1: DrukScoresAf(scores); break;
                case 2: DrukStudentenMetScoresAf(scores, studenten); break;
            }

            

        }

        private static void DrukStudentenAf(List<string> studenten)
        {
            string uitvoer = $"Studenten\n" +
                $"{new string('-', "studenten".Length)}\n";
            foreach(string student in studenten)
            {
                uitvoer += $"\n{student}";
            }
            Console.WriteLine(uitvoer);
        }
        private static void DrukScoresAf(List<int> scores)
        {
            string uitvoer = $"Scores\n" +
                $"{new string('-', "scores".Length)}\n";
            foreach (int score in scores)
            {
                uitvoer += $"\n{score}";
            }
            Console.WriteLine(uitvoer);
        }
        private static void DrukStudentenMetScoresAf(List<int> scores, List<string> studenten)
        {
            string uitvoer = $"Studenten met scores\n" +
                $"{new string('-', "Studenten met scores".Length)}\n";
            for (int i = 0; i < studenten.Count; i++)
            {
                uitvoer += $"\n{studenten[i]} ({scores[i]})";
            }
            Console.WriteLine(uitvoer);
        }

        private static int VraagOptieOp()
        {
            int optie;
            string invoer;
            do
            {
                Console.WriteLine($"Opties\n" +
                    $"{new string('-', "opties".Length)}\n\n" +
                    $"0. Studenten\n" +
                    "1. Scores\n" +
                    "2. Studenten met scores");
                Console.Write("\nGeef een keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out optie) || optie < 0 || optie > 2);
            return optie;
        }
    }
}
