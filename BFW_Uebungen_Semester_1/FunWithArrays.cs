﻿using System;

namespace BFW_Uebungen_Semester_1
{
    class FunWithArrays
    {
        public static void Start()
        {
            Array.Init(out int[] numbers);

            Array.Push(ref numbers, 1);
            Array.Push(ref numbers, 2);
            Array.Push(ref numbers, 3);

            Array.Insert(ref numbers, 4, 2);
            Array.Remove(ref numbers, 2);

            int laenge = Array.Length(ref numbers);
            for (int i = 0; i < laenge; i++)
            {
                Array.Pop(ref numbers, out int last);
                Console.WriteLine(last);
            }

            Console.WriteLine("\nLänge des Arrays : " + Array.Length(ref numbers));

            Array.Reset(ref numbers);
        }
    }
}
