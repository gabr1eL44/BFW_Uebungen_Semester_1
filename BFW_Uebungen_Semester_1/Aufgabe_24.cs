using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_24
    {
        public static void Start()
        {
            int[] numbers = new int[0];

            Array.Add(ref numbers, 67);
            Array.Clear(ref numbers);

            numbers = Array.Add(numbers, 67);
            numbers = Array.Clear(numbers);

            Array.Add(ref numbers, 5);
            Array.Add(ref numbers, 4);
            numbers = Array.Add(numbers, 8);
            numbers = Array.Add(numbers, 25);
            Array.Add(ref numbers, 47);
            Array.Add(ref numbers, 98);

            Array.Remove(ref numbers, 3);
            numbers = Array.Remove(numbers, 3);

            for (int i = 0; i < numbers.Length; i ++)
                Console.WriteLine("{0}. Eintrag : {1}", (i + 1), numbers[i]);
        }
    }
}
