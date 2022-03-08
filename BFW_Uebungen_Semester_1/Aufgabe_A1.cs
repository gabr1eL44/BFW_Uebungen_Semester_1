using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_A1
    {
        public static void Start()
        {
            do
            {
                Console.Write("Bitte geben Sie die erste Farbe ein : ");
                string farbe1 = Console.ReadLine().Trim().ToLower();

                Console.Write("Bitte geben Sie die zweite Farbe ein: ");
                string farbe2 = Console.ReadLine().Trim().ToLower();

                if (((farbe1 == "blau") || (farbe2 == "blau")) && ((farbe1 == "rot") || (farbe2 == "rot")))
                {
                    Console.WriteLine("\nIhre Mischfarbe ist Lila!");
                    break;
                }

                else if (((farbe1 == "gelb") || (farbe2 == "gelb")) && ((farbe1 == "rot") || (farbe2 == "rot")))
                {
                    Console.WriteLine("\nIhre Mischfarbe ist Orange!");
                    break;
                }

                else if (((farbe1 == "gelb") || (farbe2 == "gelb")) && ((farbe1 == "blau") || (farbe2 == "blau")))
                {
                    Console.WriteLine("\nIhre Mischfarbe ist Grün!");
                    break;
                }

                else if (farbe1 == farbe2)
                    Console.WriteLine("\nBitte geben Sie zwei verschiedene Farben ein!\n");
                else
                    Console.WriteLine("\nFehlerhafte Eingabe. Bitte nur Grundfarben (blau/gelb/rot) eingeben!\n");
            } while (true);
            
        }
    }
}