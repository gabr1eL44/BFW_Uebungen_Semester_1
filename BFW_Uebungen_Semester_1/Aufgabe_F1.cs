using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_F1
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie eine (mindestens) 4-stellige Zahl ein:");
            int zahl = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            zahl *= zahl;
            Console.WriteLine("Ausgangszahl: " + zahl);

            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 2 und 10 ein:");
            int teiler = Convert.ToInt32(Console.ReadLine());

            int counter = 0, temp = zahl;
            do
            {
                Console.Clear();
                Console.WriteLine("Ausgangszahl: " + zahl);

                temp /= teiler;
                Console.WriteLine("Zwischenergebnis " + temp);
                counter++;

                Console.ReadLine();
            } while (temp >= 1);

            Console.WriteLine("Aufgabe erfolgreich gelöst!");
            Console.WriteLine("Ausgangszahl: " + zahl);
            Console.WriteLine("Anzahl Teilungen: " + counter);
        }
    }
}
