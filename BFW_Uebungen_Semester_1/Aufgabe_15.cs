using System;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_15
    {
        public static void Start()
        {
            for (sbyte i = 0; i < 99999; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5);
            }
        }
    }
}