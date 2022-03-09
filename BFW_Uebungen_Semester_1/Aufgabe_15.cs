using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_15
    {
        public static async void Start()
        {
            string inputString; 
            int inputInt;

            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
                inputString = Console.ReadLine().Trim();

                if (int.TryParse(inputString, out inputInt))
                    break;
                else
                {
                    Console.WriteLine("\nFehlerhafte Eingabe. Bitte eine Zahl eingeben!\n");
                    if (inputString.Length % 2 == 0)
                        Console.WriteLine(inputString.Substring(0, (inputString.Length / 2)) + " | " + inputString.Substring((inputString.Length / 2)) + "\n");
                    else
                        Console.WriteLine(inputString.Substring(0, (inputString.Length / 2)) + " | " + inputString[inputString.Length / 2] + " | " + inputString.Substring((inputString.Length / 2) + 1) + "\n");
                }
            } while (true);
            
            Console.Clear();

            if (inputInt % 2 == 0)
                Console.WriteLine("Zahl " + inputInt + " (gerade) geteilt durch 2 (ohne Rest): " + (inputInt / 2));
            else
                Console.WriteLine("Zahl " + inputInt + " (ungerade) geteilt durch 2 (mit Rest): " + (inputInt / 2) + " Rest " + (inputInt % 2));
        }
    }
}