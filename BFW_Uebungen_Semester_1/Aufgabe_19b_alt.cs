using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19b_alt
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
                        if (int.TryParse(Console.ReadLine(), out int zahl))
                            Array.Add(ref numbers, zahl);
                        else
                            Console.WriteLine("Fehlerhafte Eingabe!");
                        break;
                    case 'l':
                        Array.Clear(ref numbers);
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
