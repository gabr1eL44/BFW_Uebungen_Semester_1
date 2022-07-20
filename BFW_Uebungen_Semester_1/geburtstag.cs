using System;

namespace BFW_Uebungen_Semester_1
{
    class Geburtstag
    {
        public static void Start()
        {
            int t = 14, m = 8, j = 2022;
            if (((m - 8) * 100 + (t - 15) >= 0 && j == 2022) || ((m - 2) * 100 + (t - 15) <= 0 && j == 2023))
                Console.WriteLine("Sie haben Geburtstag!");
            else
                Console.WriteLine("Leider kein Geburtstag!");
        }
    }
}
