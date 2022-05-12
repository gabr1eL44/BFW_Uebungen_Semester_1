using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_B2b
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
                    if ((c != '%') && (c != '\\'))
                        res += "%" + i + "%" + c;
                    else 
                        res += "%" + i + "%\\" + c; 
                    c = element;
                    i = 1;
                }
                else i++;
          
            Console.WriteLine(res);

            string temp = ""; bool count = false, escape = false; int anzahl = 0;

            // String wieder entkomprimieren, bool escape dient dem Überspringen von '%' und '\'
            foreach (var element in res)
            {
                if ((element == '%') && (escape == false))
                {
                    if (count)
                    {
                        anzahl = Convert.ToInt32(temp);
                        temp = "";
                    }
                    count = !count;
                }
                else
                {
                    if ((element == '\\') && (escape == false))
                        escape = true;
                    else if (count == false)
                    {
                        for (int j = 0; j < anzahl; j++)
                            Console.Write(element);
                        escape = false;
                    }
                    else
                        temp += element;
                }
            }
        }
    }
}
