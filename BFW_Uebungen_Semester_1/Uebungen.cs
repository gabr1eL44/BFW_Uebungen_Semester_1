using System;

namespace BFW_Uebungen_Semester_1
{
    internal class Uebungen
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie den gewünschten Betrag ein (€ oder $): ");
            string str = Console.ReadLine();

            char currency = str.Trim()[^1];
            bool error = false;
            if (!decimal.TryParse(str.Trim()[..^1], out decimal value))
                error = true;

            if (currency == '€' && !error)
                Console.WriteLine("Es wurden {0} Euro eingegeben!", value);
            else if (currency == '$' && !error)
                Console.WriteLine("Es wurden {0} Dollar eingegeben!", value);
            else
                Console.WriteLine("Fehlerhafte Eingabe!");
        }
    }
}
