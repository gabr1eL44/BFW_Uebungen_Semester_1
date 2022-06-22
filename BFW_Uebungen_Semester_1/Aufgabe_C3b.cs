using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C3b
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie die aktuelle Kaninchen-Population ein: ");
            int population = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Zielpopulation ein: ");
            int maxGeneration = Convert.ToInt32(Console.ReadLine());

            int previous = 0, current = 1, counter = 0; 
            while (current + previous < maxGeneration / population)
            {
                int j = current;
                current += previous;
                previous = j;

               counter++;
               Console.Write(current * population + " ");
            }

            Console.WriteLine((current + previous) * population + " \\\\Abbruch");
            Console.WriteLine("\nEs sind {0} Schritte bis zur Zielpopulation nötig!", counter++);
        }
    }
}
