using System;

namespace BFW_Uebungen_Semester_1
{
     class Uebungen
    {
        public static void Start()
        {
            int[] intArray = new int[] { 37, 28, 47, 28 };
            int[] intArrayNeu = new int[4];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArrayNeu[i] = intArray[i];
            }

            foreach (var item in intArrayNeu)
                Console.WriteLine(item);
        }
    }
}
