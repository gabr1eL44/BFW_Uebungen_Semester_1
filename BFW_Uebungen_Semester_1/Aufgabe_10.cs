﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_10
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie eine Zahl ein: ");

            string numberString = Console.ReadLine();
            int numberInt = Convert.ToInt32(numberString);

            Console.Clear();

            Console.WriteLine("Ihre eingegebene Zahl: " + numberInt);
            Console.WriteLine("Das ist das Doppelte: " + numberInt * 2);
            Console.WriteLine("Das ist die Hälfte: " + numberInt / 2);
            Console.WriteLine("Das ist de Rest bei der Teilung durch 7: " + numberInt % 7);
        }
    }
}
