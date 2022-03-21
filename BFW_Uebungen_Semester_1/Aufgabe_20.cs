using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_20
    {
        public static void Start()
        {
            int[] numbers = new int[] { 34, 5, 83, 28, 44, 99, 30, 72, 28 };

            foreach (int element in numbers)
            {
                Console.WriteLine("Die Zahl: " + element);
                Console.WriteLine("Die Hälfte: " + element / 2);
                Console.WriteLine("Das Doppelte: " + element * 2 + "\n");
            }
        }
    }
}
