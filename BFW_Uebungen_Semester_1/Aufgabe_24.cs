using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_24
    {
        public static void Start()
        {
            int[] numbers = new int[0];

            Array.Add(ref numbers, 5);
            Array.Add(ref numbers, 3);

            Array.Insert(ref numbers, 4, 1);

            

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("{0}. Eintrag in Array : {1}", (i + 1), numbers[i]);

            
        }
    }
}
