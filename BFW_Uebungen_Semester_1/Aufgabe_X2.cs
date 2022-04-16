using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_X2
    {
        public static void Start()
        {
            const int n = 100;
            int[] zahlen = new int[n];

            // Initialisierung des Zahlenstrahls
            for (int i = 0; i < zahlen.Length; i++)
                zahlen[i] = i + 1;

            int currentIndex = 1, square, durchgang = 0;
            do
            {
                Console.WriteLine(durchgang++ + ". Durchgang:");
                for (int j = 0; j < zahlen.Length; j++)
                {
                    Console.Write(zahlen[j] + " ");
                }
                Console.WriteLine("\n");

                for (int j = currentIndex + 1; j < zahlen.Length; j++)
                {
                    if (zahlen[j] % zahlen[currentIndex] == 0)
                        zahlen[j] = 0;
                }

                square = zahlen[currentIndex] * zahlen[currentIndex];

                do
                {
                    if (currentIndex == zahlen.Length)
                        break;
                    currentIndex++;
                } while (zahlen[currentIndex] == 0);

            } while (square <= n);

            Console.WriteLine("Abbruchbedingung erreicht!\n");
            Console.WriteLine("================================");
            Console.Write("Die gesuchten Primzahlen lauten: ");
            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] > 1)
                    Console.Write(zahlen[i] + " ");
            }
            Console.WriteLine("\n================================");

            Console.WriteLine("\nBitte eine beliebige Taste drücken, um das Programm fortzusetzen!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
