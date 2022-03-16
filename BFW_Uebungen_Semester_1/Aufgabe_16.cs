using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_16
    {
        public static void Start()
        {
            Console.WriteLine("Herzlich Willkommen!");

            Console.WriteLine("Bitte machen Sie eine Eingabe:");
            string eingabe1 = Console.ReadLine();

            if (int.TryParse(eingabe1, out int ergebnis1))
                ergebnis1 = ergebnis1 % 10;
            else
                ergebnis1 = (eingabe1.Length * 2) % 10;

            ergebnis1++;

            Console.WriteLine("Bitte machen Sie eine weitere Eingabe:");
            string eingabe2 = Console.ReadLine();

            if (int.TryParse(eingabe2, out int ergebnis2))
                ergebnis2 = ergebnis2 * 3;
            else
                ergebnis2 = (eingabe2.Length * 5) % 100;

            Console.Clear();

            var ergebnis = ergebnis2 / ergebnis1;
            Console.WriteLine("Das Ergebnis ist: {0} / {1} = {2}", ergebnis2, ergebnis1, ergebnis);
        }
    }
}
