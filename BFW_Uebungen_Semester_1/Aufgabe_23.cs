using System;

namespace BFW_Uebungen_Semester_1
{
    // Dieselbe Aufgabe ist in Aufgabe_23_alt.cs einfacher gelöst (hier mit Substrings, dort mit einfachen Chars)
    class Aufgabe_23
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
                    int currentBasePos = 0; string tempString = ""; bool lastCharAllowed = false;
                    for (int i = 0; i < eingabe.Length; i++)
                    {
                        switch (eingabe.ToLower()[i])
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u':
                                tempString += eingabe[currentBasePos..i];
                                currentBasePos = i + 1;
                                break;
                            default:
                                if (i + 1 == eingabe.Length)
                                    lastCharAllowed = true;
                                break;
                        }
                    }
                    if (lastCharAllowed)
                        tempString += eingabe[currentBasePos..];

                    eingabe = tempString;

                    if (eingabe.Length > 5)
                    {                
                        currentBasePos = 0; tempString = ""; lastCharAllowed = false;
                        for (int i = 0; i < eingabe.Length; i++)
                        {
                            switch (eingabe.ToLower()[i])
                            {
                                case 's':
                                case 't':
                                case 'd':
                                    tempString += eingabe[currentBasePos..i];
                                    currentBasePos = i + 1;
                                    break;
                                default:
                                    if (i + 1 == eingabe.Length)
                                        lastCharAllowed = true;
                                    break;
                            }
                        }
                        if (lastCharAllowed)
                            tempString += eingabe[currentBasePos..];

                        eingabe = tempString;
                    }
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
