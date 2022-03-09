using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_15
    {
        public static async void Start()
        {
            int ausgabeZahl;

            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
                string eingabeString = Console.ReadLine().Trim();

                if (int.TryParse(eingabeString, out ausgabeZahl))
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

            if (ausgabeZahl % 2 == 0)
                Console.WriteLine("Zahl {0} (gerade) geteilt durch 2 (ohne Rest): {1}", ausgabeZahl, (ausgabeZahl / 2));
            else
                Console.WriteLine("Zahl {0} (ungerade) geteilt durch 2 (mit Rest): {1} Rest {2}", ausgabeZahl, (ausgabeZahl / 2), (ausgabeZahl % 2));
        }
    }
}