using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_8
    {
        public static void Start()
        {
            string inputString = " werPolizeidjsue ";

            inputString = inputString.Trim();
            Console.WriteLine(inputString);

            int n = inputString.Length;
            Console.WriteLine("Anzahl: {0}", n);

            inputString = inputString.Substring(3, 7);
            Console.WriteLine(inputString);

            inputString = inputString.ToUpper();
            Console.WriteLine(inputString);
        }
    }
}
