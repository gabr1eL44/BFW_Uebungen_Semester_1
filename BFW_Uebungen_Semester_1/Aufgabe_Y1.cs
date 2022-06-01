using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_Y1
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (!(Console.ReadLine() is null))
            {
                Console.Clear();
                number *= 2;
                Console.WriteLine("Ihre Zahl verdoppelt lautet: " + number);
            }
        }
    }
}
