using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19b
    {
        public static void Start()
        {
            int[] numbers = new int[] { 64, 32, 16, 48, 2 };

            do
            {
                Console.Write("Liste (a)usgeben, Element (h)inzufügen, Liste (l)eeren, Programm (b)eenden?");
                char input = Console.ReadKey().KeyChar;

                switch (input)
                {
                    case 'a':
                        Console.WriteLine();
                        for (int i = 0; i < numbers.Length; i++)
                            Console.Write(numbers[i] + " ");
                        Console.WriteLine(": Länge({0})", numbers.Length);
                        break;
                    case 'h':
                        Console.Write("\nBitte geben Sie eine neue Zahl ein: ");
                        int[] tempArr = new int[numbers.Length + 1];
                        for (int i = 0; i < numbers.Length; i++)
                            tempArr[i] = numbers[i];
                        int.TryParse(Console.ReadLine().Trim(), out tempArr[numbers.Length]);
                        numbers = tempArr;
                        break;
                    case 'l':
                        int[] emptyArr = new int[0];
                        numbers = emptyArr;
                        Console.WriteLine();
                        break;
                    case 'b':
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
            } while (true);
        }
    }
}
