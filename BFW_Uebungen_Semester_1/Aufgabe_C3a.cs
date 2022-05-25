using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C3a
    {
        public static void Start()
        {
            Console.WriteLine("Bis zu welcher Zahl soll die Fibonacci-Reihe berechnet werden?");
            int max = Convert.ToInt32(Console.ReadLine());

            int previous = 0, current = 1;
            Console.Write("0 ");

            while (current + previous <= max)
            {
                int j = current;
                current += previous;
                previous = j;
                Console.Write(current + " ");
            }

            Console.WriteLine("\n\nBitte drücken Sie eine beliebige Taste, um fortzufahren!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Welche Zahl möchten Sie prüfen?");
            int zahl = Convert.ToInt32(Console.ReadLine());

            previous = 0; current = 1; bool fibonacci = false;
            if ((zahl == 0) || (zahl == 1))
                fibonacci = true;

            while ((current + previous <= zahl) && (!fibonacci))
            {
                int j = current;
                current += previous;
                previous = j;

                if (zahl == current)
                    fibonacci = true;
            }

            if (fibonacci)
                Console.WriteLine("Die Zahl {0} ist in der Fibonacci-Folge enthalten!", zahl);
            else
                Console.WriteLine("Ihre Zahl ist leider nicht enthalten.");
        }
    }
}
