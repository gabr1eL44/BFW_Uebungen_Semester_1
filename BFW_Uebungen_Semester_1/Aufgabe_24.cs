using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_24
    {
        public static void Start()
        {
            int[] numbers = new int[0];

            numbers = Array.Add(numbers, 5);
            numbers = Array.Add(numbers, 4);
            numbers = Array.Add(numbers, 8);
            numbers = Array.Add(numbers, 14);
            numbers = Array.Add(numbers, 25);

            numbers = Array.Remove(numbers, 3);

            for (int i = 0; i < numbers.Length; i ++)
                Console.WriteLine("{0}. Eintrag : {1}", (i + 1), numbers[i]);
        }
    }
}
