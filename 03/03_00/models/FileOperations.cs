using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace models
{
    public static class FileOperations
    {
        // statische atributen
        public static string BestandStudenten = "studenten.txt";
        public static string BestandScores = "scores.txt";

        // statische methoden
        public static List<string> StudentenLezen()
        {
            List<string> studenten = new List<string>();
            using (StreamReader reader = new StreamReader(BestandStudenten))
            {
                while (!reader.EndOfStream)
                {
                    studenten.Add(reader.ReadLine());
                }
            }
            return studenten;
        }
        public static List<int> ScoresLezen()
        {
            List<int> scores = new List<int>();
            string input;
            int score;
            using (StreamReader reader=new StreamReader(BestandScores))
            {
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                    if (int.TryParse(input, out score))
                    {
                        scores.Add(score);
                    }
                }
            }
            return scores;
        }
    }
}
