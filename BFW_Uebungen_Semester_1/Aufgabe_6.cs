using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_6
    {
        public static void Start()
        {
            string string1 = "Hallo. "; string string2 = "Hier kommt das Ergebnis: ";

            int var1 = 160; int var2 = 20;

            Console.Write(string1 + string2);

            int res = var1 / var2;
            res = (res / 2) * var2;
            res = res - var1 + 3 * var2;

            Console.WriteLine(res % 27 + "\n");

            //Repeat with different values for var1 and var2
            var1 = 3600; var2 = 360;

            Console.Write(string1 + string2);

            res = var1 / var2;
            res = (res / 2) * var2;
            res = res - var1 + 3 * var2;

            Console.WriteLine(res % 27 + "\n");
        }
    }
}