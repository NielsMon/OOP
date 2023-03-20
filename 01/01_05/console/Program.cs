using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(GeefNaam("Voornaam: "), GeefNaam("Naam: "), GeefPunten("Wiskunde: "), GeefPunten("Informatica: "));
            Console.Clear();
            Console.WriteLine(student.ToonGegevens());
        }
        private static int GeefPunten(string message)
        {
            string input;
            int punten;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out punten));
            return punten;
        }
        private static string GeefNaam(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
