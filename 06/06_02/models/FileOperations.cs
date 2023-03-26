using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace models
{
    public class FileOperations
    {
        // attributen
        public static string BestandCursisten = "cursisten.txt";

        // properties
        public static List<Cursist> LeesCursisten()
        {
            List<Cursist> cursisten = new List<Cursist>();

            using (StreamReader reader = new StreamReader(BestandCursisten))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    int.TryParse(data[0], out int id);
                    string voornaam = data[1];
                    string familienaam = data[2];
                    Cursist cursist = new Cursist(id, voornaam, familienaam);
                    cursisten.Add(cursist);
                }
            }

            return cursisten;
        }
    }
}
