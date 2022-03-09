using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_16
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            string ausgabe = (eingabe % 2 == 0) ? "Die Zahl ist gerade." : "Die Zahl ist ungerade.";
            Console.WriteLine(ausgabe);

            ausgabe = (eingabe % 7 == 0) ? "Die Zahl ist durch 7 teilbar" : "Die Zahl ist nicht durch 7 teilbar";
            Console.WriteLine(ausgabe);
        }
    }
}
