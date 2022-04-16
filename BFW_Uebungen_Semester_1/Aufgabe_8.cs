using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_8
    {
        public static void Start()
        {
            string inputString = " werPolizeidjsue ";

            // Entferne Leerzeichen am Anfang und Ende
            inputString = inputString.Trim();
            Console.WriteLine(inputString);

            // Gibt die Länge des Strings aus
            int n = inputString.Length;
            Console.WriteLine("Anzahl: {0}", n);

            // Entnimmt nur den Teil "Polizei" aus String
            inputString = inputString.Substring(3, 7);
            Console.WriteLine(inputString);

            // Wandelt alles in Großbuchstaben
            inputString = inputString.ToUpper();
            Console.WriteLine(inputString);           
        }
    }
}
