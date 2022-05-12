using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_B2a
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie eine Zeichenfolge ein: ");
            string input = Console.ReadLine() + ' ';

            char c = input[0];
            int i = 0;
            string res = "";

            // String komprimieren
            foreach (var element in input)
                if (c != element)
                {
                    res += "%" + i + "%" + c;
                    c = element;
                    i = 1;
                }
                else i++;

            Console.WriteLine(res);

            string temp = ""; bool count = false; int anzahl = 0;

            // String wieder entkomprimieren
            foreach (var element in res)
            {
                if (element == '%')
                {
                    if (count)
                    {
                        anzahl = Convert.ToInt32(temp);
                        temp = "";
                    }
                    count = !count;
                }
                else if (count == false)
                {
                    for (int j = 0; j < anzahl; j++)
                        Console.Write(element);
                }
                else
                    temp += element;
            }
        }
    }
}
