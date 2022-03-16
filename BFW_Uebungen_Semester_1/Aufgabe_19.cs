using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19
    {
        public static void Start()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Bitte geben Sie die {0}. Zahl ein:", i+1);
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int number))
                    numbers[i] = number;
                else
                    numbers[i] = -1;
            }

            int sum = numbers[0];
            int biggest = numbers[0]; int smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] > biggest)
                    biggest = numbers[i];
                else if (numbers[i] < smallest)
                    smallest = numbers[i];
            }

            int average = sum / numbers.Length;

            Console.WriteLine("\nDie Summe der Zahlen: " + sum);
            Console.WriteLine("Die größte Zahl: " + biggest);
            Console.WriteLine("Die kleinste Zahl: " + smallest);
            Console.WriteLine("Der Mittelwert: " + average);
        }
    }
}
