using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_10
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie einen String ein:");
            string input = Console.ReadLine();

            Console.WriteLine(input);
            input = input.Trim();

            Console.WriteLine("Länge: " + input.Length);
            Console.WriteLine("Erster Buchstabe: " + input[0].ToString().ToUpper());
            Console.WriteLine("Letzter Buchstabe: " + input[input.Length - 1].ToString().ToUpper());    

            Console.WriteLine("Erster Buchstabe: " + input.Substring(0, 1).ToUpper());
            Console.WriteLine("Letzter Buchstabe: " + input.Substring(input.Length - 1).ToUpper());
        }
    }
}