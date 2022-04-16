using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_22
    {
        public static void Start()
        {
            int sum = 0; int[] numbers = new int[0];

            Console.WriteLine("Bitte Zahlen eingeben und mit Enter bestätigen:");
            do
            {
                 string eingabe = Console.ReadLine().Trim();

                if (int.TryParse(eingabe, out int id))
                {
                    int[] tempArr = new int[numbers.Length + 1];
                    for (int i = 0; i < numbers.Length; i++)
                        tempArr[i] = numbers[i];
                    tempArr[numbers.Length] = id;
                    numbers = tempArr;
                }

                sum += numbers[^
                    1];
            } while (sum <= 100);

            Console.WriteLine("\nDie Summe der Eingaben: " + sum);
            Console.WriteLine("Die Anzahl der Eingaben, bis die 100 überschritten wurde: " + numbers.Length);
        }
    }
}
