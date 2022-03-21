using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_21
    {
        public static void Start()
        {
            int[] numbers = new int[0]; string eingabe = "y";

            while (eingabe == "y")
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                eingabe = Console.ReadLine().Trim();

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
                } while ((eingabe != "y") && (eingabe != "n"));
            }

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
