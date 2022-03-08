using System;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_15
    {
        public static void Start()
        {
            sbyte i = 0;
            while (true)
            {
                Console.WriteLine(i++);
                Thread.Sleep(10);
            }
        }
    }
}