using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C1a
    {
        public static void Start()
        {
            Console.WriteLine("[1] Umrechnen von Kilokalorien (kcal) in KiloJoule (kJ)\n[2] Umrechnen von Kilojoule (kJ) in Kilokaoorien (kcal)");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("\nBitte geben Sie die Menge der Kalorien in (kcal) ein: ");
                int kcal = Convert.ToInt32(Console.ReadLine());

                double kJ = 4.18684 * kcal;
                Console.WriteLine("{0} kcal sind genau {1} kJ.", kcal, kJ);
            }
            else if (input == "2")
            {
                Console.WriteLine("\nBitte geben Sie die Menge an Joule in (kJ) ein: ");
                int kJ = Convert.ToInt32(Console.ReadLine());

                double kcal = kJ / 4.18684;
                Console.WriteLine("{0} kJ sind genau {1} kcal.", kJ, kcal);
            }
        }
    }
}
