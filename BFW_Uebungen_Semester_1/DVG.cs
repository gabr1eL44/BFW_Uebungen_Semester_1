using System;

namespace BFW_Uebungen_Semester_1
{
    class DVG
    {
        public static void Start()
        {
            // Aufgabe 2
            int[] numbers = new int[] { 0, 10, 12, 4, 7, 20, 21, 13 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 13)
                {
                    Console.WriteLine("Die gesuchte Zahl 13 befindet sich an {0}. Stelle", i + 1);
                    break;
                }
            }

            Console.WriteLine("\nBitte eine beliebige Taste drücken, um das Programm fortzusetzen!");
            Console.ReadKey();
            Console.Clear();

            // Aufgabe 3
            int[] messwerte = new int[5];
            for (int i = 0; i < messwerte.Length; i++)
            {
                Console.WriteLine("Bitte geben Sie den {0}. Messwert ein: ", i + 1);
                int.TryParse(Console.ReadLine(), out messwerte[i]);
            }

            // Ähnlich wie in Aufgabe 19 in C# bei Hr. Schüler
            int biggest = messwerte[0];
            for (int i = 1; i < messwerte.Length; i++)
            {
                if (messwerte[i] > biggest)
                    biggest = messwerte[i];
            }
            Console.WriteLine("\nDer höchste Messwert beträgt: " + biggest);

            Console.WriteLine("\nBitte eine beliebige Taste drücken, um das Programm fortzusetzen!");
            Console.ReadKey();
            Console.Clear();

            // Aufgabe 4 (diese muss nicht gemacht werden!!)
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

            Console.WriteLine("!!Abbruchbedingung erreicht!!\n");
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

            // Aufgabe 5
            int zahl, teiler = 2, anzahl = 0;

            do
            {
                Console.WriteLine("Zahl 1 größer 1 eingeben:");
                int.TryParse(Console.ReadLine(), out zahl);

                if (zahl <= 1)
                    Console.WriteLine("Die Zahl muss größer 1 sein\n");
            } while (zahl <= 1);

            Console.Write(zahl + "=");

            while (teiler < zahl)
            {
                if (zahl % teiler != 0)
                    teiler++;
                else
                {
                    zahl /= teiler;
                    if (anzahl > 0)
                        Console.Write("*");
                                           
                    anzahl++;
                    Console.Write(teiler);
                }
            }
            if (anzahl == 0)
                Console.WriteLine("Primzahl");
            else
                Console.WriteLine("*" + teiler);
        }
     }
}
