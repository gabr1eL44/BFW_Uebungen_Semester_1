using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_24
    {
        public static void Start()
        {
            int number;

            Console.Write("Bitte Eingabe: ");
            string eingabe = Console.ReadLine();

            if (!int.TryParse(eingabe, out number))
                number = -1;

            Console.WriteLine("Ihre Zahl: " + number);

        }
    }
}
