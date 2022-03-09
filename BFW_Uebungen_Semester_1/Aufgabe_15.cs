using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_15
    {
        public static void Start()
        {
            int eingabeZahl;

            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
                string eingabeString = Console.ReadLine().Trim();

                if (int.TryParse(eingabeString, out eingabeZahl))
                    break;
                else
                {
                    Console.WriteLine("\nFehlerhafte Eingabe. Bitte eine Zahl eingeben!\n");
                                        
                    if (eingabeString.Length % 2 == 0)
                        Console.WriteLine(eingabeString.Substring(0, (eingabeString.Length / 2)) + " | " + eingabeString.Substring((eingabeString.Length / 2)) + "\n");
                    else
                        Console.WriteLine(eingabeString.Substring(0, (eingabeString.Length / 2)) + " | " + eingabeString[eingabeString.Length / 2] + " | " + eingabeString.Substring((eingabeString.Length / 2) + 1) + "\n");
                }
            } while (true);
            
            Console.Clear();

            if (eingabeZahl % 2 == 0)
                Console.WriteLine("Zahl " + eingabeZahl + " (gerade) geteilt durch 2 (ohne Rest): " + (eingabeZahl / 2));
            else
                Console.WriteLine("Zahl " + eingabeZahl + " (ungerade) geteilt durch 2 (mit Rest): " + (eingabeZahl / 2) + " Rest " + (eingabeZahl % 2));
        }
    }
}