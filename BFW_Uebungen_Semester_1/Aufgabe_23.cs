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
                else if (eingabe.Length < 6)
                    if (ausgabe != "")
                        ausgabe += " und " + eingabe;
                    else
                        ausgabe += eingabe;
                else
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

                    if (tempString.Length > 5)
                    {                
                        currentPos = 0; string newTempString = ""; lastCharAllowed = false;
                        for (int i = 0; i < tempString.Length; i++)
                        {
                            switch (tempString.ToLower()[i])
                            {
                                case 's':
                                case 't':
                                case 'd':
                                    newTempString += tempString.Substring(currentPos, i - currentPos);
                                    currentPos = i + 1;
                                    break;
                                default:
                                    if (i + 1 == tempString.Length)
                                        lastCharAllowed = true;
                                    break;
                            }
                        }
                        if (lastCharAllowed)
                            newTempString += tempString.Substring(currentPos);
                        tempString = newTempString;
                    }
                    if (ausgabe != "")
                        ausgabe += " und " + tempString;
                    else
                        ausgabe += tempString;
                }
            } while (true);

            Console.WriteLine("Ihr String ist: " + ausgabe);
        }
    }
}
