using System;

namespace BFW_Uebungen_Semester_1
{
    class geburtstag
    {
        public static void Start()
        {
            int m = 2, t = 14, j = 2023;
            if (((m - 8) * 100 + (t - 15) >= 0 && j == 2022) || ((m - 2) * 100 + (t - 15) <= 0 && j == 2023))
                Console.WriteLine("Sie haben Geburtstag!");
            else
                Console.WriteLine("Leider kein Geburtstag!");
        }
    }
}
