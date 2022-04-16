using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_9
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie einen String ein:");
            string str = Console.ReadLine();

            // Remove leading and ending blank spaces
            str = str.Trim();

            Console.WriteLine("Länge: " + str.Length);

            // Cut first and last character and make them uppercase
            Console.WriteLine("Erster Buchstabe: " + str.Substring(0,1).ToUpper());
            Console.WriteLine("Letzter Buchstabe: " + str[^1..].ToUpper());

            // Cut first and last character and make them uppercase
            Console.WriteLine("Erster Buchstabe: " + str[0].ToString().ToUpper());
            Console.WriteLine("Letzter Buchstabe: " + str[^1].ToString().ToUpper());
        }
    }
}
