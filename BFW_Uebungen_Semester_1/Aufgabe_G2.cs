using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_G2
    {
        public static void Start()
        {
            int zahl;
            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl mit mindestens 3 Stellen ein:");
                string eingabe = Console.ReadLine();

                if ((Int32.TryParse(eingabe, out zahl)) && (zahl > 100))
                    break;
                else
                {
                    Console.WriteLine("Leider entspricht Ihre Zahl nicht den Vorgaben.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            string temp = "";
            for (int i = Convert.ToString(zahl).Length - 1; i >= 0; i--)
                temp += Convert.ToString(zahl)[i];

            Console.Clear();
            Console.WriteLine("Hier ist die 1. Ziffer: " + temp[0]);
            Console.WriteLine("Hier ist die 2. Ziffer: " + temp[1]);

            double result1 = (double)(temp[1] - '0') / (temp[0] - '0');
            Math.Round(result1, 2);

            double result2 = (double)(temp[0] - '0') / (temp[1] - '0');
            Math.Round(result2, 2);

            if (result1 > result2)
            {
                Console.WriteLine("Hier ist das größere Ergebnis: " + result1);
                Console.WriteLine("Hier ist das kleinere Ergebnis: " + result2);
            }
            else
            {
                Console.WriteLine("Hier ist das größere Ergebnis: " + result2);
                Console.WriteLine("Hier ist das kleinere Ergebnis: " + result1);
            }
        }
    }
}
