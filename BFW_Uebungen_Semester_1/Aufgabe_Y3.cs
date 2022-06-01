using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_Y3
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie das anzulegende Kapital (K) ein: ");
            int kapital = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Zinssatz pro Jahr (P) ein: ");
            int zinsSatz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Jahre der Anlage (T) ein: ");
            int jahre = Convert.ToInt32(Console.ReadLine());

            double zinsErtrag = kapital * zinsSatz * jahre / 100;
            Console.WriteLine("Ihre Zinserträge nach {0} Jahren belaufen sich auf {1} Euro.", jahre, zinsErtrag);
        }
    }
}
