using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_G1
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int zahl))
                {
                    zahl *= 3;
                    if (zahl % 2 == 0)
                    {
                        int counter = 0;
                        do
                        {
                            zahl /= 2;
                            counter++;
                        } while (zahl > 0);
                        Console.WriteLine("Ihr Ergebnis ist {0}.", counter);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Leider ist Ihre Zahl unpassend!");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            }
        }
    }
}
