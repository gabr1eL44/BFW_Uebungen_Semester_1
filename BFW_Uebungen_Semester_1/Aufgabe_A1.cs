using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_A1
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie die erste Farbe ein: ");
            string farbe1 = Console.ReadLine().Trim().ToLower();

            Console.Write("Bitte geben Sie die zweite Farbe ein: ");
            string farbe2 = Console.ReadLine().Trim().ToLower();

            if (((farbe1 == "blau") || (farbe2 == "blau")) && ((farbe1 == "rot") || (farbe2 == "rot")))
                Console.WriteLine("Ihre Mischfarbe ist Lila!");

            else if (((farbe1 == "gelb") || (farbe2 == "gelb")) && ((farbe1 == "rot") || (farbe2 == "rot")))
                Console.WriteLine("Ihre Mischfarbe ist Orange!");

            else if (((farbe1 == "gelb") || (farbe2 == "gelb")) && ((farbe1 == "blau") || (farbe2 == "blau")))
                Console.WriteLine("\nIhre Mischfarbe ist Grün!");

            else
                Console.WriteLine("\nFehlerhafte Eingabe bzw. geben Sie zwei verschiedene Farben ein!");
        }
    }
}