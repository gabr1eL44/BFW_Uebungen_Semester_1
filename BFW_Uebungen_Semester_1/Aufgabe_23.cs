using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_23
    {
        public static void Start()
        {
            string eingabe; string ausgabe = "";

            Console.WriteLine("Bitte geben Sie String ein:");
            do
            {
                eingabe = Console.ReadLine().Trim();

                if (eingabe.Length == 0)
                    break;
                else if (eingabe.Length > 5)
                {
                    int currentPos = 0; string tempString = ""; bool lastCharAllowed = false;
                    for (int i = 0; i < eingabe.Length; i++)
                    {
                        switch (eingabe.ToLower()[i])
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u':
                                tempString += eingabe.Substring(currentPos, i - currentPos);
                                currentPos = i + 1;
                                break;
                            default:
                                if (i + 1 == eingabe.Length)
                                    lastCharAllowed = true;
                                break;
                        }
                    }
                    if (lastCharAllowed)
                        tempString += eingabe.Substring(currentPos);

                    eingabe = tempString;

                    if (eingabe.Length > 5)
                    {                
                        currentPos = 0; tempString = ""; lastCharAllowed = false;
                        for (int i = 0; i < eingabe.Length; i++)
                        {
                            switch (eingabe.ToLower()[i])
                            {
                                case 's':
                                case 't':
                                case 'd':
                                    tempString += eingabe.Substring(currentPos, i - currentPos);
                                    currentPos = i + 1;
                                    break;
                                default:
                                    if (i + 1 == eingabe.Length)
                                        lastCharAllowed = true;
                                    break;
                            }
                        }
                        if (lastCharAllowed)
                            tempString += eingabe.Substring(currentPos);

                        eingabe = tempString;
                    }
                }

                if (ausgabe != "")
                    ausgabe += " und " + eingabe;
                else
                    ausgabe += eingabe;

            } while (true);

            Console.WriteLine("Ihr String ist: " + ausgabe);
        }
    }
}
