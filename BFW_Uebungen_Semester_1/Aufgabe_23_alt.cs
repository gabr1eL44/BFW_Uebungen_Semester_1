using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_23_alt
    {
        public static void Start()
        {
            string eingabe; string ausgabe = "";

            Console.WriteLine("Bitte geben Sie Strings ein:");
            do
            {
                eingabe = Console.ReadLine().Trim();

                if (eingabe.Length == 0)
                    break;

                else if (eingabe.Length > 5)
                {
                    string tempString = "";
                    for (int i = 0; i < eingabe.Length; i++)
                    {
                        switch (eingabe.ToLower()[i])
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u':
                                break;
                            default:
                                tempString += eingabe[i].ToString();
                                break;
                        }
                    }

                    eingabe = tempString;

                    if (eingabe.Length > 5)
                    {
                        tempString = "";
                        for (int i = 0; i < eingabe.Length; i++)
                        {
                            switch (eingabe.ToLower()[i])
                            {
                                case 's':
                                case 't':
                                case 'd':
                                    break;
                                default:
                                    tempString += eingabe[i].ToString();
                                    break;
                            }
                        }
                    }

                    eingabe = tempString;
                }

                if (ausgabe != "")
                    ausgabe += " und " + eingabe;
                else
                    ausgabe = eingabe;

            } while (true);

            Console.WriteLine("Ihr String ist: " + ausgabe);
        }
    }
}
