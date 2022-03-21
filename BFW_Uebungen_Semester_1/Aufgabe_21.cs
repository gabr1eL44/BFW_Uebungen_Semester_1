using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_21
    {
        public static void Start()
        {
            int[] numbers = new int[0];

            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                string eingabe = Console.ReadLine().Trim();

                if (int.TryParse(eingabe, out int id))
                {
                    int[] tempArr = new int[numbers.Length + 1];
                    for (int i = 0; i < numbers.Length; i++)
                        tempArr[i] = numbers[i];
                    tempArr[numbers.Length] = id;

                    numbers = tempArr;
                }

                do
                {
                    Console.WriteLine("Soll noch eine Zahl eingegen werden (y/n)");
                    eingabe = Console.ReadLine();

                    if (eingabe == "n")
                        goto Ausgabe;
                    else if (eingabe == "y")
                        break;
                    else
                        Console.Write("Ungültige Eingabe. ");
                } while (true);
            }

            // Sprungmarke um aus Doppelschleife auszubrechen
            Ausgabe:
            int sum = 0;

            Console.WriteLine("\nIhr Ergebnis:");
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.WriteLine(sum);
            }
        }
    }
}
