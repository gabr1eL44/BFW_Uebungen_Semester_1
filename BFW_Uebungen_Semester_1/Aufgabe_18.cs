using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_18
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie eine Begrüßung ein:");
            string eingabe = Console.ReadLine();

            switch(eingabe.Trim().ToLower())
            {
                case "hallo":
                    Console.WriteLine("Hi!");
                    Console.WriteLine("Die Begrüßung '" + eingabe + "' kenne ich :D");
                    break;
                case "hi":
                    Console.WriteLine("Servus!");
                    Console.WriteLine("Die Begrüßung '" + eingabe + "' kenne ich :D");
                    break;
                case "servus":
                    Console.WriteLine("Hallo!");
                    Console.WriteLine("Die Begrüßung '" + eingabe + "' kenne ich :D");
                    break;
                default:
                    Console.WriteLine("Hi!");
                    Console.WriteLine("Leider kenne ich die Begrüßung nicht :(");
                    break;
            }
        }
    }
}