using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D1
    {
        public static void Start()
        {
            Console.WriteLine("Flächeninhalt von (1) Rechteck (2) Dreieck (3) Kreis berechnen?");
            string mode = Console.ReadLine();

            if (mode == "1")
            {
                Console.WriteLine("Bitte geben Sie die Breite ein: ");
                int breite = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Höhe ein: ");
                int hoehe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDer Flächeninhalt des Recktecks beträgt {0}.", breite * hoehe);
            }
            else if (mode == "2")
            {
                Console.WriteLine("Bitte geben Sie die Länge der Grundseite ein: ");
                int grundseite = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Höhe ein: ");
                int hoehe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDer Flächeninhalt des Dreiecks beträgt {0}.", grundseite * hoehe / 2);
            }
            else if (mode == "3")
            {
                Console.WriteLine("Bitte geben Sie den Radius ein: ");
                int radius = Convert.ToInt32(Console.ReadLine());
                double flaeche = Math.PI * radius * radius;
                Console.WriteLine("\nDer Flächeninhalt des Kreises beträgt {0}.", Math.Round(flaeche, 2));
            }
        }
    }
}
