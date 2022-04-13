using System;


namespace BFW_Uebungen_Semester_1
{
    class Schulaufgabe
    {
        public static void Start()
        {
            int anzahl;
            do
            {
                Console.WriteLine("Wie viele Zahlen möchten Sie addieren?");
            } while (!int.TryParse(Console.ReadLine(), out anzahl));

            int[] numbers = new int[anzahl];

            Console.WriteLine();

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Bitte geben Sie die {0}. Zahl ein: ", i + 1);
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            int sum = 0;
            for (int i = 0; i < anzahl; i++)
                sum += numbers[i];

            Console.Clear();

            Console.WriteLine("Die Summe Ihrer {0} Zahlen beträgt {1}.", anzahl, sum);

            if (sum % 2 == 0)
                Console.WriteLine("Diese Summe ist gerade!");
            else
                Console.WriteLine("Diese Summe ist ungerade!");
        }
    }
}
