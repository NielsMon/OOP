using System;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TvKanaal> kanaal = new List<TvKanaal>();

            TvKanaal een = new TvKanaal(1, "Een");
            TvKanaal canvas = new TvKanaal(2, "Canvas");
            TvKanaal vtm = new TvKanaal(3, "VTM");
            TvKanaal tweeBe = new TvKanaal(4, "2BE");
            TvKanaal vier = new TvKanaal(5, "Vier");
            
            kanaal.Add(een);
            kanaal.Add(canvas);
            kanaal.Add(vtm);
            kanaal.Add(tweeBe);
            kanaal.Add(vier);

            foreach (TvKanaal post in kanaal)
            {
                Console.WriteLine(post.Omschrijving);
            }

            Console.Write("\nVan welk kanaal wil je het nummer tonen? ");
            string input = Console.ReadLine();

            int kanaalNummer = 0;
            foreach (TvKanaal post in kanaal)
            {
                if (post.Omschrijving.ToLower() == input.ToLower())
                {
                    kanaalNummer = post.Nummer;
                }
            }

            Console.WriteLine($"Nummer van het kanaal is {kanaalNummer}");
        }
    }
}
