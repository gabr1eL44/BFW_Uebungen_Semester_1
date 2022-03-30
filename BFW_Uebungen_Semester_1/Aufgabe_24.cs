using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_24
    {
        public static void Start()
        {
            Array.Init(out int[] numbers);

            Array.Push(ref numbers, 1);
            Array.Push(ref numbers, 2);
            Array.Push(ref numbers, 3);

            Array.Insert(ref numbers, 4, 2);
            Array.Remove(ref numbers, 2);

            int laenge = numbers.Length;
            for (int i = 0; i < laenge; i++)
            {
                Array.Pop(ref numbers, out int last);
                Console.WriteLine(last);
            }

            Console.WriteLine("\n\nLänge des Arrays : " + numbers.Length);

            Array.Clear(ref numbers);
        }
    }
}
