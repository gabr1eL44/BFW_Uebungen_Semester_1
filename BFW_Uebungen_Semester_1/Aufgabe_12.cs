using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_12
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie Ihre Zahl ein: ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            Console.Clear();
            Console.WriteLine("Ihre eigegebene Zahl: " + number);
        }
    }
}