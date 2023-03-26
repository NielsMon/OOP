using System;
using System.Collections.Generic;
using System.IO;

namespace models
{
    public class FileOperations
    {
        public static List<Memory> LeesFile(string filenaam)
        {
            List<Memory> memory = new List<Memory>();
            if (File.Exists(filenaam))
            {
                using (StreamReader streamreader = new StreamReader(filenaam))
                {
                    while (!streamreader.EndOfStream)
                    {
                        string record = streamreader.ReadLine();
                        string[] data = record.Split(';');
                        int.TryParse(data[0], out int nummer);
                        Memory item = new Memory(nummer, data[1], data[2]);
                        memory.Add(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Bestand niet gevonden!");
            }
            return memory;
        }
    }
}
